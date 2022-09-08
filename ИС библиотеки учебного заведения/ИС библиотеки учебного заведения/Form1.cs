using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ИС_библиотеки_учебного_заведения
{
    public partial class Form1 : Form
    {

        DBConnection dbconn;
        static int countPassEntry = 3;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            Point point = Screen.PrimaryScreen.WorkingArea.Location;           
            //Перенос в местоположение верхнего левого угла формы, чтобы её правый нижний угол попал в правый нижний угол экрана
            point.Offset(this.Top, this.Left);
            //Новое положение формы
            this.Location = point;
        }      
        private void Form1_Load(object sender, EventArgs e) //Центрирование формы с полями
        {
            Size resolution = Screen.PrimaryScreen.Bounds.Size;
            this.Size = new Size(resolution.Width,  resolution.Height);
            groupBox1.Top = this.Height / 2 - groupBox1.Height / 2;
            groupBox1.Left = this.Width / 2 - groupBox1.Width / 2;
            InputLogin.Text = "AvreliyYakov";
            InputPassword.Text = "BrdBtrPanzer#20-21";
        }

        private void buttonAuthorization_Click(object sender, EventArgs e) // Кнопка авторизации
        {
            string login = Convert.ToString(InputLogin.Text);
            string password = Convert.ToString(InputPassword.Text);
                       
            try // Попытки входа в систему
            {
                dbconn = new DBConnection(login, password);
                if (dbconn.GetSqlConnection() != null)
                {
                    MessageBox.Show("Вы успешно вошли в систему");
                    DataBank.login = login;
                    DataBank.pass = password;
                    Form2 frm = new Form2();
                    frm.Show();
                    Hide();
                }
            }
            catch (Exception)
            {
                countPassEntry--;
                MessageBox.Show("Вы неправильно ввели пароль! У вас осталось попыток ввода " + countPassEntry);                           
            }
            if (countPassEntry == 0)
            {
                MessageBox.Show("Вы неправильно ввели пароль! Поэтому программа закрывается");
                Close();
            }            
        }
    }
}
