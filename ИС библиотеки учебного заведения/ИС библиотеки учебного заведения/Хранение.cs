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
    public partial class Хранение : Form
    {
        public Хранение()
        {
            InitializeComponent();
        }

        DBConnection dbconn;
        private void buttonLoadStoreData_Click(object sender, EventArgs e)//Загрузка данных о хранилище
        {
            LoadStoreData();
        }

        private void LoadStoreData()//Процедура на загрузку данных
        {
            for (int i = 0; i < dataGridViewStoreData.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewStoreData.ColumnCount; j++)
                {
                    dataGridViewStoreData.Rows[i].Cells[j].Value = null;
                }
            }

            string SqlExpression = "StoreDataLoad";
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

            dataGridViewStoreData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void buttonAddStore_Click(object sender, EventArgs e)//Добавление нового хранилища
        {
            if (textBoxIdStore.Text == "" || textBoxNumberShelf.Text == "" || textBoxNumberBook.Text == "")
            {
                MessageBox.Show("Вы ничего не ввели ничего ввели");
                return;
            }
            int idstore = Convert.ToInt32(textBoxIdStore.Text);
            int numbershelf = Convert.ToInt32(textBoxNumberShelf.Text);
            int numberbook = Convert.ToInt32(textBoxNumberBook.Text);

            dbconn = new DBConnection(DataBank.login, DataBank.pass);
            SqlConnection conn = dbconn.GetSqlConnection();

            try
            {
                SqlCommand command = new SqlCommand("InsertStoreData", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@IdStore", idstore);
                command.Parameters.AddWithValue("@NumberShelf", numbershelf);
                command.Parameters.AddWithValue("@NumberBook", numberbook);

                command.ExecuteNonQuery();
                MessageBox.Show("Вы успешно внесли запись");
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка, внесение не представляется возможным");
                return;
                throw;                
            }
        }

        private void buttonUpdateStore_Click(object sender, EventArgs e)//Обновление данных о хранилище
        {
            if (textBoxOldIdStore.Text == "" || textBoxNewIdStore.Text == "" || textBoxNumberShelfUpdate.Text == "" 
                || textBoxNumberBookUpdate.Text == "")
            {
                MessageBox.Show("Вы ничего не ввели");
                return;
            }
            int oldid = Convert.ToInt32(textBoxOldIdStore.Text);
            int newid = Convert.ToInt32(textBoxNewIdStore.Text);
            int numbershelfupdate = Convert.ToInt32(textBoxNumberShelfUpdate.Text);
            int numberbookupdate = Convert.ToInt32(textBoxNumberBookUpdate.Text);

            dbconn = new DBConnection(DataBank.login, DataBank.pass);
            SqlConnection conn = dbconn.GetSqlConnection();
            SqlCommand command = new SqlCommand("UpdateStoreData", conn);
            command.CommandType = CommandType.StoredProcedure;

            try
            {               
                command.Parameters.AddWithValue("@idoldstore", oldid);
                command.Parameters.AddWithValue("@idnewstore", newid);
                command.Parameters.AddWithValue("@numbershelf", numbershelfupdate);
                command.Parameters.AddWithValue("@numberbook", numberbookupdate);

                command.ExecuteNonQuery();             
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не смогли обновить хранилище");
                throw;
            }           
        }

        private void buttonDeleteStore_Click(object sender, EventArgs e)//Удаление данных о хранилище
        {
            if (textBoxNumberDeleteStore.Text == "")
            {
                MessageBox.Show("Вы ничего не ввели ничего не ввели");
                return;
            }
            int idstoredelete = Convert.ToInt32(textBoxNumberDeleteStore.Text);
            dbconn = new DBConnection(DataBank.login, DataBank.pass);
            SqlConnection conn = dbconn.GetSqlConnection();

            try
            {
                SqlCommand command = new SqlCommand("DeleteStore", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@iddelete", idstoredelete);
                command.ExecuteNonQuery();
                MessageBox.Show("Вы успешно удалили хранилище");
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не смогли удалить хранилище");
                return;
                throw;
            }           
        }

        //Проверка на ввод
        private void textBoxIdStore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBoxNumberShelf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBoxNumberBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBoxOldIdStore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBoxNewIdStore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBoxNumberShelfUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBoxNumberBookUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBoxNumberDeleteStore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
