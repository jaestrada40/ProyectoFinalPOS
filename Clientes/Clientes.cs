using Microsoft.Data.SqlClient;
using ProyectoFinalPOS.DBconexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalPOS.Clientes
{
    public partial class Clientes : UserControl
    {
        private SqlConnection connection = DatabaseConnections.GetInstance().GetConnection();
        public Clientes()
        {
            InitializeComponent();
            CustomersCarga();
        }


        private void CustomersCarga()
        {
            string query = "SELECT CustomerID, NIT, FirstName, LastName, Address, Phone FROM Customers";
            try
            {
                // Asegúrate de que la conexión esté abierta antes de usarla
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                // Llena un DataTable con los datos de la consulta
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, this.connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Asigna el DataTable como fuente de datos del DataGridView
                customersTable.DataSource = dataTable;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                // Opcional: cierra la conexión si no quieres mantenerla abierta
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
