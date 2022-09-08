using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ИС_библиотеки_учебного_заведения
{
    class DBConnection
    {
        private string login;
        private string password;

        public DBConnection(string loginstr, string passwordstr)
        {
            login = loginstr;
            password = passwordstr;
        }
        
        public SqlConnection GetSqlConnection()
        {
                string connString = @"Server=.;Database=College_Library;User ID =" + login + ";Password =" + password;
                SqlConnection connection = new SqlConnection(connString);
                connection.Open();
                return connection;               
        }
    }
}
