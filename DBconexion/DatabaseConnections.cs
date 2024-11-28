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

        //private string connectionString = "Server=uspg.database.windows.net,1433;Database=winforms-pos;User Id=jsoberanis;Password=9^pz6Pwr*7&@#50Y;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private string connectionString = "Server=localhost,1400;Database=Mercado;User Id=sa;Password=S2V@Cs2JOWgQ;TrustServerCertificate=true;";

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