using Microsoft.Data.SqlClient;
using ProyectoFinalPOS.Clases;
using ProyectoFinalPOS.DBconexion;
using ProyectoFinalPOS.Factura;
using ProyectoFinalPOS.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoFinalPOS.Historial
{
    public partial class Historial : UserControl
    {
        private SqlConnection connection = DatabaseConnections.GetInstance().GetConnection();
        public Historial()
        {
            InitializeComponent();
            HistorialCarga();
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // Agregar el manejador del evento
            historialTable.CellClick += HistorialTable_CellClick;
        }

        private void HistorialCarga()
        {
            string query = @"
                            SELECT 
                                jsoberanis_db.Sales.SaleID as ID,
                                jsoberanis_db.Employees.FirstName + ' ' + jsoberanis_db.Employees.LastName AS [Nombre del Empleado],
                                jsoberanis_db.Customers.FirstName + ' ' + jsoberanis_db.Customers.LastName AS [Nombre del Cliente],
                                jsoberanis_db.Customers.NIT,
                                COUNT(jsoberanis_db.SaleDetails.ProductID) AS [Total de Productos],
                                jsoberanis_db.Sales.Total
                            FROM jsoberanis_db.Sales
                            JOIN jsoberanis_db.Employees ON jsoberanis_db.Sales.EmployeeID = Employees.EmployeeID
                            JOIN jsoberanis_db.Customers ON jsoberanis_db.Sales.CustomerID = Customers.CustomerID
                            JOIN jsoberanis_db.SaleDetails ON Sales.SaleID = jsoberanis_db.SaleDetails.SaleID
                            GROUP BY jsoberanis_db.Sales.SaleID, jsoberanis_db.Employees.FirstName, jsoberanis_db.Employees.LastName, jsoberanis_db.Customers.FirstName, jsoberanis_db.Customers.LastName, jsoberanis_db.Customers.NIT, jsoberanis_db.Sales.Total";


            //string query = @"
            //                SELECT 
            //                    Sales.SaleID as ID,
            //                    Employees.FirstName + ' ' + Employees.LastName AS [Nombre del Empleado],
            //                    Customers.FirstName + ' ' + Customers.LastName AS [Nombre del Cliente],
            //                    Customers.NIT,
            //                    COUNT(SaleDetails.ProductID) AS [Total de Productos],
            //                    Sales.Total
            //                FROM Sales
            //                JOIN Employees ON Sales.EmployeeID = Employees.EmployeeID
            //                JOIN Customers ON Sales.CustomerID = Customers.CustomerID
            //                JOIN SaleDetails ON Sales.SaleID = SaleDetails.SaleID
            //                GROUP BY Sales.SaleID, Employees.FirstName, Employees.LastName, Customers.FirstName, Customers.LastName, Customers.NIT, Sales.Total";

                                try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, this.connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                historialTable.DataSource = dataTable;

                // Verifica si ya existe la columna de botón para evitar duplicados
                if (historialTable.Columns["FacturaButton"] == null)
                {
                    // Agrega una columna de botón
                    DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
                    {
                        Name = "FacturaButton",
                        HeaderText = "Imprimir",
                        Text = "Ver Factura",
                        UseColumnTextForButtonValue = true
                    };

                    historialTable.Columns.Add(buttonColumn);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void HistorialTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que el clic fue en la columna de botones
            if (e.RowIndex >= 0 && historialTable.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                // Obtén el ID de la venta de la fila seleccionada
                int saleId = Convert.ToInt32(historialTable.Rows[e.RowIndex].Cells["ID"].Value);

                // Abre el formulario de factura con los detalles de la venta
                MostrarFactura(saleId);
            }
        }

        private void MostrarFactura(int saleId)
        {
            FacturaForm facturaForm = new FacturaForm(saleId);
            facturaForm.ShowDialog();
        }

        private void BuscarVenta()
        {
            // Eliminar espacios en blanco alrededor del texto
            string searchValue = txtBuscar.Text.Trim();

            // Si el campo de búsqueda está vacío, carga todos los clientes
            if (string.IsNullOrWhiteSpace(searchValue))
            {
                HistorialCarga();
                return;
            }

            // Si hay texto en el campo, realiza la búsqueda
            string query =
                    @"
                    SELECT
                        jsoberanis_db.Sales.SaleID as ID,
                        jsoberanis_db.Employees.FirstName + ' ' + jsoberanis_db.Employees.LastName AS[Nombre del Empleado],
                        jsoberanis_db.Customers.FirstName + ' ' + jsoberanis_db.Customers.LastName AS[Nombre del Cliente],
                        jsoberanis_db.Customers.NIT,
                        COUNT(jsoberanis_db.SaleDetails.ProductID) AS[Total de Productos],
                        jsoberanis_db.Sales.Total
                    FROM jsoberanis_db.Sales
                    JOIN jsoberanis_db.Employees ON Sales.EmployeeID = jsoberanis_db.Employees.EmployeeID
                    JOIN jsoberanis_db.Customers ON Sales.CustomerID = jsoberanis_db.Customers.CustomerID
                    JOIN jsoberanis_db.SaleDetails ON Sales.SaleID = jsoberanis_db.SaleDetails.SaleID
                    WHERE
                        CONCAT(jsoberanis_db.Employees.FirstName, ' ', jsoberanis_db.Employees.LastName) LIKE @search OR
                        CONCAT(jsoberanis_db.Customers.FirstName, ' ', jsoberanis_db.Customers.LastName) LIKE @search OR
                        jsoberanis_db.Customers.NIT LIKE @search
                    GROUP BY
                        jsoberanis_db.Sales.SaleID, 
                        jsoberanis_db.Employees.FirstName, jsoberanis_db.Employees.LastName, 
                        jsoberanis_db.Customers.FirstName, jsoberanis_db.Customers.LastName, 
                        jsoberanis_db.Customers.NIT, 
                        jsoberanis_db.Sales.Total;";


            //string query =
            //        @"
            //        SELECT
            //            Sales.SaleID as ID,
            //            Employees.FirstName + ' ' + Employees.LastName AS[Nombre del Empleado],
            //            Customers.FirstName + ' ' + Customers.LastName AS[Nombre del Cliente],
            //            Customers.NIT,
            //            COUNT(SaleDetails.ProductID) AS[Total de Productos],
            //            Sales.Total
            //        FROM Sales
            //        JOIN Employees ON Sales.EmployeeID = Employees.EmployeeID
            //        JOIN Customers ON Sales.CustomerID = Customers.CustomerID
            //        JOIN SaleDetails ON Sales.SaleID = SaleDetails.SaleID
            //        WHERE
            //            CONCAT(Employees.FirstName, ' ', Employees.LastName) LIKE @search OR
            //            CONCAT(Customers.FirstName, ' ', Customers.LastName) LIKE @search OR
            //            Customers.NIT LIKE @search
            //        GROUP BY
            //            Sales.SaleID, 
            //            Employees.FirstName, Employees.LastName, 
            //            Customers.FirstName, Customers.LastName, 
            //            Customers.NIT, 
            //            Sales.Total;";


            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@search", "%" + searchValue + "%");

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    historialTable.DataSource = dataTable;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al buscar el empleado: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        // Evento para el botón de buscar
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarVenta();
        }

    }
}
