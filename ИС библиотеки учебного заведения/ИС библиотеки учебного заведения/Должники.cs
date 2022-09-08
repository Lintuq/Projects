using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Data.SqlClient;

namespace ИС_библиотеки_учебного_заведения
{
    public partial class Должники : Form
    {
        public Должники()
        {
            InitializeComponent();
        }
        DBConnection dbconn;

        private void buttonDebtor_Click(object sender, EventArgs e)//Загрузка данных о определенном должнике
        {
            if (textBoxIdStudent.Text == "")
            {
                MessageBox.Show("Вы ничего не ввели");
                return;
            }
            int idstudent = Convert.ToInt32(textBoxIdStudent.Text);

            for (int i = 0; i < dataGridViewDebtor.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewDebtor.ColumnCount; j++)
                {
                    dataGridViewDebtor.Rows[i].Cells[j].Value = null;
                }
            }

            dataGridViewDebtor.RowCount = 1;
            dbconn = new DBConnection(DataBank.login, DataBank.pass);
            SqlConnection conn = dbconn.GetSqlConnection();
            SqlCommand command = new SqlCommand("ChooseStudentWithDebtor", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idstudent", idstudent);
            var reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    data.Add(new string[10]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                    data[data.Count - 1][7] = reader[7].ToString();
                    data[data.Count - 1][8] = reader[8].ToString();
                    data[data.Count - 1][9] = reader[9].ToString();
                }
            }

            reader.Close();
            conn.Close();

            foreach (string[] s in data)
            {
                dataGridViewDebtor.Rows.Add(s);
            }
            dataGridViewDebtor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void textBoxIdStudent_KeyPress(object sender, KeyPressEventArgs e)//Проверка на ввод цифр и удаление одного символа
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void buttonExportExcel_Click(object sender, EventArgs e)// Экспорт отчета в файл Excel
        {
            Excel.Application exapp = new Excel.Application();

            exapp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exapp.ActiveSheet;

            for (int i = 0; i < dataGridViewDebtor.RowCount - 1; i++)
            {
                for (int j = 0; j < dataGridViewDebtor.ColumnCount; j++)
                {                    
                    wsh.Cells[i + 2, j + 1] = dataGridViewDebtor[j, i].Value.ToString();
                }
            }
            wsh.Cells[1, 1] = "Название книги";
            wsh.Cells[1, 2] = "Автор";
            wsh.Cells[1, 3] = "Имя студента";
            wsh.Cells[1, 4] = "Фамилия студента";
            wsh.Cells[1, 5] = "Отчество студента";
            wsh.Cells[1, 6] = "Номер группы";
            wsh.Cells[1, 7] = "Имя куратора";
            wsh.Cells[1, 8] = "Фамилия куратора";
            wsh.Cells[1, 9] = "Отчество куратора";
            wsh.Cells[1, 10] = "Почта куратора";
            exapp.Visible = true;
        }
    }
}
