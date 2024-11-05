using Microsoft.Data.SqlClient;
using ProyectoFinalPOS.DBconexion;
using ProyectoFinalPOS.Objects;
using ProyectoFinalPOS.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalPOS.Ventas
{
    public partial class Ventas : UserControl
    {

        private SqlConnection connection = DatabaseConnections.GetInstance().GetConnection();
        public Ventas()
        {
            InitializeComponent();
            CargarFlashCards();
        }


        private void CargarFlashCards()
        {
            List<Product> productos = ObtenerProductos();

            foreach (Product producto in productos)
            {
                ProductCard productCard = new ProductCard();
                productCard.SetProductData(producto);
                productCard.Width = 200; 
                productCard.Height = 300; 

                flowLayoutPanel1.Controls.Add(productCard);
            }
        }

        private List<Product> ObtenerProductos()
        {
            List<Product> productos = new List<Product>();
            string query = "SELECT ProductID, Code, Name, Description, Price, Stock, ImagePath FROM Products";

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Product producto = new Product
                        {
                            ProductID = reader.GetInt32(0),
                            Code = reader.GetString(1),
                            Name = reader.GetString(2),
                            Description = reader.GetString(3),
                            Price = reader.GetDecimal(4),
                            Stock = reader.GetInt32(5),
                            ImagePath = reader.IsDBNull(6) ? null : reader.GetString(6)
                        };
                        productos.Add(producto);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return productos;
        }



    }
}
