using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourSewingPattern
{
    class DataBase
    {
        // Подключение к локальному серверу
        MySqlConnection connection = new MySqlConnection("server=localhost;port=8889;username=root;password=root;database=ysp");
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed) 
                connection.Open();
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open) 
                connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

    }
}
