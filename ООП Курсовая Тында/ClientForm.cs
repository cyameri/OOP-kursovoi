using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ООП_Курсовая_Тында
{
    /// <summary>
    /// форма для работы с клиентами
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    internal partial class ClientForm : Form
    {
        /// <summary>Поле хранящее данные  о клиентах и позволяющее записывать в файл и загружать из файла</summary>
        CarDealership _CarDealership;

        /// <summary>
        /// Последняя выбранный клиент
        /// </summary>
        Client? LastClient;

        /// <summary>
        /// инициализирует <see cref="ClientForm"/> class.
        /// </summary>
        /// <param name="carDealership">The car dealership.</param>
        public ClientForm(CarDealership carDealership)
        {
            _CarDealership = carDealership;
            InitializeComponent();

        }

        /// <summary>Обработчик загрузки формы</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void ClientForm_Load(object sender, EventArgs e)
        {
            foreach (Car car in _CarDealership.GetCars())
            {
                comboBoxAddNumber.Items.Add(car._number);
                comboBoxEditNumberCar.Items.Add(car._number);
            }
        }

        /// <summary>Обновляет таблицу на форме, используя данные из БД</summary>
        private void UpdateDataGredview()
        {
            if (_CarDealership == null)
                throw new NullReferenceException();
            dataGridView1.Rows.Clear();
            if (comboBoxFilterValue.SelectedIndex == -1)
                foreach (Client client in _CarDealership.GetClients())
                    dataGridView1.Rows.Add(client._name,client._carnumber,client._post);
            else
            {
                int tmp = 0;

                string filterValue = comboBoxFilterValue.Text;
                List<Car> list = _CarDealership.GetCars();
                int count = list.Count;
                switch (comboBoxFilter.SelectedItem)
                {
                    case "ФИО":
                        foreach (Client client in _CarDealership.GetClients())
                        {
                            if (client._name == filterValue)
                            {
                                dataGridView1.Rows.Add(client._name, client._carnumber, client._post);
                                tmp++;
                            }
                        }
                        break;
                    case "Номер машины":
                        foreach (Client client in _CarDealership.GetClients())
                        {
                            if (client._carnumber == filterValue)
                            {
                                dataGridView1.Rows.Add(client._name, client._carnumber, client._post);
                                tmp++;
                            }
                        }
                        break;
                    case "Должность":
                        foreach (Client client in _CarDealership.GetClients())
                        {
                            if (client._post == filterValue)
                            {
                                dataGridView1.Rows.Add(client._name, client._carnumber, client._post);
                                tmp++;
                            }
                        }
                        break;
                }
                MessageBox.Show("Показано " + tmp + " из " + count + " клиентов", "Результаты фильтрации");

            }



            if (dataGridView1.CurrentCell == null) BlockEdit(true);
            else BlockEdit(false);

        }

        /// <summary>Блокирет или разблокирет редактирование пользователей</summary>
        /// <param name="val">при true блокирет редактирование пользователей</param>
        private void BlockEdit(bool val)
        {
            label1.Enabled = label2.Enabled = label3.Enabled = !val;

            textBoxEditName.Enabled =textBoxEditPost.Enabled= comboBoxEditNumberCar.Enabled = !val;
            buttonEdit.Enabled = !val;
            buttonDelete.Enabled = !val;
        }

        /// <summary>
        /// обрабатывает нажатие кнопки вернуться
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void вернутьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>Обработчик изменения выбранной строки в таблице на форме</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null) BlockEdit(true);
            else
            {
                BlockEdit(false);

            }
            UpdateEdit();
        }

        /// <summary>Обработчик нажатия кнопки "Добавить" на форме</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (_CarDealership == null) throw new NullReferenceException();
            string name = Regex.Replace(textBoxAddName.Text, @"\s+", " ");
            string post = Regex.Replace(textBoxAddPost.Text, @"\s+", " ");
            if (name == "" || post == "" || comboBoxAddNumber.SelectedIndex == -1)
            {
                MessageBox.Show("Одно из полей пусто", "Ошибка");
                return;
            }
            foreach (Client client in _CarDealership.GetClients())
            {
                if (client._carnumber == comboBoxAddNumber.Text)
                {
                    MessageBox.Show("Машина уже зарегестрирована на другого", "Ошибка");
                    return;
                }
            }
            _CarDealership.GetClients().Add(new Client(name, comboBoxAddNumber.Text, post));
            UpdateDataGredview();
            UpdateEdit();
            comboBoxFilter_SelectedIndexChanged(sender, e);
        }

        /// <summary>Обновляет поля редактирования на форме данными из таблицы</summary>
        private void UpdateEdit()
        {
            if (_CarDealership == null)
                throw new NullReferenceException();
            textBoxEditName.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
            comboBoxEditNumberCar.SelectedIndex = comboBoxEditNumberCar.Items.IndexOf(Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value));
            textBoxEditPost.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value);
            foreach (Client client in _CarDealership.GetClients())
            {
                if (client._carnumber == comboBoxAddNumber.Text)
                {
                    LastClient = client;
                    return;
                }
            }
        }

        /// <summary>Обработчик нажатия кнопки "редактировать" на форме</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (_CarDealership == null || LastClient == null) throw new NullReferenceException();
            string name = Regex.Replace(textBoxEditName.Text, @"\s+", " ");
            string post = Regex.Replace(textBoxEditPost.Text, @"\s+", " ");
            if (name == "" || post == "" || comboBoxEditNumberCar.SelectedIndex == -1)
            {
                MessageBox.Show("Одно из полей пусто", "Ошибка");
                return;
            }
            if (LastClient._carnumber != comboBoxEditNumberCar.Text)
            {
                foreach (Client client in _CarDealership.GetClients())
                {
                    if (client._carnumber == comboBoxEditNumberCar.Text)
                    {
                        MessageBox.Show("Машина уже зарегестрирована на другого", "Ошибка");
                        return;
                    }
                }
            }
                _CarDealership.GetClients().Remove(LastClient);
                LastClient = null;
                _CarDealership.GetClients().Add(new Client(name, comboBoxEditNumberCar.Text, post));
                UpdateDataGredview();
                UpdateEdit();
            
        }

        /// <summary>Обработчик конпки "удалить выбранный элемент" на форме</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (_CarDealership == null) throw new NullReferenceException();
            if (LastClient != null)
            {
                _CarDealership.GetClients().Remove(LastClient);
                LastClient = null;
                UpdateDataGredview();
            }
        }

        /// <summary>Обработчик смены выбранного значения в поле фильтрации</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_CarDealership == null) throw new NullReferenceException();
            comboBoxFilterValue.Items.Clear();
            comboBoxFilterValue.SelectedIndex = -1;
            comboBoxFilterValue.Enabled = true;
            buttonClearFilter.Enabled = false;
            buttonFilter.Enabled = false;
            switch (comboBoxFilter.SelectedItem)
            {
                case "ФИО":
                    foreach (Client client in _CarDealership.GetClients())
                    {
                        string value = client._name;
                        if (!comboBoxFilterValue.Items.Contains(value))
                            comboBoxFilterValue.Items.Add(value);
                    }
                    break;
                case "Номер машины":
                    foreach (Client client in _CarDealership.GetClients())
                    {
                        string value = client._carnumber;
                        if (!comboBoxFilterValue.Items.Contains(value))
                            comboBoxFilterValue.Items.Add(value);
                    }
                    break;
                case "Должность":
                    foreach (Client client in _CarDealership.GetClients())
                    {
                        string value = client._post;
                        if (!comboBoxFilterValue.Items.Contains(value))
                            comboBoxFilterValue.Items.Add(value);
                    }
                    break;
            }
        }

        /// <summary>Обработчик смены выбранного значения фильтра</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void comboBoxFilterValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFilterValue.SelectedIndex != -1)
            {
                buttonFilter.Enabled = true;
            }
        }

        /// <summary>Обрабочик нажатия на кнопку фильтрации на форме</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void buttonFilter_Click(object sender, EventArgs e)
        {
            buttonClearFilter.Enabled = true;
            UpdateDataGredview();
        }

        /// <summary>Обработчик кнопки "сбросить фильты"</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void buttonClearFilter_Click(object sender, EventArgs e)
        {
            comboBoxFilter.SelectedIndex = -1;
            comboBoxFilterValue.SelectedIndex = -1;
            comboBoxFilterValue.Enabled = false;
            buttonClearFilter.Enabled = false;
            buttonFilter.Enabled = false;
        }
    }
}
