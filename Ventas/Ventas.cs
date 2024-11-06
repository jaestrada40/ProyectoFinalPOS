using Microsoft.Data.SqlClient;
using ProyectoFinalPOS.Carrito;
using ProyectoFinalPOS.DBconexion;
using ProyectoFinalPOS.Objects;
using ProyectoFinalPOS.Productos;
using ProyectoFinalPOS.Recibo;
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
        private decimal totalCarrito = 0m;
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
                productCard.Width = 198;
                productCard.Height = 300;

                // Suscribirse al evento AgregarAlCarritoClicked
                productCard.AgregarAlCarritoClicked += ProductCard_AgregarAlCarritoClicked;

                flowLayoutPanel1.Controls.Add(productCard);
            }
        }

        // Método manejador de eventos para agregar el producto al carrito
        private void ProductCard_AgregarAlCarritoClicked(object sender, Product producto)
        {
            // Buscar si el producto ya está en el carrito
            CarritoItemCard itemExistente = flowLayoutPanelCarrito.Controls
                .OfType<CarritoItemCard>()
                .FirstOrDefault(item => item.ProductID == producto.ProductID);

            if (itemExistente != null)
            {
                // Si el producto ya existe, incrementamos su cantidad
                itemExistente.IncrementarCantidad();
                totalCarrito += producto.Price; // Sumar el precio al total
            }
            else
            {
                // Si el producto no existe, lo agregamos al carrito
                CarritoItemCard itemCarrito = new CarritoItemCard(producto);

                // Suscribirse al evento ProductoEliminado
                itemCarrito.ProductoEliminado += ItemCarrito_ProductoEliminado;

                flowLayoutPanelCarrito.Controls.Add(itemCarrito);

                totalCarrito += producto.Price; // Sumar el precio al total
            }

            // Actualizar el total en la interfaz
            ActualizarTotal();
        }

        // Método manejador para el evento de eliminación de producto
        private void ItemCarrito_ProductoEliminado(object sender, Product producto)
        {
            // Restar el precio del producto eliminado al total y actualizar la etiqueta
            totalCarrito -= producto.Price;
            ActualizarTotal();
        }

        private void ActualizarTotal()
        {
            lblTotal.Text = $"Q{totalCarrito:F2}";
        }


        // Método Productos
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

        private void btnPagar_Click(object sender, EventArgs e)
        {
            // Lista para almacenar los items en el carrito
            List<CarritoItemCard> itemsCarrito = new List<CarritoItemCard>();
            decimal total = 0;

            // Calcular el total y llenar la lista de items en el carrito
            foreach (CarritoItemCard item in flowLayoutPanelCarrito.Controls)
            {
                itemsCarrito.Add(item);
                total += item.Price * item.Cantidad;
            }

            // Mostrar el recibo
            ReciboForm recibo = new ReciboForm(itemsCarrito, total);
            recibo.ShowDialog();
        }
    }
}
