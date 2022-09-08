
namespace ИС_библиотеки_учебного_заведения
{
    partial class Оформление_выдачи_и_возврата_книг
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Оформление_выдачи_и_возврата_книг));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSelectStudent = new System.Windows.Forms.Button();
            this.buttonLoadGetBook = new System.Windows.Forms.Button();
            this.dataGridViewFormData = new System.Windows.Forms.DataGridView();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonDebtor = new System.Windows.Forms.Button();
            this.buttonBookOnArm = new System.Windows.Forms.Button();
            this.buttonAllBookAllThisTime = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonBackBook = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxStatusBack = new System.Windows.Forms.ComboBox();
            this.textBoxIdRecordNack = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerRecord = new System.Windows.Forms.DateTimePicker();
            this.buttonGiveBook = new System.Windows.Forms.Button();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.textBoxIdRecord = new System.Windows.Forms.TextBox();
            this.textBoxIdBook = new System.Windows.Forms.TextBox();
            this.textBoxIdForm = new System.Windows.Forms.TextBox();
            this.textBoxIdStudent = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormData)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewStudent);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSelectStudent);
            this.splitContainer1.Panel1.Controls.Add(this.buttonLoadGetBook);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewFormData);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1364, 742);
            this.splitContainer1.SplitterDistance = 632;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewStudent.Location = new System.Drawing.Point(12, 395);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.Size = new System.Drawing.Size(615, 251);
            this.dataGridViewStudent.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Индификатор студента";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Имя";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Фамилия";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Отчество";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Индификатор группы";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // buttonSelectStudent
            // 
            this.buttonSelectStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(22)))), ((int)(((byte)(245)))));
            this.buttonSelectStudent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSelectStudent.Location = new System.Drawing.Point(135, 652);
            this.buttonSelectStudent.Name = "buttonSelectStudent";
            this.buttonSelectStudent.Size = new System.Drawing.Size(357, 43);
            this.buttonSelectStudent.TabIndex = 10;
            this.buttonSelectStudent.Text = "Список студентов";
            this.buttonSelectStudent.UseVisualStyleBackColor = false;
            this.buttonSelectStudent.Click += new System.EventHandler(this.buttonSelectStudent_Click);
            // 
            // buttonLoadGetBook
            // 
            this.buttonLoadGetBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(22)))), ((int)(((byte)(245)))));
            this.buttonLoadGetBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLoadGetBook.Location = new System.Drawing.Point(135, 343);
            this.buttonLoadGetBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLoadGetBook.Name = "buttonLoadGetBook";
            this.buttonLoadGetBook.Size = new System.Drawing.Size(357, 44);
            this.buttonLoadGetBook.TabIndex = 8;
            this.buttonLoadGetBook.Text = "Взятые книги";
            this.buttonLoadGetBook.UseVisualStyleBackColor = false;
            this.buttonLoadGetBook.Click += new System.EventHandler(this.buttonLoadGetBook_Click);
            // 
            // dataGridViewFormData
            // 
            this.dataGridViewFormData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFormData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20,
            this.Column21,
            this.Column22});
            this.dataGridViewFormData.Location = new System.Drawing.Point(4, 18);
            this.dataGridViewFormData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewFormData.Name = "dataGridViewFormData";
            this.dataGridViewFormData.Size = new System.Drawing.Size(624, 315);
            this.dataGridViewFormData.TabIndex = 4;
            this.dataGridViewFormData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFormData_CellClick);
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Идентификатор студента";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Идентификатор формуляра";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "Идентификатор книги";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            // 
            // Column20
            // 
            this.Column20.HeaderText = "Идентификатор выдачи";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            // 
            // Column21
            // 
            this.Column21.HeaderText = "Дата выдачи";
            this.Column21.Name = "Column21";
            this.Column21.ReadOnly = true;
            // 
            // Column22
            // 
            this.Column22.HeaderText = "Статус книги";
            this.Column22.Name = "Column22";
            this.Column22.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(203)))), ((int)(((byte)(23)))));
            this.groupBox3.Controls.Add(this.buttonDebtor);
            this.groupBox3.Controls.Add(this.buttonBookOnArm);
            this.groupBox3.Controls.Add(this.buttonAllBookAllThisTime);
            this.groupBox3.Location = new System.Drawing.Point(393, 343);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 372);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Подведение статистики";
            // 
            // buttonDebtor
            // 
            this.buttonDebtor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(22)))), ((int)(((byte)(245)))));
            this.buttonDebtor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDebtor.Location = new System.Drawing.Point(70, 209);
            this.buttonDebtor.Name = "buttonDebtor";
            this.buttonDebtor.Size = new System.Drawing.Size(185, 65);
            this.buttonDebtor.TabIndex = 2;
            this.buttonDebtor.Text = "Студенты должники";
            this.buttonDebtor.UseVisualStyleBackColor = false;
            this.buttonDebtor.Click += new System.EventHandler(this.buttonDebtor_Click);
            // 
            // buttonBookOnArm
            // 
            this.buttonBookOnArm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(22)))), ((int)(((byte)(245)))));
            this.buttonBookOnArm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBookOnArm.Location = new System.Drawing.Point(70, 122);
            this.buttonBookOnArm.Name = "buttonBookOnArm";
            this.buttonBookOnArm.Size = new System.Drawing.Size(185, 65);
            this.buttonBookOnArm.TabIndex = 1;
            this.buttonBookOnArm.Text = "Статистика по книгам на руках";
            this.buttonBookOnArm.UseVisualStyleBackColor = false;
            this.buttonBookOnArm.Click += new System.EventHandler(this.buttonBookOnArm_Click);
            // 
            // buttonAllBookAllThisTime
            // 
            this.buttonAllBookAllThisTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(22)))), ((int)(((byte)(245)))));
            this.buttonAllBookAllThisTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAllBookAllThisTime.Location = new System.Drawing.Point(70, 38);
            this.buttonAllBookAllThisTime.Name = "buttonAllBookAllThisTime";
            this.buttonAllBookAllThisTime.Size = new System.Drawing.Size(185, 65);
            this.buttonAllBookAllThisTime.TabIndex = 0;
            this.buttonAllBookAllThisTime.Text = "Список за все время взятых книг";
            this.buttonAllBookAllThisTime.UseVisualStyleBackColor = false;
            this.buttonAllBookAllThisTime.Click += new System.EventHandler(this.buttonAllBookAllThisTime_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(203)))), ((int)(((byte)(23)))));
            this.groupBox2.Controls.Add(this.buttonBackBook);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboBoxStatusBack);
            this.groupBox2.Controls.Add(this.textBoxIdRecordNack);
            this.groupBox2.Location = new System.Drawing.Point(16, 343);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 372);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Возврат книги";
            // 
            // buttonBackBook
            // 
            this.buttonBackBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(22)))), ((int)(((byte)(245)))));
            this.buttonBackBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBackBook.Location = new System.Drawing.Point(84, 209);
            this.buttonBackBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBackBook.Name = "buttonBackBook";
            this.buttonBackBook.Size = new System.Drawing.Size(141, 69);
            this.buttonBackBook.TabIndex = 19;
            this.buttonBackBook.Text = "Вернуть книгу";
            this.buttonBackBook.UseVisualStyleBackColor = false;
            this.buttonBackBook.Click += new System.EventHandler(this.buttonBackBook_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Статус книги";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Индефикатор записи";
            // 
            // comboBoxStatusBack
            // 
            this.comboBoxStatusBack.FormattingEnabled = true;
            this.comboBoxStatusBack.Items.AddRange(new object[] {
            "Возвращена"});
            this.comboBoxStatusBack.Location = new System.Drawing.Point(46, 145);
            this.comboBoxStatusBack.Name = "comboBoxStatusBack";
            this.comboBoxStatusBack.Size = new System.Drawing.Size(200, 28);
            this.comboBoxStatusBack.TabIndex = 19;
            // 
            // textBoxIdRecordNack
            // 
            this.textBoxIdRecordNack.Location = new System.Drawing.Point(97, 77);
            this.textBoxIdRecordNack.Name = "textBoxIdRecordNack";
            this.textBoxIdRecordNack.Size = new System.Drawing.Size(100, 26);
            this.textBoxIdRecordNack.TabIndex = 1;
            this.textBoxIdRecordNack.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdRecordNack_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(203)))), ((int)(((byte)(23)))));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePickerRecord);
            this.groupBox1.Controls.Add(this.buttonGiveBook);
            this.groupBox1.Controls.Add(this.comboBoxStatus);
            this.groupBox1.Controls.Add(this.textBoxIdRecord);
            this.groupBox1.Controls.Add(this.textBoxIdBook);
            this.groupBox1.Controls.Add(this.textBoxIdForm);
            this.groupBox1.Controls.Add(this.textBoxIdStudent);
            this.groupBox1.Location = new System.Drawing.Point(16, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 315);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оформление выдачи книги";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Статус книги";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Дата выдачи книги";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Идентификатор записи";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Идентификатор книги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Идентификатор форммуляра";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Идентификатор студента";
            // 
            // dateTimePickerRecord
            // 
            this.dateTimePickerRecord.Location = new System.Drawing.Point(25, 206);
            this.dateTimePickerRecord.Name = "dateTimePickerRecord";
            this.dateTimePickerRecord.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerRecord.TabIndex = 12;
            // 
            // buttonGiveBook
            // 
            this.buttonGiveBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(22)))), ((int)(((byte)(245)))));
            this.buttonGiveBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonGiveBook.Location = new System.Drawing.Point(478, 121);
            this.buttonGiveBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGiveBook.Name = "buttonGiveBook";
            this.buttonGiveBook.Size = new System.Drawing.Size(141, 69);
            this.buttonGiveBook.TabIndex = 11;
            this.buttonGiveBook.Text = "Выдать книгу";
            this.buttonGiveBook.UseVisualStyleBackColor = false;
            this.buttonGiveBook.Click += new System.EventHandler(this.buttonGiveBook_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "На руках"});
            this.comboBoxStatus.Location = new System.Drawing.Point(25, 247);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(200, 28);
            this.comboBoxStatus.TabIndex = 5;
            // 
            // textBoxIdRecord
            // 
            this.textBoxIdRecord.Location = new System.Drawing.Point(25, 164);
            this.textBoxIdRecord.Name = "textBoxIdRecord";
            this.textBoxIdRecord.Size = new System.Drawing.Size(200, 26);
            this.textBoxIdRecord.TabIndex = 3;
            this.textBoxIdRecord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdRecord_KeyPress);
            // 
            // textBoxIdBook
            // 
            this.textBoxIdBook.Location = new System.Drawing.Point(25, 121);
            this.textBoxIdBook.Name = "textBoxIdBook";
            this.textBoxIdBook.Size = new System.Drawing.Size(200, 26);
            this.textBoxIdBook.TabIndex = 2;
            this.textBoxIdBook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdBook_KeyPress);
            // 
            // textBoxIdForm
            // 
            this.textBoxIdForm.Location = new System.Drawing.Point(25, 80);
            this.textBoxIdForm.Name = "textBoxIdForm";
            this.textBoxIdForm.Size = new System.Drawing.Size(200, 26);
            this.textBoxIdForm.TabIndex = 1;
            this.textBoxIdForm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdForm_KeyPress);
            // 
            // textBoxIdStudent
            // 
            this.textBoxIdStudent.Location = new System.Drawing.Point(25, 37);
            this.textBoxIdStudent.Name = "textBoxIdStudent";
            this.textBoxIdStudent.Size = new System.Drawing.Size(200, 26);
            this.textBoxIdStudent.TabIndex = 0;
            this.textBoxIdStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdStudent_KeyPress);
            // 
            // Оформление_выдачи_и_возврата_книг
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(160)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1364, 742);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Оформление_выдачи_и_возврата_книг";
            this.Text = "Оформление_выдачи_и_возврата_книг";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormData)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewFormData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.Button buttonLoadGetBook;
        private System.Windows.Forms.Button buttonSelectStudent;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerRecord;
        private System.Windows.Forms.Button buttonGiveBook;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.TextBox textBoxIdRecord;
        private System.Windows.Forms.TextBox textBoxIdBook;
        private System.Windows.Forms.TextBox textBoxIdForm;
        private System.Windows.Forms.TextBox textBoxIdStudent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonBackBook;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxStatusBack;
        private System.Windows.Forms.TextBox textBoxIdRecordNack;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonAllBookAllThisTime;
        private System.Windows.Forms.Button buttonBookOnArm;
        private System.Windows.Forms.Button buttonDebtor;
    }
}