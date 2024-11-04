using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPOS.DBconexion
{
    internal class DatabaseConnections
    {
        private static DatabaseConnections instance = null;

        //private string connectionString = "Server=localhost,1400;Database=PointOfSale;User Id=sa;Password=S2V@Cs2JOWgQ;TrustServerCertificate=true;";
        private string connectionString = "Server=localhost,1400;Database=PointOfSale;User Id=sa;Password=S2V@Cs2JOWgQ;TrustServerCertificate=true;";

        private SqlConnection connection;

        private DatabaseConnections()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

            }
            catch (Exception ex)
            { 
                Console.WriteLine($"Error al abrir la conexión. {ex.Message}");
            }
        }

        public static DatabaseConnections GetInstance()
        {
            if(instance == null)
            {
                instance = new DatabaseConnections();
            }
            return instance;
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}