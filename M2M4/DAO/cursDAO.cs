using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2M4.Model;

namespace M2M4.DAO{

    public class cursDAO
    {
        public static bool insertCurs(Curs c)
        {
            String nom = c.GetNom();
            String any = c.GetAny();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(M2M4DAO.connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO curs (Curs, Any) VALUES (@Curs,@Any);";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Curs", nom);
                    command.Parameters.AddWithValue("@Any", any);
                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                // Manejo de errores de MySQL
                Console.WriteLine("Ocurrió un error al ejecutar la consulta: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                // Manejo de errores generales
                Console.WriteLine("Ocurrió un error: " + ex.Message);
                return false;
            }
        }
    }
    
}
