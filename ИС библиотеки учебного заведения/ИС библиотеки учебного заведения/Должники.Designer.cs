
namespace ИС_библиотеки_учебного_заведения
{
    partial class Должники
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Должники));
            this.buttonDebtor = new System.Windows.Forms.Button();
            this.buttonExportExcel = new System.Windows.Forms.Button();
            this.dataGridViewDebtor = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxIdStudent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDebtor)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDebtor
            // 
            this.buttonDebtor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(22)))), ((int)(((byte)(245)))));
            this.buttonDebtor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDebtor.Location = new System.Drawing.Point(99, 268);
            this.buttonDebtor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDebtor.Name = "buttonDebtor";
            this.buttonDebtor.Size = new System.Drawing.Size(173, 55);
            this.buttonDebtor.TabIndex = 0;
            this.buttonDebtor.Text = "Информация о должнике";
            this.buttonDebtor.UseVisualStyleBackColor = false;
            this.buttonDebtor.Click += new System.EventHandler(this.buttonDebtor_Click);
            // 
            // buttonExportExcel
            // 
            this.buttonExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(22)))), ((int)(((byte)(245)))));
            this.buttonExportExcel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonExportExcel.Location = new System.Drawing.Point(759, 268);
            this.buttonExportExcel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonExportExcel.Name = "buttonExportExcel";
            this.buttonExportExcel.Size = new System.Drawing.Size(173, 55);
            this.buttonExportExcel.TabIndex = 1;
            this.buttonExportExcel.Text = "Выгрузить отчет";
            this.buttonExportExcel.UseVisualStyleBackColor = false;
            this.buttonExportExcel.Click += new System.EventHandler(this.buttonExportExcel_Click);
            // 
            // dataGridViewDebtor
            // 
            this.dataGridViewDebtor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDebtor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGridViewDebtor.Location = new System.Drawing.Point(18, 18);
            this.dataGridViewDebtor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewDebtor.Name = "dataGridViewDebtor";
            this.dataGridViewDebtor.Size = new System.Drawing.Size(1164, 231);
            this.dataGridViewDebtor.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название книги";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Автор";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Имя студента";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Фамилия студента";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Отчество студента";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Номер группы";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Имя куратора";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Фамилия куратора";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Отчество куратора";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Имейл";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // textBoxIdStudent
            // 
            this.textBoxIdStudent.Location = new System.Drawing.Point(323, 297);
            this.textBoxIdStudent.Name = "textBoxIdStudent";
            this.textBoxIdStudent.Size = new System.Drawing.Size(100, 26);
            this.textBoxIdStudent.TabIndex = 3;
            this.textBoxIdStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdStudent_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id студента";
            // 
            // Должники
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(160)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1200, 333);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIdStudent);
            this.Controls.Add(this.dataGridViewDebtor);
            this.Controls.Add(this.buttonExportExcel);
            this.Controls.Add(this.buttonDebtor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Должники";
            this.Text = "Должники";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDebtor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDebtor;
        private System.Windows.Forms.Button buttonExportExcel;
        private System.Windows.Forms.DataGridView dataGridViewDebtor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.TextBox textBoxIdStudent;
        private System.Windows.Forms.Label label1;
    }
}