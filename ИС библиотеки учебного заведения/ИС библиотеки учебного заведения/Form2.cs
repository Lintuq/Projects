using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ИС_библиотеки_учебного_заведения
{  
    public partial class Form2 : Form
    {
        DBConnection dbconn;
     
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            Point point = Screen.PrimaryScreen.WorkingArea.Location;
            //Перенос в местоположение верхнего левого угла формы, чтобы её правый нижний угол попал в правый нижний угол экрана
            point.Offset(this.Top, this.Left);
            //Новое положение формы
            this.Location = point;         
        }

        private void Form2_Load(object sender, EventArgs e) // Установка разрешения формы и названия вкладок
        {
            Size resolution = Screen.PrimaryScreen.Bounds.Size;
            this.Size = new Size(resolution.Width, resolution.Height);
            tabControl1.Size = new Size(resolution.Width, resolution.Height);
            tabPage1.Text = @"Книжный раздел";
            tabPage2.Text = @"Выдача книг";
            tabPage1.Size = new Size(resolution.Width, resolution.Height);
        }

        private void buttonLoadBookData_Click(object sender, EventArgs e) // Загрузка данных о книгах
        {
            LoadBookData();
        }

        private void LoadBookData()
        {
            for (int i = 0; i < dataGridViewBookData.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewBookData.ColumnCount; j++)
                {
                    dataGridViewBookData.Rows[i].Cells[j].Value = null;
                }
            }

            string SqlExpression = "BookData"; // Вывод с помощью процедуры данных  о книге
            dataGridViewBookData.RowCount = 1;
            dbconn = new DBConnection(DataBank.login,DataBank.pass);
            SqlConnection conn = dbconn.GetSqlConnection();
            SqlCommand command = new SqlCommand(SqlExpression, conn);
            command.CommandType = CommandType.StoredProcedure;
            var reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    data.Add(new string[8]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                    data[data.Count - 1][7] = reader[7].ToString();
                }
            }

            reader.Close();
            conn.Close();

            foreach (string[] s in data)
            {
                dataGridViewBookData.Rows.Add(s);
            }

            int rows = dataGridViewBookData.RowCount; // Нумерация строк
            for (int i = 0; i < rows; i++)
            {
                dataGridViewBookData.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            dataGridViewBookData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void Store_Book_Click(object sender, EventArgs e)
        {
            LoadStoreDataBook();

            comboBox1.Items.Clear();
           
            List<string[]> number = new List<string[]>(); //Загрузка данных о хранилище
            string numberitem;

            for (int i = 0; i < dataGridViewStoreData.RowCount - 1; i++)
            {
                numberitem = dataGridViewStoreData.Rows[i].Cells[0].Value.ToString();
                number.Add(new string[1]);
                number[number.Count - 1][0] = numberitem.ToString();
            }
            foreach (string[] s in number)
            {               
                comboBox1.Items.Add(s[0]);
            }
            DataBank.numberstore = number;
        }

        private void LoadStoreDataBook()
        {
            for (int i = 0; i < dataGridViewStoreData.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewStoreData.ColumnCount; j++)
                {
                    dataGridViewStoreData.Rows[i].Cells[j].Value = null;
                }
            }

            string SqlExpression = "StoreData";// Загрузка данных о хранилище
            dataGridViewStoreData.RowCount = 1;
            dbconn = new DBConnection(DataBank.login, DataBank.pass);
            SqlConnection conn = dbconn.GetSqlConnection();
            SqlCommand command = new SqlCommand(SqlExpression, conn);
            command.CommandType = CommandType.StoredProcedure;
            var reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    data.Add(new string[3]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                }
            }

            reader.Close();
            conn.Close();

            foreach (string[] s in data)
            {
                dataGridViewStoreData.Rows.Add(s);
            }

            int rows = dataGridViewStoreData.RowCount;// Нумерация строк
            for (int i = 0; i < rows; i++)
            {
                dataGridViewStoreData.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            dataGridViewStoreData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != " ") // Заполнение таблиц по одному из критериев
            {
                for (int i = 0; i < dataGridViewBookDataOnShelf.RowCount; i++)
                {
                    for (int j = 0; j < dataGridViewBookDataOnShelf.ColumnCount; j++)
                    {
                        dataGridViewBookDataOnShelf.Rows[i].Cells[j].Value = null;
                    }
                }

                string sqlexpression = "DataBookOnShelf";
                string number = comboBox1.Text;

                dataGridViewBookDataOnShelf.RowCount = 1;
                dbconn = new DBConnection(DataBank.login, DataBank.pass);
                SqlConnection conn = dbconn.GetSqlConnection();
                SqlCommand command = new SqlCommand(sqlexpression, conn);
                command.Parameters.AddWithValue("@number_place",number);
                command.CommandType = CommandType.StoredProcedure;
                var reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        data.Add(new string[7]);
                        data[data.Count - 1][0] = reader[0].ToString();
                        data[data.Count - 1][1] = reader[1].ToString();
                        data[data.Count - 1][2] = reader[2].ToString();
                        data[data.Count - 1][3] = reader[3].ToString();
                        data[data.Count - 1][4] = reader[4].ToString();
                        data[data.Count - 1][5] = reader[5].ToString();
                        data[data.Count - 1][6] = reader[6].ToString();
                    }
                }

                reader.Close();
                conn.Close();

                foreach (string[] s in data)//Заполнение таблицы
                {
                    dataGridViewBookDataOnShelf.Rows.Add(s);
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Название книги")//Выбор определенного критерия
            {
                buttonCriterianSearchBook.Text = "Поиск по названию".ToString();
            }
            else if (comboBox2.Text == "Автор")
            {
                buttonCriterianSearchBook.Text = "Поиск по автору".ToString();
            }
            else if (comboBox2.Text == "Издательство")
            {
                buttonCriterianSearchBook.Text = "Поиск по издательству".ToString();
            }
        }

        private void buttonCriterianSearchBook_Click(object sender, EventArgs e)
        {
            if (textBoxCriterianSearchBook.Text == "")//Проверка по критерию
            {
                MessageBox.Show("Вы ничего не внесли");
                return;
            }
            string nameSearchProcedure = "";
            string nameParameterProcedure = "";
            string databysearch = textBoxCriterianSearchBook.Text;

            if (comboBox2.Text == "Название книги")// Выбор критерия и процедуры
            {
                nameSearchProcedure = "SearchByNameBook";
                nameParameterProcedure = "@namebook";
            }
            else if (comboBox2.Text == "Автор")
            {
                nameSearchProcedure = "SearchByAuthor";
                nameParameterProcedure = "@author";
            }
            else if (comboBox2.Text == "Издательство")
            {
                nameSearchProcedure = "SearchNyPublisher";
                nameParameterProcedure = "@publisher";
            }

            for (int i = 0; i < dataGridViewSearchDataCriterian.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewSearchDataCriterian.ColumnCount; j++)
                {
                    dataGridViewSearchDataCriterian.Rows[i].Cells[j].Value = null;
                }
            }

            dataGridViewSearchDataCriterian.RowCount = 1; //Заполнение таблицы определенной процедуры
            dbconn = new DBConnection(DataBank.login, DataBank.pass);
            SqlConnection conn = dbconn.GetSqlConnection();
            SqlCommand command = new SqlCommand(nameSearchProcedure, conn);
            command.Parameters.AddWithValue(nameParameterProcedure, databysearch);
            command.CommandType = CommandType.StoredProcedure;
            var reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    data.Add(new string[8]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                    data[data.Count - 1][7] = reader[7].ToString();
                }
            }

            reader.Close();
            conn.Close();

            foreach (string[] s in data)
            {
                dataGridViewSearchDataCriterian.Rows.Add(s);
            }
        }

        private void buttonExchangeBook_Click(object sender, EventArgs e) //Открытие формы добавления книги
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void buttonStoreDataCloset_Click(object sender, EventArgs e) // Открытие формы добавления хранилища
        {
            Хранение frm = new Хранение();
            frm.Show();
        }

        //Выдача книг
        private void buttonLoadProfessorData_Click(object sender, EventArgs e) // Загрузка данных о професорах
        {
            for (int i = 0; i < dataGridViewProfessorDAta.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewProfessorDAta.ColumnCount; j++)
                {
                    dataGridViewProfessorDAta.Rows[i].Cells[j].Value = null;
                }
            }

            dataGridViewProfessorDAta.RowCount = 1;
            dbconn = new DBConnection(DataBank.login, DataBank.pass);
            SqlConnection conn = dbconn.GetSqlConnection();
            SqlCommand command = new SqlCommand("SelectProfessors", conn);           
            command.CommandType = CommandType.StoredProcedure;
            var reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    data.Add(new string[5]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();                  
                }
            }

            reader.Close();
            conn.Close();

            foreach (string[] s in data)
            {
                dataGridViewProfessorDAta.Rows.Add(s);
            }
            dataGridViewProfessorDAta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void buttonDataGroup_Click(object sender, EventArgs e) // Загрузка данных о группах
        {
            for (int i = 0; i < dataGridViewDataGroup.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewDataGroup.ColumnCount; j++)
                {
                    dataGridViewDataGroup.Rows[i].Cells[j].Value = null;
                }
            }

            dataGridViewDataGroup.RowCount = 1;
            dbconn = new DBConnection(DataBank.login, DataBank.pass);
            SqlConnection conn = dbconn.GetSqlConnection();
            SqlCommand command = new SqlCommand("SelectGroup", conn);
            command.CommandType = CommandType.StoredProcedure;
            var reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    data.Add(new string[4]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();                
                }
            }

            reader.Close();
            conn.Close();

            foreach (string[] s in data)
            {
                dataGridViewDataGroup.Rows.Add(s);
            }
            dataGridViewDataGroup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void buttonLoadLibraryCard_Click(object sender, EventArgs e) //Загрузка данных о читательских билетах
        {
            for (int i = 0; i < dataGridViewLibraryCard.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewLibraryCard.ColumnCount; j++)
                {
                    dataGridViewLibraryCard.Rows[i].Cells[j].Value = null;
                }
            }

            dataGridViewLibraryCard.RowCount = 1;
            dbconn = new DBConnection(DataBank.login, DataBank.pass);
            SqlConnection conn = dbconn.GetSqlConnection();
            SqlCommand command = new SqlCommand("SelectLibraryCard", conn);
            command.CommandType = CommandType.StoredProcedure;
            var reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    data.Add(new string[3]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                }
            }

            reader.Close();
            conn.Close();

            foreach (string[] s in data)
            {
                dataGridViewLibraryCard.Rows.Add(s);
            }
            dataGridViewLibraryCard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void buttonForm_Click(object sender, EventArgs e) // Загрузка данных о формулярах
        {
            for (int i = 0; i < dataGridViewFormData.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewFormData.ColumnCount; j++)
                {
                    dataGridViewFormData.Rows[i].Cells[j].Value = null;
                }
            }

            dataGridViewFormData.RowCount = 1;
            dbconn = new DBConnection(DataBank.login, DataBank.pass);
            SqlConnection conn = dbconn.GetSqlConnection();
            SqlCommand command = new SqlCommand("SelectForm", conn);
            command.CommandType = CommandType.StoredProcedure;
            var reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    data.Add(new string[6]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                }
            }

            reader.Close();
            conn.Close();

            foreach (string[] s in data)
            {
                dataGridViewFormData.Rows.Add(s);
            }
            dataGridViewFormData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        //***************************************************************************************Форма оформления выдачи книги и их возврата
        private void buttonFormGiveBook_Click(object sender, EventArgs e) //Выдача книги
        {
            Оформление_выдачи_и_возврата_книг frm = new Оформление_выдачи_и_возврата_книг();
            frm.Show();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e) // Проверка ввода только цифр и удаления символовы
        {
            if (!((e.KeyChar >= '1' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBoxCriterianSearchBook_KeyPress(object sender, KeyPressEventArgs e) // Проверка на ввод цифр, символов, удаление символов
        {          
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && (l < 'A' || l > 'z') && l != ':' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
