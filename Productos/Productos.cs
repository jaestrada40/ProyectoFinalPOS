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
using System.Net.Http;
using System.Threading.Tasks;

namespace ProyectoFinalPOS.Productos
{
    public partial class Productos : UserControl
    {
        private SqlConnection connection = DatabaseConnections.GetInstance().GetConnection();
        public Productos()
        {
            InitializeComponent();
            ProductosCarga();

           ResetBotones();

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

                //Ocultar columna de imagePath en DataGrid
                if (productsTable.Columns["ImagePath"] != null)
                {
                    productsTable.Columns["ImagePath"].Visible = false;
                }
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
            pictureBoxProducto.Image = null;
        }

        // Metodo para guardar productos en base de datos
        private void GuardarProducto()
        {
            string query = "INSERT INTO jsoberanis_db.Products (Code, Name, Description, Price, Stock, ImagePath) VALUES (@Code, @Name, @Description, @Price, @Stock, @ImagePath)";
            //string query = "INSERT INTO Products (Code, Name, Description, Price, Stock, ImagePath) VALUES (@Code, @Name, @Description, @Price, @Stock, @ImagePath)";

            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text) ||
                string.IsNullOrWhiteSpace(txtImagePath.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
                    command.Parameters.AddWithValue("@ImagePath", txtImagePath.Text);

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
                btnGuardar.Enabled = false;
                btnGuardar.ForeColor = Color.Gray;
                btnActualizar.Enabled = true;
                btnActualizar.ForeColor = Color.White;
            }
            else
            {
                ResetBotones();
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
            if (productsTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por Favor, seleccione un producto para eliminar.", "Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Cuadro de dialogo para confirmacion
            DialogResult confirmResult = MessageBox.Show(
                "¿Está seguro de que desea eliminar este producto?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
        );

            //Si el usuario selecciona no, cancela
            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

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
           // LimpiarCampos();
            ResetBotones();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarProducto();
            LimpiarCampos();
            ResetBotones();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarProducto();
            LimpiarCampos();
            ResetBotones();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            ResetBotones();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private async void btnImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    string imageUrl = await SubirImagenAImgur(filePath);

                    txtImagePath.Text = openFileDialog.FileName;
                    pictureBoxProducto.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void ResetBotones()
        {
            productsTable.ClearSelection();

            btnGuardar.Enabled = true;
            btnGuardar.ForeColor = Color.White;
            btnActualizar.Enabled = false;
            btnActualizar.ForeColor = SystemColors.Control;
        }


        //Subir imagenes a Imgur
        private async Task<string> SubirImagenAImgur(string filePath)
        {
            string acessToken = "93b781ab9d19380d53d8401946e94c31296f2bb6";
            string uploadUrl = "https://api.imgur.com/3/image";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", acessToken);
                    using (MultipartFormDataContent form = new MultipartFormDataContent())
                    {
                        // para leer el archivo y agregarlo al formulario
                        byte[] imageData = File.ReadAllBytes(filePath);
                        form.Add(new ByteArrayContent(imageData, 0, imageData.Length), "image", Path.GetFileName(filePath));

                        //Enviar la solicitud POST
                        HttpResponseMessage response = await client.PostAsync(uploadUrl, form);
                        response.EnsureSuccessStatusCode();

                        //leer la respuesta como JSON
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        dynamic jsonObject = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonResponse);

                        //retornar el enlace directo de la imagen
                        return jsonObject.data.link.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al subir la imagen: {ex.Message}");
                return null;
            }
        }
           
    }
}
