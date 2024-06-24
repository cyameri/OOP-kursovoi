namespace ООП_Курсовая_Тында
{
    partial class CarForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxFilter = new GroupBox();
            buttonClearFilter = new Button();
            comboBoxFilterValue = new ComboBox();
            comboBoxFilter = new ComboBox();
            label7 = new Label();
            buttonFilter = new Button();
            label8 = new Label();
            buttonDelete = new Button();
            tabControl = new TabControl();
            tabPageAdd = new TabPage();
            textBoxAddMark = new TextBox();
            numericUpDownAddVolume = new NumericUpDown();
            numericUpDownAddSits = new NumericUpDown();
            numericUpDownAddCost = new NumericUpDown();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            dateTimePickerAddYear = new DateTimePicker();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            buttonAdd = new Button();
            textBoxAddNumber = new TextBox();
            tabPageEdit = new TabPage();
            textBoxEditMark = new TextBox();
            numericUpDownEditVolume = new NumericUpDown();
            buttonEdit = new Button();
            numericUpDownEditSit = new NumericUpDown();
            textBoxEditNumber = new TextBox();
            numericUpDownEditCost = new NumericUpDown();
            label6 = new Label();
            label1 = new Label();
            label5 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            dateTimePickerEditYear = new DateTimePicker();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem1 = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            клиентыToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            groupBoxFilter.SuspendLayout();
            tabControl.SuspendLayout();
            tabPageAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAddVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAddSits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAddCost).BeginInit();
            tabPageEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEditVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEditSit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEditCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxFilter
            // 
            groupBoxFilter.Controls.Add(buttonClearFilter);
            groupBoxFilter.Controls.Add(comboBoxFilterValue);
            groupBoxFilter.Controls.Add(comboBoxFilter);
            groupBoxFilter.Controls.Add(label7);
            groupBoxFilter.Controls.Add(buttonFilter);
            groupBoxFilter.Controls.Add(label8);
            groupBoxFilter.Location = new Point(8, 24);
            groupBoxFilter.Name = "groupBoxFilter";
            groupBoxFilter.Size = new Size(266, 132);
            groupBoxFilter.TabIndex = 60;
            groupBoxFilter.TabStop = false;
            groupBoxFilter.Text = "Фильтровать";
            // 
            // buttonClearFilter
            // 
            buttonClearFilter.Location = new Point(9, 105);
            buttonClearFilter.Name = "buttonClearFilter";
            buttonClearFilter.Size = new Size(251, 21);
            buttonClearFilter.TabIndex = 53;
            buttonClearFilter.Text = "Сбросить фильтр";
            buttonClearFilter.UseVisualStyleBackColor = true;
            buttonClearFilter.Click += buttonClearFilter_Click;
            // 
            // comboBoxFilterValue
            // 
            comboBoxFilterValue.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilterValue.FormattingEnabled = true;
            comboBoxFilterValue.Location = new Point(73, 53);
            comboBoxFilterValue.Name = "comboBoxFilterValue";
            comboBoxFilterValue.Size = new Size(187, 23);
            comboBoxFilterValue.TabIndex = 16;
            comboBoxFilterValue.SelectedIndexChanged += comboBoxFilterValue_SelectedIndexChanged;
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Items.AddRange(new object[] { "Номер", "Марка", "Объем бензобака", "Количество мест", "Стоимость", "Год создания" });
            comboBoxFilter.Location = new Point(38, 21);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(222, 23);
            comboBoxFilter.TabIndex = 4;
            comboBoxFilter.SelectedIndexChanged += comboBoxFilter_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 24);
            label7.Name = "label7";
            label7.Size = new Size(23, 15);
            label7.TabIndex = 14;
            label7.Text = "По";
            // 
            // buttonFilter
            // 
            buttonFilter.Location = new Point(9, 82);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(251, 21);
            buttonFilter.TabIndex = 52;
            buttonFilter.Text = "Фильтровать";
            buttonFilter.UseVisualStyleBackColor = true;
            buttonFilter.Click += buttonFilter_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 56);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 15;
            label8.Text = "значение";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(14, 408);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(260, 23);
            buttonDelete.TabIndex = 59;
            buttonDelete.Text = "Удалить выбранную машину";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageAdd);
            tabControl.Controls.Add(tabPageEdit);
            tabControl.Location = new Point(8, 162);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(266, 240);
            tabControl.TabIndex = 58;
            // 
            // tabPageAdd
            // 
            tabPageAdd.BackColor = Color.Silver;
            tabPageAdd.Controls.Add(textBoxAddMark);
            tabPageAdd.Controls.Add(numericUpDownAddVolume);
            tabPageAdd.Controls.Add(numericUpDownAddSits);
            tabPageAdd.Controls.Add(numericUpDownAddCost);
            tabPageAdd.Controls.Add(label14);
            tabPageAdd.Controls.Add(label13);
            tabPageAdd.Controls.Add(label12);
            tabPageAdd.Controls.Add(dateTimePickerAddYear);
            tabPageAdd.Controls.Add(label11);
            tabPageAdd.Controls.Add(label10);
            tabPageAdd.Controls.Add(label9);
            tabPageAdd.Controls.Add(buttonAdd);
            tabPageAdd.Controls.Add(textBoxAddNumber);
            tabPageAdd.Location = new Point(4, 24);
            tabPageAdd.Name = "tabPageAdd";
            tabPageAdd.Padding = new Padding(3);
            tabPageAdd.Size = new Size(258, 212);
            tabPageAdd.TabIndex = 0;
            tabPageAdd.Text = "Добавить";
            // 
            // textBoxAddMark
            // 
            textBoxAddMark.Location = new Point(122, 39);
            textBoxAddMark.Name = "textBoxAddMark";
            textBoxAddMark.Size = new Size(134, 23);
            textBoxAddMark.TabIndex = 37;
            // 
            // numericUpDownAddVolume
            // 
            numericUpDownAddVolume.Location = new Point(122, 71);
            numericUpDownAddVolume.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDownAddVolume.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownAddVolume.Name = "numericUpDownAddVolume";
            numericUpDownAddVolume.Size = new Size(134, 23);
            numericUpDownAddVolume.TabIndex = 36;
            numericUpDownAddVolume.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownAddSits
            // 
            numericUpDownAddSits.Location = new Point(122, 98);
            numericUpDownAddSits.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDownAddSits.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownAddSits.Name = "numericUpDownAddSits";
            numericUpDownAddSits.Size = new Size(134, 23);
            numericUpDownAddSits.TabIndex = 35;
            numericUpDownAddSits.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownAddCost
            // 
            numericUpDownAddCost.Location = new Point(122, 126);
            numericUpDownAddCost.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDownAddCost.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownAddCost.Name = "numericUpDownAddCost";
            numericUpDownAddCost.Size = new Size(134, 23);
            numericUpDownAddCost.TabIndex = 26;
            numericUpDownAddCost.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(9, 8);
            label14.Name = "label14";
            label14.Size = new Size(45, 15);
            label14.TabIndex = 17;
            label14.Text = "Номер";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(9, 42);
            label13.Name = "label13";
            label13.Size = new Size(43, 15);
            label13.TabIndex = 19;
            label13.Text = "Марка";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(10, 71);
            label12.Name = "label12";
            label12.Size = new Size(105, 15);
            label12.TabIndex = 21;
            label12.Text = "Объем бензобака";
            // 
            // dateTimePickerAddYear
            // 
            dateTimePickerAddYear.Format = DateTimePickerFormat.Custom;
            dateTimePickerAddYear.Location = new Point(122, 156);
            dateTimePickerAddYear.Name = "dateTimePickerAddYear";
            dateTimePickerAddYear.ShowUpDown = true;
            dateTimePickerAddYear.Size = new Size(134, 23);
            dateTimePickerAddYear.TabIndex = 34;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 100);
            label11.Name = "label11";
            label11.Size = new Size(101, 15);
            label11.TabIndex = 23;
            label11.Text = "Количество мест";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 128);
            label10.Name = "label10";
            label10.Size = new Size(67, 15);
            label10.TabIndex = 25;
            label10.Text = "Стоимость";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 162);
            label9.Name = "label9";
            label9.Size = new Size(79, 15);
            label9.TabIndex = 27;
            label9.Text = "Год создания";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(6, 185);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(251, 23);
            buttonAdd.TabIndex = 29;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxAddNumber
            // 
            textBoxAddNumber.Location = new Point(122, 5);
            textBoxAddNumber.Name = "textBoxAddNumber";
            textBoxAddNumber.Size = new Size(134, 23);
            textBoxAddNumber.TabIndex = 30;
            // 
            // tabPageEdit
            // 
            tabPageEdit.BackColor = Color.Silver;
            tabPageEdit.Controls.Add(textBoxEditMark);
            tabPageEdit.Controls.Add(numericUpDownEditVolume);
            tabPageEdit.Controls.Add(buttonEdit);
            tabPageEdit.Controls.Add(numericUpDownEditSit);
            tabPageEdit.Controls.Add(textBoxEditNumber);
            tabPageEdit.Controls.Add(numericUpDownEditCost);
            tabPageEdit.Controls.Add(label6);
            tabPageEdit.Controls.Add(label1);
            tabPageEdit.Controls.Add(label5);
            tabPageEdit.Controls.Add(label2);
            tabPageEdit.Controls.Add(label4);
            tabPageEdit.Controls.Add(label3);
            tabPageEdit.Controls.Add(dateTimePickerEditYear);
            tabPageEdit.Location = new Point(4, 24);
            tabPageEdit.Name = "tabPageEdit";
            tabPageEdit.Padding = new Padding(3);
            tabPageEdit.Size = new Size(258, 212);
            tabPageEdit.TabIndex = 1;
            tabPageEdit.Text = "Редактировать";
            // 
            // textBoxEditMark
            // 
            textBoxEditMark.Location = new Point(118, 43);
            textBoxEditMark.Name = "textBoxEditMark";
            textBoxEditMark.Size = new Size(134, 23);
            textBoxEditMark.TabIndex = 73;
            // 
            // numericUpDownEditVolume
            // 
            numericUpDownEditVolume.Location = new Point(118, 75);
            numericUpDownEditVolume.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownEditVolume.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownEditVolume.Name = "numericUpDownEditVolume";
            numericUpDownEditVolume.Size = new Size(134, 23);
            numericUpDownEditVolume.TabIndex = 72;
            numericUpDownEditVolume.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(5, 186);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(251, 23);
            buttonEdit.TabIndex = 67;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // numericUpDownEditSit
            // 
            numericUpDownEditSit.Location = new Point(118, 102);
            numericUpDownEditSit.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownEditSit.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownEditSit.Name = "numericUpDownEditSit";
            numericUpDownEditSit.Size = new Size(134, 23);
            numericUpDownEditSit.TabIndex = 71;
            numericUpDownEditSit.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // textBoxEditNumber
            // 
            textBoxEditNumber.Location = new Point(118, 9);
            textBoxEditNumber.Name = "textBoxEditNumber";
            textBoxEditNumber.Size = new Size(134, 23);
            textBoxEditNumber.TabIndex = 69;
            // 
            // numericUpDownEditCost
            // 
            numericUpDownEditCost.Location = new Point(118, 130);
            numericUpDownEditCost.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownEditCost.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownEditCost.Name = "numericUpDownEditCost";
            numericUpDownEditCost.Size = new Size(134, 23);
            numericUpDownEditCost.TabIndex = 67;
            numericUpDownEditCost.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 166);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 68;
            label6.Text = "Год создания";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 12);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 62;
            label1.Text = "Номер";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 132);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 66;
            label5.Text = "Стоимость";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 46);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 63;
            label2.Text = "Марка";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 104);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 65;
            label4.Text = "Количество мест";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 75);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 64;
            label3.Text = "Объем бензобака";
            // 
            // dateTimePickerEditYear
            // 
            dateTimePickerEditYear.Format = DateTimePickerFormat.Custom;
            dateTimePickerEditYear.Location = new Point(118, 160);
            dateTimePickerEditYear.Name = "dateTimePickerEditYear";
            dateTimePickerEditYear.ShowUpDown = true;
            dateTimePickerEditYear.Size = new Size(134, 23);
            dateTimePickerEditYear.TabIndex = 70;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(280, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(639, 407);
            dataGridView1.TabIndex = 57;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged_1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Номер";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Марка";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Объем безобака";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Количество мест";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Стоимость";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Год создания";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, клиентыToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(930, 24);
            menuStrip1.TabIndex = 61;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, открытьToolStripMenuItem1, сохранитьToolStripMenuItem, удалитьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(133, 22);
            открытьToolStripMenuItem.Text = "Создать";
            открытьToolStripMenuItem.Click += создатьToolStripMenuItem_Click;
            // 
            // открытьToolStripMenuItem1
            // 
            открытьToolStripMenuItem1.Name = "открытьToolStripMenuItem1";
            открытьToolStripMenuItem1.Size = new Size(133, 22);
            открытьToolStripMenuItem1.Text = "Открыть";
            открытьToolStripMenuItem1.Click += открытьToolStripMenuItem1_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(133, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(133, 22);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
            // 
            // клиентыToolStripMenuItem
            // 
            клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            клиентыToolStripMenuItem.Size = new Size(67, 20);
            клиентыToolStripMenuItem.Text = "Клиенты";
            клиентыToolStripMenuItem.Click += клиентыToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // CarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 439);
            Controls.Add(groupBoxFilter);
            Controls.Add(buttonDelete);
            Controls.Add(tabControl);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "CarForm";
            Text = "Машины";
            Load += Form1_Load;
            groupBoxFilter.ResumeLayout(false);
            groupBoxFilter.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPageAdd.ResumeLayout(false);
            tabPageAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAddVolume).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAddSits).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAddCost).EndInit();
            tabPageEdit.ResumeLayout(false);
            tabPageEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEditVolume).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEditSit).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEditCost).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxFilter;
        private Button buttonClearFilter;
        private ComboBox comboBoxFilterValue;
        private ComboBox comboBoxFilter;
        private Label label7;
        private Button buttonFilter;
        private Label label8;
        private Button buttonDelete;
        private TabControl tabControl;
        private TabPage tabPageAdd;
        private NumericUpDown numericUpDownAddCost;
        private Label label14;
        private Label label13;
        private Label label12;
        private DateTimePicker dateTimePickerAddYear;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button buttonAdd;
        private TextBox textBoxAddNumber;
        private TabPage tabPageEdit;
        private Button buttonEdit;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem1;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private NumericUpDown numericUpDownAddVolume;
        private NumericUpDown numericUpDownAddSits;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private TextBox textBoxAddMark;
        private TextBox textBoxEditMark;
        private NumericUpDown numericUpDownEditVolume;
        private NumericUpDown numericUpDownEditSit;
        private TextBox textBoxEditNumber;
        private NumericUpDown numericUpDownEditCost;
        private Label label6;
        private Label label1;
        private Label label5;
        private Label label2;
        private Label label4;
        private Label label3;
        private DateTimePicker dateTimePickerEditYear;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private ToolStripMenuItem клиентыToolStripMenuItem;
    }
}
