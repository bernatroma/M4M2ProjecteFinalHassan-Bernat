using M2M4.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace M2M4.DAO
{
    public class alumneDAO
    {
        public static bool insertAlumne(Alumne alumne)
        {
            String nom = alumne.getName();
            String cognom = alumne.getLastName();
            int edat = alumne.getAge();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(M2M4DAO.connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO alumne (Nom, Cognom, Edat) VALUES (@Nom, @Cognom, @Edat);";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nom", nom);
                    command.Parameters.AddWithValue("@Cognom", cognom);
                    command.Parameters.AddWithValue("@Edat", edat);
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
            M2M4DAO.Desconectar();
        }
    }
}
