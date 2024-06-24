using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ООП_Курсовая_Тында
{
    public partial class CarForm : Form
    {
        /// <summary>Поле хранящее данные  о машинах и позволяющее записывать в файл и загружать из файла</summary>
        private CarDealership? _CarDealership;
        /// <summary>
        /// Последняя выбранная машина
        /// </summary>
        private Car? LastCar;
        /// <summary>контсруктор главной формы</summary>
        public CarForm()
        {
            InitializeComponent();
            string rash = ".CarDealership";
            openFileDialog1.Filter = String.Format("Файл с данными|*{0}", rash);
            openFileDialog1.DefaultExt = rash;
            saveFileDialog1.Filter = String.Format("Файл с данными|*{0}", rash);
            saveFileDialog1.DefaultExt = rash;
            comboBoxFilterValue.Enabled = false;
        }

        /// <summary>Обработчик загрузки формы</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            BlockInterface(true);
            BlockEdit(true);
            buttonClearFilter.Enabled = false;
            dateTimePickerAddYear.CustomFormat = dateTimePickerEditYear.CustomFormat = "yyyy";
            var tmpForm = new Form() { Size = new Size(0, 0) };
            Task.Delay(TimeSpan.FromSeconds(10)).ContinueWith((t) => tmpForm.Close(), TaskScheduler.FromCurrentSynchronizationContext());
            MessageBox.Show(tmpForm, "Автор: Тында Евгений\nТема: «Автосалон»", "Курсовое проектирование");

        }

        /// <summary>Обновляет таблицу на форме, используя данные из БД</summary>
        private void UpdateDataGredview()
        {
            if (_CarDealership == null)
                throw new NullReferenceException();
            dataGridView1.Rows.Clear();
            if (comboBoxFilterValue.SelectedIndex == -1)
                foreach (Car car in _CarDealership.GetCars())
                    dataGridView1.Rows.Add(car._number, car._mark, car._volume, car._sit, car._cost, car._year);
            else
            {
                int tmp = 0;

                string value = comboBoxFilterValue.Text;
                List<Car> list = _CarDealership.GetCars();
                int count = list.Count;
                switch (comboBoxFilter.SelectedItem)
                {
                    case "Номер":
                        foreach (Car car in list)
                        {
                            if (car._number == value)
                            {
                                dataGridView1.Rows.Add(car._number, car._mark, car._volume, car._sit, car._cost, car._year);
                                tmp++;
                            }
                        }
                        break;
                    case "Марка":
                        foreach (Car car in list)
                        {
                            if (car._mark == value)
                            {
                                dataGridView1.Rows.Add(car._number, car._mark, car._volume, car._sit, car._cost, car._year);
                                tmp++;
                            }
                        }
                        break;
                    case "Объем бензобака":
                        foreach (Car car in list)
                        {
                            if (Convert.ToString(car._volume) == value)
                            {
                                dataGridView1.Rows.Add(car._number, car._mark, car._volume, car._sit, car._cost, car._year);
                                tmp++;
                            }
                        }
                        break;
                    case "Количество мест":
                        foreach (Car car in list)
                        {
                            if (Convert.ToString(car._sit) == value)
                            {
                                dataGridView1.Rows.Add(car._number, car._mark, car._volume, car._sit, car._cost, car._year);
                                tmp++;
                            }
                        }
                        break;
                    case "Стоимость":
                        foreach (Car car in list)
                        {
                            if (Convert.ToString(car._cost) == value)
                            {
                                dataGridView1.Rows.Add(car._number, car._mark, car._volume, car._sit, car._cost, car._year);
                                tmp++;
                            }
                        }
                        break;
                    case "Год создания":
                        foreach (Car car in list)
                        {
                            if (car._year == value)
                            {
                                dataGridView1.Rows.Add(car._number, car._mark, car._volume, car._sit, car._cost, car._year);
                                tmp++;
                            }
                        }
                        break;

                }
                MessageBox.Show("Показано " + tmp + " из " + count + " машин", "Результаты фильтрации");
            }



            if (dataGridView1.CurrentCell == null) BlockEdit(true);
            else BlockEdit(false);

        }

        /// <summary>Блокирует или разблокирет пользовательский интерфейс</summary>
        /// <param name="val">При значении true блокирует пользователжю доступ к элементам на форме</param>
        private void BlockInterface(bool val)
        {
            groupBoxFilter.Enabled = !val;
            tabControl.Enabled = !val;
            dataGridView1.Enabled = !val;
            buttonFilter.Enabled = false;
            открытьToolStripMenuItem.Enabled = val;
            открытьToolStripMenuItem1.Enabled = val;
            сохранитьToolStripMenuItem.Enabled = !val;
            удалитьToolStripMenuItem.Enabled = !val;
            клиентыToolStripMenuItem.Enabled= !val;
        }

        /// <summary>Блокирет или разблокирет редактирование пользователей</summary>
        /// <param name="val">при true блокирет редактирование пользователей</param>
        private void BlockEdit(bool val)
        {
            label1.Enabled = label2.Enabled = label3.Enabled = label4.Enabled = label5.Enabled = label6.Enabled = !val;
            textBoxEditMark.Enabled = !val;
            textBoxEditNumber.Enabled = !val;
            numericUpDownEditCost.Enabled = !val;
            numericUpDownEditSit.Enabled = !val;
            numericUpDownEditVolume.Enabled = !val;
            dateTimePickerEditYear.Enabled = !val;
            buttonEdit.Enabled = !val;
            buttonDelete.Enabled = !val;
        }

        /// <summary>Обновляет поля редактирования на форме данными из таблицы</summary>
        private void UpdateEdit()
        {
            if (_CarDealership == null)
                throw new NullReferenceException();
            textBoxEditNumber.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
            textBoxEditMark.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value);
            numericUpDownEditVolume.Value = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value);
            numericUpDownEditSit.Value = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value);
            numericUpDownEditCost.Value = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value);
            dateTimePickerEditYear.Value = new DateTime(Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value), 1, 1);
            foreach (Car car in _CarDealership.GetCars())
            {
                if (car._number == textBoxEditNumber.Text)
                {
                    LastCar = car;
                    break;
                }
            }
        }

        /// <summary>Обработчик нажатия в меню пункта создать</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CarDealership = new CarDealership();
            UpdateDataGredview();
            BlockInterface(false);
        }

        /// <summary>Обработчик нажатия в меню пункта открыть БД</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void открытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            try
            {
                string path = openFileDialog1.FileName;
                _CarDealership = new CarDealership();
                _CarDealership.Load(path);
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("Открыт неккоректный файл", "Ошибка");
                return;
            }
            BlockInterface(false);
            UpdateDataGredview();
        }

        /// <summary>Обработчик нажатия в меню пункта сохранить БД</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_CarDealership == null)
                throw new NullReferenceException();
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            _CarDealership.Save(saveFileDialog1.FileName);
        }

        /// <summary>Обработчик нажатия в меню пункта удалить</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            _CarDealership = null;
            BlockInterface(true);
            BlockEdit(true);
        }

        /// <summary>Обработчик изменения выбранной строки в таблице на форме</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
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
            string number = Regex.Replace(textBoxAddNumber.Text, @"\s+", " ");
            string mark = Regex.Replace(textBoxAddMark.Text, @"\s+", " ");
            if (number == "" || mark == "")
            {
                MessageBox.Show("Одно из полей пусто", "Ошибка");
                return;
            }
            foreach (Car car in _CarDealership.GetCars())
            {
                if (car._number == number)
                {
                    MessageBox.Show("Такой номер уже есть в БД", "Ошибка");
                    return;
                }
            }
            _CarDealership.GetCars().Add(new Car(number, mark, Convert.ToInt32(numericUpDownAddVolume.Value), Convert.ToInt32(numericUpDownAddSits.Value), Convert.ToInt32(numericUpDownAddCost.Value), dateTimePickerAddYear.Value.ToString("yyyy")));
            UpdateDataGredview();
            UpdateEdit();
            comboBoxFilter_SelectedIndexChanged(sender, e);
        }

        /// <summary>Обработчик нажатия кнопки "редактировать" на форме</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (_CarDealership == null||LastCar ==null) throw new NullReferenceException();
            string number = Regex.Replace(textBoxEditNumber.Text, @"\s+", " ");
            string mark = Regex.Replace(textBoxEditMark.Text, @"\s+", " ");
            if (number == "" || mark == "")
            {
                MessageBox.Show("Одно из полей пусто", "Ошибка");
                return;
            }
            if (LastCar._number != number)
                foreach (Car car in _CarDealership.GetCars())
                {
                    if (car._number == number)
                    {
                        MessageBox.Show("Такоq номер уже есть в БД", "Ошибка");
                        return;
                    }
                }
            _CarDealership.GetCars().Remove(LastCar);
            LastCar = null;
            _CarDealership.GetCars().Add(new Car(number, mark, Convert.ToInt32(numericUpDownEditVolume.Value), Convert.ToInt32(numericUpDownEditSit.Value), Convert.ToInt32(numericUpDownEditCost.Value), dateTimePickerEditYear.Value.ToString("yyyy")));
            UpdateDataGredview();
            UpdateEdit();
        }

        /// <summary>Обработчик конпки "удалить выбранный элемент" на форме</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (_CarDealership == null) throw new NullReferenceException();
            if (LastCar != null)
            {
                _CarDealership.GetCars().Remove(LastCar);
                LastCar = null;
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
            buttonFilter.Enabled = false;
            switch (comboBoxFilter.SelectedItem)
            {
                case "Номер":
                    foreach (Car car in _CarDealership.GetCars())
                    {
                        string value = car._number;
                        if (!comboBoxFilterValue.Items.Contains(value))
                            comboBoxFilterValue.Items.Add(value);
                    }
                    break;
                case "Марка":
                    foreach (Car car in _CarDealership.GetCars())
                    {
                        string value = car._mark;
                        if (!comboBoxFilterValue.Items.Contains(value))
                            comboBoxFilterValue.Items.Add(value);
                    }
                    break;
                case "Объем бензобака":
                    foreach (Car car in _CarDealership.GetCars())
                    {
                        int value = car._volume;
                        if (!comboBoxFilterValue.Items.Contains(value))
                            comboBoxFilterValue.Items.Add(value);
                    }
                    break;
                case "Количество мест":
                    foreach (Car car in _CarDealership.GetCars())
                    {
                        int value = car._sit;
                        if (!comboBoxFilterValue.Items.Contains(value))
                            comboBoxFilterValue.Items.Add(value);
                    }
                    break;
                case "Стоимость":
                    foreach (Car car in _CarDealership.GetCars())
                    {
                        int value = car._cost;
                        if (!comboBoxFilterValue.Items.Contains(value))
                            comboBoxFilterValue.Items.Add(value);
                    }
                    break;
                case "Год создания":
                    foreach (Car car in _CarDealership.GetCars())
                    {
                        string value = car._year;
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
        private void buttonFilter_Click_1(object sender, EventArgs e)
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

        /// <summary>
        /// обрабатывает нажатие пользователяна кнопку клиенты
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_CarDealership == null) throw new NullReferenceException();
            ClientForm form = new ClientForm(_CarDealership);
            form.ShowDialog();
        }



    }
}
