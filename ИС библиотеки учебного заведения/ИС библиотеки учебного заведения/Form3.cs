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
    public partial class Form3 : Form
    {
        DBConnection dbconn;
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonLoadBookDataForInsert_Click(object sender, EventArgs e) // Загрузка данных о книгах
        {
            LoadBookData();            
        }

        private void LoadBookData() // Процедура загрузки данных о книгах
        {
            for (int i = 0; i < dataGridViewBookDataForInsert.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewBookDataForInsert.ColumnCount; j++)
                {
                    dataGridViewBookDataForInsert.Rows[i].Cells[j].Value = null;
                }
            }

            string SqlExpression = "BookDataForInsert";
            dataGridViewBookDataForInsert.RowCount = 1;
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

            foreach (string[] s in data)
            {
                dataGridViewBookDataForInsert.Rows.Add(s);
            }

            int rows = dataGridViewBookDataForInsert.RowCount;
            for (int i = 0; i < rows; i++)
            {
                dataGridViewBookDataForInsert.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            dataGridViewBookDataForInsert.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            foreach (string[] s in DataBank.numberstore)
            {
                comboBoxNumber.Items.Add(s[0]);
            }
        }

        private void buttonInsertBook_Click(object sender, EventArgs e) //Загрузка книги
        {
            if (textBoxNameBook.Text == "" || textBoxAuthorBook.Text == "" || textBoxPublisher.Text == "" || textBoxLBC.Text == ""
                || textBoxAmountBook.Text == "" || comboBoxNumber.Text == "")
            {
                MessageBox.Show("Вы ничего не ввесли");
                return;
            }
            string namebook = textBoxNameBook.Text;
            string author = textBoxAuthorBook.Text;
            string publisher = textBoxPublisher.Text;
            DateTime date = dateTimePickerYearPublish.Value;
            int year = date.Year;
            string LBC = textBoxLBC.Text;
            int amount = Convert.ToInt32(textBoxAmountBook.Text);
            int idstore = Convert.ToInt32(comboBoxNumber.Text);

            dbconn = new DBConnection(DataBank.login, DataBank.pass);
            SqlConnection conn = dbconn.GetSqlConnection();
            try
            {
                SqlCommand command = new SqlCommand("InsertBook", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@namebook", namebook);
                command.Parameters.AddWithValue("@author", author);
                command.Parameters.AddWithValue("@publisher", publisher);
                command.Parameters.AddWithValue("@year_of_publish", year);
                command.Parameters.AddWithValue("@LBC", LBC);
                command.Parameters.AddWithValue("@Amount", amount);
                command.Parameters.AddWithValue("@IdStore", idstore);

                command.ExecuteNonQuery();
                MessageBox.Show("Вы успешно внесли запись");
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка, внесение не представляется возможным");
                return;
            }           
        }
        
        private void buttonLoadBookData_Click(object sender, EventArgs e)// Загрузка данных для удаления определенной книги
        {
            LoadBookDataForDelete();
        }

        private void LoadBookDataForDelete()
        {
            for (int i = 0; i < dataGridViewBookDataByDelete.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewBookDataByDelete.ColumnCount; j++)
                {
                    dataGridViewBookDataByDelete.Rows[i].Cells[j].Value = null;
                }
            }

            for (int i = 0; i < dataGridViewForUpdate.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewForUpdate.ColumnCount; j++)
                {
                    dataGridViewForUpdate.Rows[i].Cells[j].Value = null;
                }
            }

            string SqlExpression = "LoadBookDataForDelete";
            dataGridViewBookDataByDelete.RowCount = 1;
            dataGridViewForUpdate.RowCount = 1;
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
                dataGridViewBookDataByDelete.Rows.Add(s);
                dataGridViewForUpdate.Rows.Add(s);
            }

            int rows = dataGridViewBookDataByDelete.RowCount;
            for (int i = 0; i < rows; i++)
            {
                dataGridViewBookDataByDelete.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            dataGridViewBookDataByDelete.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void Form3_Load(object sender, EventArgs e)// Загрузка записей закладок
        {
            tabPage1.Text = @"Добавление книги";
            tabPage2.Text = @"Удаление книги";
            tabPage3.Text = @"Устранение ошибок";
        }

        private void buttonDeleteBook_Click(object sender, EventArgs e) // Удаление книги
        {
            if (textBoxIdBook.Text == "" || textBoxNameBookDel.Text == "")
            {
                MessageBox.Show("Вы ничего не ввели");
                return;
            }
            int idbook = Convert.ToInt32(textBoxIdBook.Text);
            string namebook = Convert.ToString(textBoxNameBookDel.Text);

            DeleteBook(idbook,namebook);
        }

        private void DeleteBook(int id, string namebook)//Процедура на удаление книги
        {
            dbconn = new DBConnection(DataBank.login, DataBank.pass);
            SqlConnection conn = dbconn.GetSqlConnection();
            try
            {
                SqlCommand command = new SqlCommand("DeleteBook", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@idbook", id);
                command.Parameters.AddWithValue("@name_book", namebook);

                command.ExecuteNonQuery();
                MessageBox.Show("Вы успешно удалили книгу");
            }
            catch (Exception)
            {
                MessageBox.Show("Вы ничего не смогли удалить");
                return;
                throw;
            }           
        }

        private void dataGridViewBookDataByDelete_CellClick(object sender, DataGridViewCellEventArgs e)// Загрузка данных по клику на ячейку
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder sb1 = new StringBuilder();

            sb.Append(dataGridViewBookDataByDelete.Rows[dataGridViewBookDataByDelete.CurrentRow.Index].Cells[0].Value);
            sb1.Append(dataGridViewBookDataByDelete.Rows[dataGridViewBookDataByDelete.CurrentRow.Index].Cells[1].Value);

            textBoxIdBook.Text = sb.ToString();
            textBoxNameBookDel.Text = sb1.ToString();
        }

        private void buttonLoadData_Click_1(object sender, EventArgs e)//Загрузка данных в таблицу для выбора того что надо удалить
        {
            LoadBookDataForDelete();            
            foreach (string[] s in DataBank.numberstore)
            {               
                comboBoxUpdateData.Items.Add(s[0]);
            }
        }

        private void dataGridViewForUpdate_CellClick(object sender, DataGridViewCellEventArgs e)//Загрузка данных в поля по клику на ячейки таблицы
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            StringBuilder sb3 = new StringBuilder();
            StringBuilder sb4 = new StringBuilder();
            StringBuilder sb5 = new StringBuilder();
            StringBuilder sb6 = new StringBuilder();
            StringBuilder sb7 = new StringBuilder();

            sb.Append(dataGridViewForUpdate.Rows[dataGridViewForUpdate.CurrentRow.Index].Cells[1].Value);
            sb1.Append(dataGridViewForUpdate.Rows[dataGridViewForUpdate.CurrentRow.Index].Cells[2].Value);
            sb2.Append(dataGridViewForUpdate.Rows[dataGridViewForUpdate.CurrentRow.Index].Cells[3].Value);
            sb3.Append(dataGridViewForUpdate.Rows[dataGridViewForUpdate.CurrentRow.Index].Cells[4].Value);
            sb4.Append(dataGridViewForUpdate.Rows[dataGridViewForUpdate.CurrentRow.Index].Cells[5].Value);
            sb5.Append(dataGridViewForUpdate.Rows[dataGridViewForUpdate.CurrentRow.Index].Cells[6].Value);
            sb6.Append(dataGridViewForUpdate.Rows[dataGridViewForUpdate.CurrentRow.Index].Cells[7].Value);
            sb7.Append(dataGridViewForUpdate.Rows[dataGridViewForUpdate.CurrentRow.Index].Cells[0].Value);

            textBoxNameUpdate.Text = sb.ToString();
            textBoxAuthorUpdate.Text = sb1.ToString();
            textBoxPublisherUpdate.Text = sb2.ToString();
            textBoxDate.Text = sb3.ToString();
            textBoxLBCUPdate.Text = sb4.ToString();
            textBoxAmountUpdate.Text = sb5.ToString();
            comboBoxUpdateData.Text = sb6.ToString();
            textBoxNumberUpdate.Text = sb7.ToString();
        }

        private void buttonUpdatedata_Click(object sender, EventArgs e)// Обновление неверно введеных данных
        {
            if (textBoxNumberUpdate.Text == "" || textBoxNameUpdate.Text == "" || textBoxAuthorUpdate.Text == ""
                || textBoxPublisherUpdate.Text == "" || textBoxDate.Text == "" || textBoxLBCUPdate.Text == "" 
                || textBoxAmountUpdate.Text == "" || comboBoxUpdateData.Text == "")
            {
                MessageBox.Show("Вы ничего не ввели");
                return;
            }
            string numberIdUpdate = textBoxNumberUpdate.Text;
            string namebook = textBoxNameUpdate.Text;
            string authorupdate = textBoxAuthorUpdate.Text;
            string publisherupdate = textBoxPublisherUpdate.Text;
            string dateupdate = textBoxDate.Text;
            string LBCUpdate = textBoxLBCUPdate.Text;
            int amountUpdate = Convert.ToInt32(textBoxAmountUpdate.Text);
            int numberUpdate = Convert.ToInt32(comboBoxUpdateData.Text);

            UpdateDataBook(numberIdUpdate, namebook, authorupdate, publisherupdate, dateupdate, LBCUpdate, amountUpdate, numberUpdate);
        }

        private void UpdateDataBook(string numberIdUpdate, string namebook, string authorupdate, string publisherupdate, string dateupdate,
            string LBCUpdate, int amountUpdate, int numberUpdate)//Процедура на обновление данных о книге
        {
            dbconn = new DBConnection(DataBank.login, DataBank.pass);
            SqlConnection conn = dbconn.GetSqlConnection();

            SqlCommand command = new SqlCommand("UpdateBookData", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id",numberIdUpdate);
            command.Parameters.AddWithValue("@namebook", namebook);
            command.Parameters.AddWithValue("@author", authorupdate);
            command.Parameters.AddWithValue("@publisher", publisherupdate);
            command.Parameters.AddWithValue("@year_of_publishing", dateupdate);
            command.Parameters.AddWithValue("@LBC", LBCUpdate);
            command.Parameters.AddWithValue("@amount", amountUpdate);
            command.Parameters.AddWithValue("@idstore",numberUpdate);

            command.ExecuteNonQuery();
            MessageBox.Show("Вы успешно удалили книгу");
        }

        //Проверка на ввод допустимых символов
        private void textBoxAmountBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void comboBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBoxIdBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBoxAmountUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void comboBoxUpdateData_KeyPress(object sender, KeyPressEventArgs e)
        {          
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBoxLBC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar >= 'А' && e.KeyChar <= 'Я') || 
                (e.KeyChar >= 'а' && e.KeyChar <= 'я') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || 
                (e.KeyChar >= 'a' && e.KeyChar <= 'z') || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBoxPublisher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || 
                (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || 
                (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == ' ' || e.KeyChar == '-' || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBoxAuthorBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') ||
                (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z')
                || e.KeyChar == '.' || e.KeyChar == '-' || e.KeyChar == ' ' || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBoxNameBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') ||
                (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') ||
                e.KeyChar == '-' || e.KeyChar == ' ' || e.KeyChar == (char)Keys.Back || e.KeyChar == ':' || e.KeyChar == ',')) 
            {
                e.Handled = true;
            }
        }

        private void textBoxNameBookDel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') ||
                (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') ||
                 e.KeyChar == '-' || e.KeyChar == ' ' || e.KeyChar == ',' || e.KeyChar == ':'
                 || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back))
            {

                e.Handled = true;
            }
        }

        private void textBoxNameUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') ||
                (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') ||
                 e.KeyChar == '-' || e.KeyChar == ' ' || e.KeyChar == ',' || e.KeyChar == ':'
                 || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back))
            {

                e.Handled = true;
            }
        }

        private void textBoxNumberUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '1' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back))
            {

                e.Handled = true;
            }
        }

        private void textBoxAuthorUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') ||
                (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') ||
                 e.KeyChar == '-' || e.KeyChar == ' ' || e.KeyChar == ',' || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back))
            {

                e.Handled = true;
            }
        }

        private void textBoxPublisherUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') ||
                (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') ||
                 e.KeyChar == '-' || e.KeyChar == ' ' || e.KeyChar == ',' || e.KeyChar == '.' ||
                 e.KeyChar == ':' || e.KeyChar == (char)Keys.Back))
            {

                e.Handled = true;
            }
        }

        private void textBoxDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBoxLBCUPdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back)
                || (e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я'))
            {
                e.Handled = true;
            }
        }
    }
}
