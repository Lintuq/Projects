
namespace ИС_библиотеки_учебного_заведения
{
    partial class Хранение
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Хранение));
            this.dataGridViewStoreData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonLoadStoreData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumberBook = new System.Windows.Forms.TextBox();
            this.textBoxNumberShelf = new System.Windows.Forms.TextBox();
            this.textBoxIdStore = new System.Windows.Forms.TextBox();
            this.buttonAddStore = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOldIdStore = new System.Windows.Forms.TextBox();
            this.textBoxNumberBookUpdate = new System.Windows.Forms.TextBox();
            this.textBoxNumberShelfUpdate = new System.Windows.Forms.TextBox();
            this.textBoxNewIdStore = new System.Windows.Forms.TextBox();
            this.buttonUpdateStore = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNumberDeleteStore = new System.Windows.Forms.TextBox();
            this.buttonDeleteStore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStoreData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewStoreData
            // 
            this.dataGridViewStoreData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStoreData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewStoreData.Location = new System.Drawing.Point(20, 20);
            this.dataGridViewStoreData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewStoreData.Name = "dataGridViewStoreData";
            this.dataGridViewStoreData.Size = new System.Drawing.Size(418, 464);
            this.dataGridViewStoreData.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Номер хранения";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Номер полки";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Номер книги";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // buttonLoadStoreData
            // 
            this.buttonLoadStoreData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(22)))), ((int)(((byte)(245)))));
            this.buttonLoadStoreData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLoadStoreData.Location = new System.Drawing.Point(112, 492);
            this.buttonLoadStoreData.Name = "buttonLoadStoreData";
            this.buttonLoadStoreData.Size = new System.Drawing.Size(191, 50);
            this.buttonLoadStoreData.TabIndex = 1;
            this.buttonLoadStoreData.Text = "Информация о хранении";
            this.buttonLoadStoreData.UseVisualStyleBackColor = false;
            this.buttonLoadStoreData.Click += new System.EventHandler(this.buttonLoadStoreData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(203)))), ((int)(((byte)(23)))));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxNumberBook);
            this.groupBox1.Controls.Add(this.textBoxNumberShelf);
            this.groupBox1.Controls.Add(this.textBoxIdStore);
            this.groupBox1.Controls.Add(this.buttonAddStore);
            this.groupBox1.Location = new System.Drawing.Point(467, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(865, 168);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление хранилища";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(566, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Номер книги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Номер полки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Номер хранения";
            // 
            // textBoxNumberBook
            // 
            this.textBoxNumberBook.Location = new System.Drawing.Point(570, 81);
            this.textBoxNumberBook.Name = "textBoxNumberBook";
            this.textBoxNumberBook.Size = new System.Drawing.Size(100, 26);
            this.textBoxNumberBook.TabIndex = 8;
            this.textBoxNumberBook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumberBook_KeyPress);
            // 
            // textBoxNumberShelf
            // 
            this.textBoxNumberShelf.Location = new System.Drawing.Point(380, 81);
            this.textBoxNumberShelf.Name = "textBoxNumberShelf";
            this.textBoxNumberShelf.Size = new System.Drawing.Size(100, 26);
            this.textBoxNumberShelf.TabIndex = 7;
            this.textBoxNumberShelf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumberShelf_KeyPress);
            // 
            // textBoxIdStore
            // 
            this.textBoxIdStore.Location = new System.Drawing.Point(188, 81);
            this.textBoxIdStore.Name = "textBoxIdStore";
            this.textBoxIdStore.Size = new System.Drawing.Size(100, 26);
            this.textBoxIdStore.TabIndex = 6;
            this.textBoxIdStore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdStore_KeyPress);
            // 
            // buttonAddStore
            // 
            this.buttonAddStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(22)))), ((int)(((byte)(245)))));
            this.buttonAddStore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddStore.Location = new System.Drawing.Point(338, 128);
            this.buttonAddStore.Name = "buttonAddStore";
            this.buttonAddStore.Size = new System.Drawing.Size(191, 34);
            this.buttonAddStore.TabIndex = 5;
            this.buttonAddStore.Text = "Добавить хранилище";
            this.buttonAddStore.UseVisualStyleBackColor = false;
            this.buttonAddStore.Click += new System.EventHandler(this.buttonAddStore_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(203)))), ((int)(((byte)(23)))));
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxOldIdStore);
            this.groupBox2.Controls.Add(this.textBoxNumberBookUpdate);
            this.groupBox2.Controls.Add(this.textBoxNumberShelfUpdate);
            this.groupBox2.Controls.Add(this.textBoxNewIdStore);
            this.groupBox2.Controls.Add(this.buttonUpdateStore);
            this.groupBox2.Location = new System.Drawing.Point(467, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(865, 168);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Изменение хранилища";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(566, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Номер книги";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Номер полки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Новый номер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Старый номер";
            // 
            // textBoxOldIdStore
            // 
            this.textBoxOldIdStore.Location = new System.Drawing.Point(27, 94);
            this.textBoxOldIdStore.Name = "textBoxOldIdStore";
            this.textBoxOldIdStore.Size = new System.Drawing.Size(100, 26);
            this.textBoxOldIdStore.TabIndex = 15;
            this.textBoxOldIdStore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOldIdStore_KeyPress);
            // 
            // textBoxNumberBookUpdate
            // 
            this.textBoxNumberBookUpdate.Location = new System.Drawing.Point(570, 94);
            this.textBoxNumberBookUpdate.Name = "textBoxNumberBookUpdate";
            this.textBoxNumberBookUpdate.Size = new System.Drawing.Size(100, 26);
            this.textBoxNumberBookUpdate.TabIndex = 14;
            this.textBoxNumberBookUpdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumberBookUpdate_KeyPress);
            // 
            // textBoxNumberShelfUpdate
            // 
            this.textBoxNumberShelfUpdate.Location = new System.Drawing.Point(380, 94);
            this.textBoxNumberShelfUpdate.Name = "textBoxNumberShelfUpdate";
            this.textBoxNumberShelfUpdate.Size = new System.Drawing.Size(100, 26);
            this.textBoxNumberShelfUpdate.TabIndex = 13;
            this.textBoxNumberShelfUpdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumberShelfUpdate_KeyPress);
            // 
            // textBoxNewIdStore
            // 
            this.textBoxNewIdStore.Location = new System.Drawing.Point(188, 94);
            this.textBoxNewIdStore.Name = "textBoxNewIdStore";
            this.textBoxNewIdStore.Size = new System.Drawing.Size(100, 26);
            this.textBoxNewIdStore.TabIndex = 12;
            this.textBoxNewIdStore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewIdStore_KeyPress);
            // 
            // buttonUpdateStore
            // 
            this.buttonUpdateStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(22)))), ((int)(((byte)(245)))));
            this.buttonUpdateStore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonUpdateStore.Location = new System.Drawing.Point(338, 128);
            this.buttonUpdateStore.Name = "buttonUpdateStore";
            this.buttonUpdateStore.Size = new System.Drawing.Size(191, 34);
            this.buttonUpdateStore.TabIndex = 6;
            this.buttonUpdateStore.Text = "Обновить хранилище";
            this.buttonUpdateStore.UseVisualStyleBackColor = false;
            this.buttonUpdateStore.Click += new System.EventHandler(this.buttonUpdateStore_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(203)))), ((int)(((byte)(23)))));
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBoxNumberDeleteStore);
            this.groupBox3.Controls.Add(this.buttonDeleteStore);
            this.groupBox3.Location = new System.Drawing.Point(467, 380);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(865, 168);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Удаление хранилища";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(355, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Номер хранилища";
            // 
            // textBoxNumberDeleteStore
            // 
            this.textBoxNumberDeleteStore.Location = new System.Drawing.Point(380, 96);
            this.textBoxNumberDeleteStore.Name = "textBoxNumberDeleteStore";
            this.textBoxNumberDeleteStore.Size = new System.Drawing.Size(100, 26);
            this.textBoxNumberDeleteStore.TabIndex = 19;
            this.textBoxNumberDeleteStore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumberDeleteStore_KeyPress);
            // 
            // buttonDeleteStore
            // 
            this.buttonDeleteStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(22)))), ((int)(((byte)(245)))));
            this.buttonDeleteStore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDeleteStore.Location = new System.Drawing.Point(338, 129);
            this.buttonDeleteStore.Name = "buttonDeleteStore";
            this.buttonDeleteStore.Size = new System.Drawing.Size(191, 34);
            this.buttonDeleteStore.TabIndex = 7;
            this.buttonDeleteStore.Text = "Удалить хранилище";
            this.buttonDeleteStore.UseVisualStyleBackColor = false;
            this.buttonDeleteStore.Click += new System.EventHandler(this.buttonDeleteStore_Click);
            // 
            // Хранение
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(160)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1364, 555);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonLoadStoreData);
            this.Controls.Add(this.dataGridViewStoreData);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Хранение";
            this.Text = "Хранение";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStoreData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStoreData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button buttonLoadStoreData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNumberBook;
        private System.Windows.Forms.TextBox textBoxNumberShelf;
        private System.Windows.Forms.TextBox textBoxIdStore;
        private System.Windows.Forms.Button buttonAddStore;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonUpdateStore;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonDeleteStore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxOldIdStore;
        private System.Windows.Forms.TextBox textBoxNumberBookUpdate;
        private System.Windows.Forms.TextBox textBoxNumberShelfUpdate;
        private System.Windows.Forms.TextBox textBoxNewIdStore;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNumberDeleteStore;
    }
}