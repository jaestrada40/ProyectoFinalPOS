using Microsoft.Data.SqlClient;
using ProyectoFinalPOS.DBconexion;
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

namespace ProyectoFinalPOS.Productos
{
    public partial class Productos : UserControl
    {
        private SqlConnection connection = DatabaseConnections.GetInstance().GetConnection();
        public Productos()
        {
            InitializeComponent();
            ProductosCarga();
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            productsTable.SelectionChanged += ProductsTable_SelectionChanged;

        }

        private void ProductosCarga()
        {
            string query = "SELECT ProductID as ID, Code as Código, Name as Nombre, Description as Descripción, Price as Precio, Stock, ImagePath FROM jsoberanis_db.Products";
            //string query = "SELECT ProductID as ID, Code as Código, Name as Nombre, Description as Descripción, Price as Precio, Stock, ImagePath as Imagen FROM Products";
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
                productsTable.DataSource = dataTable;
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

        // Metodo para limpiar todos los campos
        private void LimpiarCampos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtBuscar.Text = "";
            txtImagePath.Text = "";
        }

        // Metodo para guardar productos en base de datos
        private void GuardarProducto()
        {
            string query = "INSERT INTO jsoberanis_db.Products (Code, Name, Description, Price, Stock, ImagePath) VALUES (@Code, @Name, @Description, @Price, @Stock, @ImagePath)";
            //string query = "INSERT INTO Products (Code, Name, Description, Price, Stock, ImagePath) VALUES (@Code, @Name, @Description, @Price, @Stock, @ImagePath)";

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Code", txtCodigo.Text);
                    command.Parameters.AddWithValue("@Name", txtNombre.Text);
                    command.Parameters.AddWithValue("@Description", txtDescripcion.Text);
                    command.Parameters.AddWithValue("@Price", txtPrecio.Text);
                    command.Parameters.AddWithValue("@Stock", txtStock.Text);
                    command.Parameters.AddWithValue("@ImagePath", txtStock.Text);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Producto Guardado exitosamente.");
                        ProductosCarga();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el producto.");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al guardar el producto: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

            }
        }

        private void ProductsTable_SelectionChanged(object sender, EventArgs e)
        {
            if (productsTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = productsTable.SelectedRows[0];

                txtCodigo.Text = selectedRow.Cells["Código"].Value.ToString();
                txtNombre.Text = selectedRow.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = selectedRow.Cells["Descripción"].Value.ToString();
                txtPrecio.Text = selectedRow.Cells["Precio"].Value.ToString();
                txtStock.Text = selectedRow.Cells["Stock"].Value.ToString();
                txtImagePath.Text = selectedRow.Cells["ImagePath"].Value.ToString();

                string imagePath = selectedRow.Cells["ImagePath"].Value.ToString();
                if (File.Exists(imagePath))
                {
                    pictureBoxProducto.Image = Image.FromFile(imagePath);
                }
                else
                {
                    pictureBoxProducto.Image = null;
                }

            }
        }
        // Metodo para Actualizar los productos
        private void ActualizarProducto()
        {
            if (productsTable.SelectedRows.Count > 0)
            {
                int productId = Convert.ToInt32(productsTable.SelectedRows[0].Cells["ID"].Value);
                string query = "UPDATE jsoberanis_db.Products SET Code = @Code, Name = @Name, Description = @Description, Price = @Price, Stock = @Stock, ImagePath = @ImagePath WHERE ProductID = @ProductID";
                //string query = "INSERT INTO Products (Code, Name, Description, Price, Stock, ImagePath) VALUES (@Code, @Name, @Description, @Price, @Stock, @ImagePath)";

                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProductID", productId);
                        command.Parameters.AddWithValue("@Code", txtCodigo.Text);
                        command.Parameters.AddWithValue("@Name", txtNombre.Text);
                        command.Parameters.AddWithValue("@Description", txtDescripcion.Text);
                        command.Parameters.AddWithValue("@Price", txtPrecio.Text);
                        command.Parameters.AddWithValue("@Stock", txtStock.Text);
                        command.Parameters.AddWithValue("@ImagePath", txtImagePath.Text);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Producto actualizado exitosamente.");
                            ProductosCarga();
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar el producto");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al actualizar el producto: " + ex.Message);
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

        private void BuscarProducto()
        {
            string searchValue = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(searchValue))
            {
                ProductosCarga();
                return;
            }

            string query = "SELECT ProductID as ID, Code, Name as Nombre, Description as Descripcion, Price as Precio, Stock as Stock FROM jsoberanis_db.Products WHERE Code LIKE @search OR Name LIKE @search ";

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

                    productsTable.DataSource = dataTable;
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


        //Metodo para Eliminar productos
        private void EliminarProducto()
        {
            int productId = Convert.ToInt32(productsTable.SelectedRows[0].Cells["ID"].Value);

            string query = "DELETE FROM jsoberanis_db.Products WHERE ProductID = @ProductID";

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductID", productId);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Producto eliminado exitosamente.");
                        ProductosCarga();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el producto.");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message);
            }
            //finally
            //{
            //    if (connection.State == ConnectionState.Open)
            //    {
            //        connection.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Por favor, selecciona un producto para eliminar.");
            //    }
            //}
        }


        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarProducto();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarProducto();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarProducto();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarProducto();
        }
    }
}
