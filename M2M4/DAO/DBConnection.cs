using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2M4.DAO{
    public static class M2M4DAO
    {
        private const string server = "db4free.net";
        private const string port = "3306";
        private const string database = "cursos_m4_m2";
        private const string user = "hassan";
        private const string password = "hassan12";

        public const string connectionString = "Server=" + server + ";Port=" + port + ";Database=" + database + ";uid=" + user + ";Pwd=" + password + ";OldGuids=true;";

        public static MySqlConnection connection;
        public static bool Connect()
        {
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static void Desconectar()
        {
            if (connection != null)
            {
                connection.Close();
            }
        }
    }
}
