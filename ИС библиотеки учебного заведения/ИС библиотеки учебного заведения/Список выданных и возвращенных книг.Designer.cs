
namespace ИС_библиотеки_учебного_заведения
{
    partial class Список_выданных_и_возвращенных_книг
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Список_выданных_и_возвращенных_книг));
            this.buttonBookOnArm = new System.Windows.Forms.Button();
            this.buttonBookBack = new System.Windows.Forms.Button();
            this.dataGridViewBookOnArm = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewBookBack = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookOnArm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookBack)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBookOnArm
            // 
            this.buttonBookOnArm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(22)))), ((int)(((byte)(245)))));
            this.buttonBookOnArm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBookOnArm.Location = new System.Drawing.Point(225, 286);
            this.buttonBookOnArm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBookOnArm.Name = "buttonBookOnArm";
            this.buttonBookOnArm.Size = new System.Drawing.Size(260, 91);
            this.buttonBookOnArm.TabIndex = 0;
            this.buttonBookOnArm.Text = "Книги на руках";
            this.buttonBookOnArm.UseVisualStyleBackColor = false;
            this.buttonBookOnArm.Click += new System.EventHandler(this.buttonBookOnArm_Click);
            // 
            // buttonBookBack
            // 
            this.buttonBookBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(22)))), ((int)(((byte)(245)))));
            this.buttonBookBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBookBack.Location = new System.Drawing.Point(988, 286);
            this.buttonBookBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBookBack.Name = "buttonBookBack";
            this.buttonBookBack.Size = new System.Drawing.Size(260, 91);
            this.buttonBookBack.TabIndex = 1;
            this.buttonBookBack.Text = "Книги возвращены";
            this.buttonBookBack.UseVisualStyleBackColor = false;
            this.buttonBookBack.Click += new System.EventHandler(this.buttonBookBack_Click);
            // 
            // dataGridViewBookOnArm
            // 
            this.dataGridViewBookOnArm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookOnArm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewBookOnArm.Location = new System.Drawing.Point(18, 18);
            this.dataGridViewBookOnArm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewBookOnArm.Name = "dataGridViewBookOnArm";
            this.dataGridViewBookOnArm.Size = new System.Drawing.Size(696, 231);
            this.dataGridViewBookOnArm.TabIndex = 2;
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
            // dataGridViewBookBack
            // 
            this.dataGridViewBookBack.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridViewBookBack.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewBookBack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookBack.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridViewBookBack.Location = new System.Drawing.Point(771, 18);
            this.dataGridViewBookBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewBookBack.Name = "dataGridViewBookBack";
            this.dataGridViewBookBack.Size = new System.Drawing.Size(694, 231);
            this.dataGridViewBookBack.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Название книги";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Автор";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Имя студента";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Фамилия студента";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Отчество студента";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Список_выданных_и_возвращенных_книг
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(160)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1364, 415);
            this.Controls.Add(this.dataGridViewBookBack);
            this.Controls.Add(this.dataGridViewBookOnArm);
            this.Controls.Add(this.buttonBookBack);
            this.Controls.Add(this.buttonBookOnArm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Список_выданных_и_возвращенных_книг";
            this.Text = "Список_выданных_и_возвращенных_книг";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookOnArm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBookOnArm;
        private System.Windows.Forms.Button buttonBookBack;
        private System.Windows.Forms.DataGridView dataGridViewBookOnArm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridView dataGridViewBookBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}