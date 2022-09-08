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
    public partial class Список_выданных_и_возвращенных_книг : Form
    {
        public Список_выданных_и_возвращенных_книг()
        {
            InitializeComponent();
        }
        DBConnection dbconn;
        private void buttonBookOnArm_Click(object sender, EventArgs e)//Книги на руках загрузка данных
        {
            for (int i = 0; i < dataGridViewBookOnArm.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewBookOnArm.ColumnCount; j++)
                {
                    dataGridViewBookOnArm.Rows[i].Cells[j].Value = null;
                }
            }

            dataGridViewBookOnArm.RowCount = 1;
            dbconn = new DBConnection(DataBank.login, DataBank.pass);
            SqlConnection conn = dbconn.GetSqlConnection();
            SqlCommand command = new SqlCommand("NotBookLibrary", conn);
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
                dataGridViewBookOnArm.Rows.Add(s);
            }
            dataGridViewBookOnArm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ExcelExport(dataGridViewBookOnArm);
            
        }
        void ExcelExport(DataGridView grid)//выгрузка данных в файл Excel
        {
            Excel.Application exapp = new Excel.Application();

            exapp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exapp.ActiveSheet;

            for (int i = 0; i < grid.RowCount - 1; i++)
            {
                for (int j = 0; j < grid.ColumnCount; j++)
                {
                    wsh.Cells[i + 2, j + 1] = grid[j, i].Value.ToString();
                }
            }
            wsh.Cells[1, 1] = "Название книги";
            wsh.Cells[1, 2] = "Автор";
            wsh.Cells[1, 3] = "Имя студента";
            wsh.Cells[1, 4] = "Фамилия студента";
            wsh.Cells[1, 5] = "Отчество студента";          
            exapp.Visible = true;
        }

        private void buttonBookBack_Click(object sender, EventArgs e)//Список возвращенных книг
        {
            for (int i = 0; i < dataGridViewBookBack.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewBookBack.ColumnCount; j++)
                {
                    dataGridViewBookBack.Rows[i].Cells[j].Value = null;
                }
            }

            dataGridViewBookBack.RowCount = 1;
            dbconn = new DBConnection(DataBank.login, DataBank.pass);
            SqlConnection conn = dbconn.GetSqlConnection();
            SqlCommand command = new SqlCommand("BookBackLibrary", conn);
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
                dataGridViewBookBack.Rows.Add(s);
            }
            dataGridViewBookBack.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ExcelExport(dataGridViewBookBack);
        }       
    }
}
