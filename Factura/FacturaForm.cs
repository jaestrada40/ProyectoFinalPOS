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

namespace ProyectoFinalPOS.Factura
{
    public partial class FacturaForm : Form
    {
        private int saleId;
        private SqlConnection connection = DatabaseConnections.GetInstance().GetConnection();
        public FacturaForm(int saleId)
        {
            InitializeComponent();
            this.saleId = saleId;
            CargarFactura();
        }

        private void CargarFactura()
        {

            string detalleVentaQuery = @"
                                        SELECT 
                                            jsoberanis_db.Sales.Total AS [Total Venta],
                                            jsoberanis_db.Employees.FirstName + ' ' + jsoberanis_db.Employees.LastName AS [Empleado],
                                            jsoberanis_db.Customers.FirstName + ' ' + jsoberanis_db.Customers.LastName AS [Cliente],
                                            jsoberanis_db.Customers.NIT
                                        FROM jsoberanis_db.Sales
                                        JOIN jsoberanis_db.Employees ON jsoberanis_db.Sales.EmployeeID = jsoberanis_db.Employees.EmployeeID
                                        JOIN jsoberanis_db.Customers ON jsoberanis_db.Sales.CustomerID = jsoberanis_db.Customers.CustomerID
                                        WHERE jsoberanis_db.Sales.SaleID = @SaleID";

            string productosQuery = @"
                                    SELECT 
                                        jsoberanis_db.Products.Name AS [Producto],
                                        jsoberanis_db.SaleDetails.Quantity AS [Cantidad],
                                        jsoberanis_db.SaleDetails.UnitPrice AS [Precio Unitario],
                                        (jsoberanis_db.SaleDetails.Quantity * jsoberanis_db.SaleDetails.UnitPrice) AS [Subtotal]
                                    FROM jsoberanis_db.SaleDetails
                                    JOIN jsoberanis_db.Products ON jsoberanis_db.SaleDetails.ProductID = jsoberanis_db.Products.ProductID
                                    WHERE jsoberanis_db.SaleDetails.SaleID = @SaleID";


            //string detalleVentaQuery = @"
            //                            SELECT 
            //                                Sales.Total AS [Total Venta],
            //                                Employees.FirstName + ' ' + Employees.LastName AS [Empleado],
            //                                Customers.FirstName + ' ' + Customers.LastName AS [Cliente],
            //                                Customers.NIT
            //                            FROM Sales
            //                            JOIN Employees ON Sales.EmployeeID = Employees.EmployeeID
            //                            JOIN Customers ON Sales.CustomerID = Customers.CustomerID
            //                            WHERE Sales.SaleID = @SaleID";

            //string productosQuery = @"
            //                        SELECT 
            //                            Products.Name AS [Producto],
            //                            SaleDetails.Quantity AS [Cantidad],
            //                            SaleDetails.UnitPrice AS [Precio Unitario],
            //                            (SaleDetails.Quantity * SaleDetails.UnitPrice) AS [Total]
            //                        FROM SaleDetails
            //                        JOIN Products ON SaleDetails.ProductID = Products.ProductID
            //                        WHERE SaleDetails.SaleID = @SaleID";

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                // Consultar detalles generales de la venta
                SqlCommand detalleVentaCommand = new SqlCommand(detalleVentaQuery, connection);
                detalleVentaCommand.Parameters.AddWithValue("@SaleID", saleId);
                SqlDataReader reader = detalleVentaCommand.ExecuteReader();

                if (reader.Read())
                {
                    lblEmpleado.Text = $"{reader["Empleado"]}";
                    lblCliente.Text = $"{reader["Cliente"]}";
                    lblNIT.Text = $"{reader["NIT"]}";
                    lblTotal.Text = $"{reader["Total Venta"]:C}";
                }
                reader.Close();

                // Consultar productos de la venta
                SqlCommand productosCommand = new SqlCommand(productosQuery, connection);
                productosCommand.Parameters.AddWithValue("@SaleID", saleId);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(productosCommand);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                facturaTable.DataSource = dataTable;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al cargar los datos de la factura: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }


        private void FacturaForm_Load(object sender, EventArgs e)
        {

        }

        private void lblCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
