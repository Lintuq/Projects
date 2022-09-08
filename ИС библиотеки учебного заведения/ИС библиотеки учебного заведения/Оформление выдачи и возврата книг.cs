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
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace ИС_библиотеки_учебного_заведения
{
    public partial class Оформление_выдачи_и_возврата_книг : Form
    {
        DBConnection dbconn;
        public Оформление_выдачи_и_возврата_книг()
        {
            InitializeComponent();
        }

        private void buttonLoadGetBook_Click(object sender, EventArgs e) // Взятые книги
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

        private void buttonSelectStudent_Click(object sender, EventArgs e)//Загрузка данных о студентах
        {
            for (int i = 0; i < dataGridViewStudent.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewStudent.ColumnCount; j++)
                {
                    dataGridViewStudent.Rows[i].Cells[j].Value = null;
                }
            }

            dataGridViewStudent.RowCount = 1;
            dbconn = new DBConnection(DataBank.login, DataBank.pass);
            SqlConnection conn = dbconn.GetSqlConnection();
            SqlCommand command = new SqlCommand("SelectStudent", conn);
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
                dataGridViewStudent.Rows.Add(s);
            }
            dataGridViewStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void buttonGiveBook_Click(object sender, EventArgs e)//Выдача книги на руки
        {
            if (textBoxIdStudent.Text == "" || textBoxIdForm.Text == "" || textBoxIdBook.Text == ""
                || textBoxIdRecord.Text == "" || comboBoxStatus.Text == "")
            {
                MessageBox.Show("Вы ничего не ввели");
                return;
            }
            DateTime date = dateTimePickerRecord.Value;
            string day = date.Day.ToString();
            string mounth = date.Month.ToString();
            string year = date.Year.ToString();
            string datarecord = year + "." + mounth + "." + day;
            int idstudent = Convert.ToInt32(textBoxIdStudent.Text);
            int idform = Convert.ToInt32(textBoxIdForm.Text);
            int idbook = Convert.ToInt32(textBoxIdBook.Text);
            int idrecord = Convert.ToInt32(textBoxIdRecord.Text);
            string statusbook = comboBoxStatus.Text;

            dbconn = new DBConnection(DataBank.login, DataBank.pass);
            SqlConnection conn = dbconn.GetSqlConnection();

            try
            {
                SqlCommand command = new SqlCommand("InsertGiveBook", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@IdStudent", idstudent);
                command.Parameters.AddWithValue("@IdForm", idform);
                command.Parameters.AddWithValue("@IdBook", idbook);
                command.Parameters.AddWithValue("@IdRecord", idrecord);
                command.Parameters.AddWithValue("@DateRecord", datarecord);
                command.Parameters.AddWithValue("@StatusBook", statusbook);
                command.ExecuteNonQuery();

                MessageBox.Show("Вы успешно внесли запись");
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка, внесение не представляется возможным");
                return;
                throw;
            }
            ChangeCountBook(idbook,conn);
        }

        private void ChangeCountBook(int idBook, SqlConnection conn)//Изменение количества книг при выдаче - уменьшение
        {
            SqlCommand command = new SqlCommand("UpdateCountBook", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@IdBook", idBook);
            command.ExecuteNonQuery();
        }

        private void dataGridViewFormData_CellClick(object sender, DataGridViewCellEventArgs e)//Загрузка данных по щелчку на ячейку
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder sb1 = new StringBuilder();

            sb.Append(dataGridViewFormData.Rows[dataGridViewFormData.CurrentRow.Index].Cells[3].Value);
            sb1.Append(dataGridViewFormData.Rows[dataGridViewFormData.CurrentRow.Index].Cells[5].Value);

            textBoxIdRecordNack.Text = sb.ToString();
            comboBoxStatusBack.Text = sb1.ToString();
        }

        private void buttonBackBook_Click(object sender, EventArgs e)//Возвращение книги в библиотеку
        {
            if (textBoxIdRecordNack.Text == "" || comboBoxStatusBack.Text == "")
            {
                MessageBox.Show("Вы ничего не ввели");
                return;
            }
            int idrecord = Convert.ToInt32(textBoxIdRecordNack.Text);
            string statusbook = comboBoxStatusBack.Text;

            dbconn = new DBConnection(DataBank.login, DataBank.pass);
            SqlConnection conn = dbconn.GetSqlConnection();

            try
            {
                SqlCommand command = new SqlCommand("UpdateStatusBook", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@IdRecord", idrecord);
                command.Parameters.AddWithValue("@StatusBook", statusbook);
                command.ExecuteNonQuery();                
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не успешно вернули книгу");
                return;
                throw;
            }
            BackBookLibrary(idrecord, conn);
        }

        private void BackBookLibrary(int idRecord, SqlConnection conn)//Изменение количества книг в библиотеки - увеличение
        {
            SqlCommand command = new SqlCommand("UpdateBookBack", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@IdRecord", idRecord);
            command.ExecuteNonQuery();
        }

        private void buttonAllBookAllThisTime_Click(object sender, EventArgs e)//Выгрузка отчета о взятых книгах за все время
        {           
               Excel.Application exapp = new Excel.Application();

                exapp.Workbooks.Add();
                Excel.Worksheet wsh = (Excel.Worksheet)exapp.ActiveSheet;

                for (int i = 0; i < dataGridViewFormData.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridViewFormData.ColumnCount; j++)
                    {
                        //wsh.Cells[1, dataGridViewFormData.ColumnCount] = dataGridViewFormData.Columns[dataGridViewFormData.ColumnCount - 1].HeaderCell.Value;
                        wsh.Cells[i + 2, j + 1] = dataGridViewFormData[j, i].Value.ToString();
                    }
                }
            wsh.Cells[1, 1] = "Идентификатор студента";
            wsh.Cells[1, 2] = "Идентификатор формуляра";
            wsh.Cells[1, 3] = "Идентификатор книги";
            wsh.Cells[1, 4] = "Идентификатор выдачи";
            wsh.Cells[1, 5] = "Дата выдачи";
            wsh.Cells[1, 6] = "Статус книги";
            exapp.Visible = true;            
        }

        private void buttonBookOnArm_Click(object sender, EventArgs e)//ОТкрытие новой формы
        {
            Список_выданных_и_возвращенных_книг frm = new Список_выданных_и_возвращенных_книг();
            frm.Show();
        }

        private void buttonDebtor_Click(object sender, EventArgs e)//Открытие формыы
        {
            Должники frm = new Должники();
            frm.Show();
        }

        //Проверка на ввод значений
        private void textBoxIdStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBoxIdForm_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxIdRecord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBoxIdRecordNack_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
