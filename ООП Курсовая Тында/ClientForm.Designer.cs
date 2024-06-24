namespace ООП_Курсовая_Тында
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
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
            comboBoxAddNumber = new ComboBox();
            textBoxAddPost = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            buttonAdd = new Button();
            textBoxAddName = new TextBox();
            tabPageEdit = new TabPage();
            comboBoxEditNumberCar = new ComboBox();
            textBoxEditPost = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxEditName = new TextBox();
            buttonEdit = new Button();
            dataGridView1 = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            вернутьсяToolStripMenuItem = new ToolStripMenuItem();
            groupBoxFilter.SuspendLayout();
            tabControl.SuspendLayout();
            tabPageAdd.SuspendLayout();
            tabPageEdit.SuspendLayout();
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
            groupBoxFilter.Location = new Point(12, 35);
            groupBoxFilter.Name = "groupBoxFilter";
            groupBoxFilter.Size = new Size(266, 132);
            groupBoxFilter.TabIndex = 64;
            groupBoxFilter.TabStop = false;
            groupBoxFilter.Text = "Фильтровать";
            // 
            // buttonClearFilter
            // 
            buttonClearFilter.Enabled = false;
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
            comboBoxFilterValue.Enabled = false;
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
            comboBoxFilter.Items.AddRange(new object[] { "ФИО", "Номер машины", "Должность" });
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
            buttonFilter.Enabled = false;
            buttonFilter.Location = new Point(9, 82);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(251, 21);
            buttonFilter.TabIndex = 52;
            buttonFilter.Text = "Фильтровать";
            buttonFilter.UseVisualStyleBackColor = true;
            buttonFilter.Click += buttonFilter_Click;
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
            buttonDelete.Location = new Point(12, 327);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(260, 23);
            buttonDelete.TabIndex = 63;
            buttonDelete.Text = "Удалить выбранную машину";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageAdd);
            tabControl.Controls.Add(tabPageEdit);
            tabControl.Location = new Point(12, 173);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(266, 148);
            tabControl.TabIndex = 62;
            // 
            // tabPageAdd
            // 
            tabPageAdd.BackColor = Color.Silver;
            tabPageAdd.Controls.Add(comboBoxAddNumber);
            tabPageAdd.Controls.Add(textBoxAddPost);
            tabPageAdd.Controls.Add(label14);
            tabPageAdd.Controls.Add(label13);
            tabPageAdd.Controls.Add(label12);
            tabPageAdd.Controls.Add(buttonAdd);
            tabPageAdd.Controls.Add(textBoxAddName);
            tabPageAdd.Location = new Point(4, 24);
            tabPageAdd.Name = "tabPageAdd";
            tabPageAdd.Padding = new Padding(3);
            tabPageAdd.Size = new Size(258, 120);
            tabPageAdd.TabIndex = 0;
            tabPageAdd.Text = "Добавить";
            // 
            // comboBoxAddNumber
            // 
            comboBoxAddNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAddNumber.FormattingEnabled = true;
            comboBoxAddNumber.Location = new Point(118, 35);
            comboBoxAddNumber.Name = "comboBoxAddNumber";
            comboBoxAddNumber.Size = new Size(133, 23);
            comboBoxAddNumber.TabIndex = 38;
            // 
            // textBoxAddPost
            // 
            textBoxAddPost.Location = new Point(118, 64);
            textBoxAddPost.Name = "textBoxAddPost";
            textBoxAddPost.Size = new Size(134, 23);
            textBoxAddPost.TabIndex = 37;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(8, 12);
            label14.Name = "label14";
            label14.Size = new Size(34, 15);
            label14.TabIndex = 17;
            label14.Text = "ФИО";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(8, 38);
            label13.Name = "label13";
            label13.Size = new Size(97, 15);
            label13.TabIndex = 19;
            label13.Text = "Номер машины";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(8, 67);
            label12.Name = "label12";
            label12.Size = new Size(69, 15);
            label12.TabIndex = 21;
            label12.Text = "Должность";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(4, 93);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(251, 23);
            buttonAdd.TabIndex = 29;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxAddName
            // 
            textBoxAddName.Location = new Point(118, 6);
            textBoxAddName.Name = "textBoxAddName";
            textBoxAddName.Size = new Size(134, 23);
            textBoxAddName.TabIndex = 30;
            // 
            // tabPageEdit
            // 
            tabPageEdit.BackColor = Color.Silver;
            tabPageEdit.Controls.Add(comboBoxEditNumberCar);
            tabPageEdit.Controls.Add(textBoxEditPost);
            tabPageEdit.Controls.Add(label1);
            tabPageEdit.Controls.Add(label2);
            tabPageEdit.Controls.Add(label3);
            tabPageEdit.Controls.Add(textBoxEditName);
            tabPageEdit.Controls.Add(buttonEdit);
            tabPageEdit.Location = new Point(4, 24);
            tabPageEdit.Name = "tabPageEdit";
            tabPageEdit.Padding = new Padding(3);
            tabPageEdit.Size = new Size(258, 120);
            tabPageEdit.TabIndex = 1;
            tabPageEdit.Text = "Редактировать";
            // 
            // comboBoxEditNumberCar
            // 
            comboBoxEditNumberCar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEditNumberCar.FormattingEnabled = true;
            comboBoxEditNumberCar.Location = new Point(118, 35);
            comboBoxEditNumberCar.Name = "comboBoxEditNumberCar";
            comboBoxEditNumberCar.Size = new Size(133, 23);
            comboBoxEditNumberCar.TabIndex = 73;
            // 
            // textBoxEditPost
            // 
            textBoxEditPost.Location = new Point(118, 64);
            textBoxEditPost.Name = "textBoxEditPost";
            textBoxEditPost.Size = new Size(134, 23);
            textBoxEditPost.TabIndex = 72;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 12);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 68;
            label1.Text = "ФИО";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 38);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 69;
            label2.Text = "Номер машины";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 67);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 70;
            label3.Text = "Должность";
            // 
            // textBoxEditName
            // 
            textBoxEditName.Location = new Point(118, 6);
            textBoxEditName.Name = "textBoxEditName";
            textBoxEditName.Size = new Size(134, 23);
            textBoxEditName.TabIndex = 71;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(4, 93);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(251, 23);
            buttonEdit.TabIndex = 67;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1, Column3 });
            dataGridView1.Location = new Point(284, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(441, 315);
            dataGridView1.TabIndex = 61;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // Column2
            // 
            Column2.HeaderText = "ФИО";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Номер машины";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Должность";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { вернутьсяToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(731, 24);
            menuStrip1.TabIndex = 65;
            menuStrip1.Text = "menuStrip1";
            // 
            // вернутьсяToolStripMenuItem
            // 
            вернутьсяToolStripMenuItem.Name = "вернутьсяToolStripMenuItem";
            вернутьсяToolStripMenuItem.Size = new Size(75, 20);
            вернутьсяToolStripMenuItem.Text = "Вернуться";
            вернутьсяToolStripMenuItem.Click += вернутьсяToolStripMenuItem_Click;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 360);
            Controls.Add(groupBoxFilter);
            Controls.Add(buttonDelete);
            Controls.Add(tabControl);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ClientForm";
            Text = "Клиенты";
            Load += ClientForm_Load;
            groupBoxFilter.ResumeLayout(false);
            groupBoxFilter.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPageAdd.ResumeLayout(false);
            tabPageAdd.PerformLayout();
            tabPageEdit.ResumeLayout(false);
            tabPageEdit.PerformLayout();
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
        private ComboBox comboBoxAddNumber;
        private TextBox textBoxAddPost;
        private Label label14;
        private Label label13;
        private Label label12;
        private Button buttonAdd;
        private TextBox textBoxAddName;
        private TabPage tabPageEdit;
        private Button buttonEdit;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem вернутьсяToolStripMenuItem;
        private ComboBox comboBoxEditNumberCar;
        private TextBox textBoxEditPost;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxEditName;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
    }
}