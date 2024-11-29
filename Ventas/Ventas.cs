using Microsoft.Data.SqlClient;
using ProyectoFinalPOS.Carrito;
using ProyectoFinalPOS.Clases;
using ProyectoFinalPOS.DBconexion;
using ProyectoFinalPOS.Objects;
using ProyectoFinalPOS.Productos;
using ProyectoFinalPOS.Recibo;
using System;
using System.Collections;
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
        private string NombreCliente = null;
        private string ApellidoCliente = null;
        private string NitCliente = null;

        public Ventas()
        {
            InitializeComponent();
            CargarFlashCards();

            textBuscar.TextChanged += TextBuscar_TextChanged;
            btnPagar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void CargarFlashCards()
        {
            List<Product> productos = ObtenerProductos();

            foreach (Product producto in productos)
            {
                ProductCard productCard = new ProductCard();
                productCard.SetProductData(producto);
                productCard.Width = 195;
                productCard.Height = 300;

                // Suscribirse al evento AgregarAlCarritoClicked
                productCard.AgregarAlCarritoClicked += ProductCard_AgregarAlCarritoClicked;

                flowLayoutPanel2.Controls.Add(productCard);
            }
        }

        // Método Productos
        private List<Product> ObtenerProductos()    
        {
            List<Product> productos = new List<Product>();
            string query = "SELECT ProductID, Code, Name, Description, Price, Stock, ImagePath FROM jsoberanis_db.Products";
            //string query = "SELECT ProductID, Code, Name, Description, Price, Stock, ImagePath FROM Products";

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
                // Sumar el precio al total
                totalCarrito += producto.Price;

            }
            else
            {
                // Si el producto no existe, lo agregamos al carrito
                CarritoItemCard itemCarrito = new CarritoItemCard(producto);

                // Suscribirse al evento ProductoEliminado
                itemCarrito.ProductoEliminado += ItemCarrito_ProductoEliminado;

                flowLayoutPanelCarrito.Controls.Add(itemCarrito);

                // Sumar el precio al total
                totalCarrito += producto.Price;

                itemCarrito.CantidadReducida += ItemCarrito_CantidadReducida;
            }

            // Actualizar el total en la interfaz
            ActualizarTotal();
            btnPagar.Enabled = true;
        }

        // Para que al agregar una cantidad en el counter, lo elimine al presionar X
        private void ItemCarrito_CantidadReducida(object sender, (Product producto, int cantidad) args)
        {
            totalCarrito -= args.producto.Price * args.cantidad;

            if (totalCarrito < 0)

            {
                totalCarrito = 0;
            }

            ActualizarTotal();
        }


        // Método manejador para el evento de eliminación de producto
        private void ItemCarrito_ProductoEliminado(object sender, Product producto)
        {

            var item = (CarritoItemCard)sender;

            // Verifica que el control existe antes de eliminarlo
            if (flowLayoutPanelCarrito.Controls.Contains(item))
            {
                // Actualiza el total antes de eliminarlo
                totalCarrito -= producto.Price * item.Cantidad;

                flowLayoutPanelCarrito.Controls.Remove(item); // Elimina el control del contenedor
            }

            // Actualiza el total en la interfaz después de eliminar
            ActualizarTotal();
        }

        //Metodo para actualizar el total
        private void ActualizarTotal()
        {
            totalCarrito = flowLayoutPanelCarrito.Controls
                .OfType<CarritoItemCard>()
                .Sum(item => item.Price * item.Cantidad);
            lblTotal.Text = $"Q{totalCarrito:F2}";
            btnPagar.Enabled = totalCarrito > 0;
        }

        //Logica del boton pagar
        private void btnPagar_Click(object sender, EventArgs e)
        {
            // Validación del campo de NIT
            if (string.IsNullOrEmpty(NombreCliente) && string.IsNullOrEmpty(NitCliente))
            {
                DialogResult result = MessageBox.Show("No se ha ingresado un NIT. ¿Desea proceder con 'CF'?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    NombreCliente = "Consumidor Final";
                    NitCliente = "CF";
                }
                else
                {
                    MessageBox.Show("Debe ingresar un NIT para proceder con la compra.",
                        "NIT requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Validación si no hay productos en el carrito
            if (flowLayoutPanelCarrito.Controls.Count == 0)
            {
                MessageBox.Show("El carrito está vacío, por favor, agregue productos para continuar.",
                    "Carrito Vacio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<CarritoItemCard> itemsCarrito = flowLayoutPanelCarrito.Controls.OfType<CarritoItemCard>().ToList();
            decimal total = itemsCarrito.Sum(item => item.Price * item.Cantidad);

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open(); // Abre la conexión antes de la transacción
                }

                // Inicia la transacción
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    // Validación de stock disponible antes de realizar la venta
                    foreach (var item in itemsCarrito)
                    {
                        string queryCheckStock = "SELECT Stock FROM jsoberanis_db.Products WHERE ProductID = @ProductID";
                        //string queryCheckStock = "SELECT Stock FROM Products WHERE ProductID = @ProductID";
                        using (SqlCommand command = new SqlCommand(queryCheckStock, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@ProductID", item.ProductID);
                            int stockDisponible = Convert.ToInt32(command.ExecuteScalar());

                            if (item.Cantidad > stockDisponible)
                            {
                                MessageBox.Show($"El producto {item.ProductName} tiene un stock insuficiente. Disponible: {stockDisponible}.",
                                    "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                transaction.Rollback(); // Cancela la transacción si hay un error de stock
                                return;
                            }
                        }
                    }

                    // Inserción de la venta en la tabla Sales
                    string insertSaleQuery = "INSERT INTO jsoberanis_db.Sales (CustomerID, EmployeeID, Total) OUTPUT INSERTED.SaleID VALUES (@CustomerID, @EmployeeID, @Total)";
                    //string insertSaleQuery = "INSERT INTO Sales (CustomerID, EmployeeID, Total) OUTPUT INSERTED.SaleID VALUES (@CustomerID, @EmployeeID, @Total)";
                    int saleID;
                    using (SqlCommand command = new SqlCommand(insertSaleQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@CustomerID", ObtenerCustomerID(transaction));  // Pasamos la transacción aquí
                        command.Parameters.AddWithValue("@EmployeeID", Global.EmployeeID); // ID del empleado logueado
                        command.Parameters.AddWithValue("@Total", total);
                        saleID = (int)command.ExecuteScalar(); // Obtiene el SaleID generado
                    }

                    // Insertar los detalles de la venta en SaleDetails
                    foreach (CarritoItemCard item in itemsCarrito)
                    {
                        string insertDetailQuery = "INSERT INTO jsoberanis_db.SaleDetails (SaleID, ProductID, Quantity, UnitPrice) VALUES (@SaleID, @ProductID, @Quantity, @UnitPrice)";
                        //string insertDetailQuery = "INSERT INTO SaleDetails (SaleID, ProductID, Quantity, UnitPrice) VALUES (@SaleID, @ProductID, @Quantity, @UnitPrice)";
                        using (SqlCommand command = new SqlCommand(insertDetailQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@SaleID", saleID);
                            command.Parameters.AddWithValue("@ProductID", item.ProductID);
                            command.Parameters.AddWithValue("@Quantity", item.Cantidad);
                            command.Parameters.AddWithValue("@UnitPrice", item.Price);
                            command.ExecuteNonQuery();
                        }

                        // Actualizar el stock en la tabla Products
                        string updateStockQuery = "UPDATE jsoberanis_db.Products SET Stock = Stock - @Cantidad WHERE ProductID = @ProductID";
                        //string updateStockQuery = "UPDATE Products SET Stock = Stock - @Cantidad WHERE ProductID = @ProductID";
                        using (SqlCommand command = new SqlCommand(updateStockQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@Cantidad", item.Cantidad);
                            command.Parameters.AddWithValue("@ProductID", item.ProductID);
                            command.ExecuteNonQuery();
                        }
                    }

                    // Confirmar la transacción si todo ha ido bien
                    transaction.Commit();
                    MessageBox.Show("Compra realizada con éxito. El inventario se ha actualizado.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MostrarRecibo(itemsCarrito, total); // Mostrar el recibo
                    RecargarProductos(); // Actualizar los productos disponibles
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar la compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close(); // Cerrar la conexión al final
                }
            }

            // Limpiar el carrito después de realizar la compra
            LimpiarCarrito();
        }

        private int ObtenerCustomerID(SqlTransaction transaction)
        {
            if (string.IsNullOrEmpty(NitCliente)) return 0; // Si no hay cliente seleccionado, retornar 0 (o manejar como un "Consumidor Final")

            try
            {
                string query = "SELECT CustomerID FROM jsoberanis_db.Customers WHERE NIT = @NitCliente";
                //string query = "SELECT CustomerID FROM Customers WHERE NIT = @NitCliente";
                using (SqlCommand command = new SqlCommand(query, connection, transaction))  // Pasamos la transacción aquí
                {
                    command.Parameters.AddWithValue("@NitCliente", NitCliente);
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el CustomerID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0; // Manejar el error adecuadamente
            }
        }

        private void LimpiarCarrito()
        {
            flowLayoutPanelCarrito.Controls.Clear();
            totalCarrito = 0;
            lblTotal.Text = $"Q{totalCarrito:F2}";
            NombreCliente = null;
            NitCliente = null;
            lblCliente.Text = "Cliente: ";
            btnPagar.Enabled = false;
        }



        // Método para obtener el CustomerID por el NIT
        private int ObtenerCustomerIDPorNIT(string nit)
        {
            int customerID = 0;
            try
            {
                string query = "SELECT CustomerID FROM jsoberanis_db.Customers WHERE NIT = @NIT";
                //string query = "SELECT CustomerID FROM Customers WHERE NIT = @NIT";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NIT", nit);
                    customerID = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener CustomerID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return customerID;
        }
        private void Ventas_Load(object sender, EventArgs e)
        {
            txtNit.TextChanged += txtNit_TextChanged;
        }

        private void txtNit_TextChanged(object sender, EventArgs e)
        {
            string nit = txtNit.Text.Trim();
            if (string.IsNullOrEmpty(nit)) return;
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "SELECT FirstName, LastName, Phone FROM jsoberanis_db.Customers WHERE NIT = @NIT";
                //string query = "SELECT FirstName, LastName, Phone FROM Customers WHERE NIT = @NIT";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nit", nit);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string name = reader.GetString(0);
                            string lastname = reader.GetString(1);
                            string phone = reader.GetString(2);

                            MessageBox.Show($"Cliente: {name}\nDirección: {lastname}\nApellido: {phone}",
                       "Información del Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró un cliente con este NIT.", "Cliente no encontrado",
                                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al buscar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void TextBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarProductos();
        }

        private void MostrarRecibo(List<CarritoItemCard> itemsCarrito, decimal total)
        {
            List<Product> productos = itemsCarrito.Select(item => new Product
            {
                ProductID = item.ProductID,
                Name = item.ProductName,
                Price = item.Price,
                Stock = item.Cantidad
            }).ToList();

            string nombreCompleto = $"{NombreCliente} {ApellidoCliente}";
            ReciboForm reciboForm = new ReciboForm(itemsCarrito, total, nombreCompleto, NitCliente);
            reciboForm.ShowDialog();
        }

        private void RecargarProductos()
        {
            flowLayoutPanel2.Controls.Clear();
            CargarFlashCards();
        }

        //Metodo para Buscar productos
        private void BuscarProductos()
        {
            {
                string searchValue = textBuscar.Text.Trim();
                if (string.IsNullOrEmpty(searchValue))
                {
                    RecargarProductos(); // Volver a cargar todos los productos si no hay filtro
                    return;
                }

                string query = "SELECT ProductID, Code, Name, Description, Price, Stock, ImagePath FROM jsoberanis_db.Products WHERE Code LIKE @search OR Name LIKE @search";
                //string query = "SELECT ProductID, Code, Name, Description, Price, Stock, ImagePath FROM Products WHERE Code LIKE @search OR Name LIKE @search";

                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    List<Product> productosFiltrados = new List<Product>();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@search", "%" + searchValue + "%");

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
                                productosFiltrados.Add(producto);
                            }
                        }
                    }

                    // Actualizar el flowLayoutPanel1 con los productos filtrados
                    flowLayoutPanel2.Controls.Clear();
                    foreach (Product producto in productosFiltrados)
                    {
                        ProductCard productCard = new ProductCard();
                        productCard.SetProductData(producto);
                        productCard.Width = 198;
                        productCard.Height = 300;

                        // Suscribirse al evento AgregarAlCarritoClicked
                        productCard.AgregarAlCarritoClicked += ProductCard_AgregarAlCarritoClicked;

                        flowLayoutPanel2.Controls.Add(productCard);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al buscar el producto: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void lblCliente_Click(object sender, EventArgs e)
        {

        }

        private Customer ObtenerClientePorNIT(string nit)
        {

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            Customer cliente = null;
            string query = "SELECT CustomerID, FirstName, LastName, Phone FROM jsoberanis_db.Customers WHERE NIT = @NIT";
            //string query = "SELECT CustomerID, FirstName, LastName, Phone FROM Customers WHERE NIT = @NIT";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@NIT", nit);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cliente = new Customer
                        {
                            CustomerID = reader.GetInt32(0),
                            FirstName = reader.GetString(1),
                            LastName = reader.GetString(2),
                            Phone = reader.GetString(3)
                        };
                    }
                }
            }
            return cliente;
        }

        //Evento para validar el NIT
        private void btnNit_Click(object sender, EventArgs e)
        {
            string nit = txtNit.Text.Trim();
            if (string.IsNullOrEmpty(nit))
            {
                MessageBox.Show("Por favor, ingrese un NIT", "NIT Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "SELECT FirstName, LastName, Phone FROM jsoberanis_db.Customers WHERE NIT = @NIT";
                //string query = "SELECT FirstName, LastName, Phone FROM Customers WHERE NIT = @NIT";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nit", nit);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            NombreCliente = reader.GetString(0);
                            ApellidoCliente = reader.GetString(1);
                            NitCliente = nit;

                            lblCliente.Text = $"Cliente: {NombreCliente} {ApellidoCliente}";
                            MessageBox.Show($"Cliente encontrado: {NombreCliente} {ApellidoCliente}", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnEliminar.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("No se encontró un cliente con este NIT.", "Cliente no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al buscar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            txtNit.Clear();
        }

        //Formulario de nuevo cliente
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoCliente nuevoCliente = new NuevoCliente();
            nuevoCliente.ShowDialog();
        }

        //Metodo para Eliminar cliente en el carrito
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            NombreCliente = null;
            ApellidoCliente = null;
            NitCliente = null;

            // Actualizar la etiqueta y deshabilitar el botón
            lblCliente.Text = "Cliente: ";
            btnEliminar.Enabled = false;

            MessageBox.Show("Cliente eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }



}
        
