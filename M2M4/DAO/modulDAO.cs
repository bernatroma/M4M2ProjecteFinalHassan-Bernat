using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using M2M4.Model;
using MySql.Data.MySqlClient;

namespace M2M4.DAO
{
    public class modulDAO
    {
        public bool modulInsert(Modul modul)
        {
            String nom = modul.nom;
            String uf = modul.uf;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(M2M4DAO.connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO modul (Nom, Uf) VALUES (@Nom,@Uf);";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nom", nom);
                    command.Parameters.AddWithValue("@Uf", uf);
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
