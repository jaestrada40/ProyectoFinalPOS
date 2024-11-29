using Microsoft.Data.SqlClient;
using ProyectoFinalPOS.DBconexion;
using ProyectoFinalPOS.Objects;
using System;
using System.Data;
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
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            customersTable.SelectionChanged += CustomersTable_SelectionChanged;
            btnActualizar.Enabled = false; // Deshabilitar el botón de Actualizar al iniciar
        }

        #region Métodos de Carga y Manejo de Datos

        // Método para cargar los datos en el DataGridView
        private void CustomersCarga()
        {
            string query = "SELECT CustomerID as ID, NIT, FirstName as Nombre, LastName as Apellido, Address as Dirección, Phone as Teléfono FROM jsoberanis_db.Customers";
            //string query = "SELECT CustomerID as ID, NIT, FirstName as Nombre, LastName as Apellido, Address as Dirección, Phone as Teléfono FROM Customers";
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, this.connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                customersTable.DataSource = dataTable;
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

        #endregion

        #region Métodos de Validación y Guardado

        // Método para guardar un nuevo cliente en la base de datos
        private void GuardarCliente()
        {
            // Validación de campos antes de proceder
            if (!ValidarCampos()) return;

            string query = "INSERT INTO jsoberanis_db.Customers (NIT, FirstName, LastName, Address, Phone) VALUES (@NIT, @FirstName, @LastName, @Address, @Phone)";
            //string query = "INSERT INTO Customers (NIT, FirstName, LastName, Address, Phone) VALUES (@NIT, @FirstName, @LastName, @Address, @Phone)";
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NIT", txtNIT.Text);
                    command.Parameters.AddWithValue("@FirstName", txtNombre.Text);
                    command.Parameters.AddWithValue("@LastName", txtApellido.Text);
                    command.Parameters.AddWithValue("@Address", txtDireccion.Text);
                    command.Parameters.AddWithValue("@Phone", txtTelefono.Text);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cliente guardado exitosamente.");
                        CustomersCarga(); // Recargar datos
                        LimpiarCampos(); // Limpiar campos
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el cliente.");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al guardar el cliente: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        // Método para validar los campos antes de guardar
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNIT.Text) || !System.Text.RegularExpressions.Regex.IsMatch(txtNIT.Text, @"^\d{6,8}[0-9K]$"))
            {
                MessageBox.Show("El NIT no es válido.");
                return false;
            }
            if (EsNitDuplicado(txtNIT.Text))
            {
                MessageBox.Show("Este NIT ya está registrado.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || !System.Text.RegularExpressions.Regex.IsMatch(txtNombre.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ]+$"))
            {
                MessageBox.Show("El nombre no es válido.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtApellido.Text) || !System.Text.RegularExpressions.Regex.IsMatch(txtApellido.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ]+$"))
            {
                MessageBox.Show("El apellido no es válido.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("La dirección no puede estar vacía.");
                return false;
            }
            if (!string.IsNullOrWhiteSpace(txtTelefono.Text) && !System.Text.RegularExpressions.Regex.IsMatch(txtTelefono.Text, @"^\d{8}$"))
            {
                MessageBox.Show("El teléfono debe contener exactamente 8 dígitos.");
                return false;
            }
            return true;
        }

        // Método para verificar si el NIT ya está registrado en la base de datos
        private bool EsNitDuplicado(string nit)
        {
            //string query = "SELECT COUNT(*) FROM jsoberanis_db.Customers WHERE NIT = @NIT";
            string query = "SELECT COUNT(*) FROM Customers WHERE NIT = @NIT";
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NIT", nit);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al verificar el NIT: " + ex.Message);
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        #endregion

        #region Métodos de Selección, Actualización y Eliminación

        // Método para cargar los datos del cliente seleccionado
        private void CustomersTable_SelectionChanged(object sender, EventArgs e)
        {
            if (customersTable.SelectedRows.Count > 0)
            {
                var selectedRow = customersTable.SelectedRows[0];
                txtNIT.Text = selectedRow.Cells["NIT"].Value.ToString();
                txtNombre.Text = selectedRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = selectedRow.Cells["Apellido"].Value.ToString();
                txtDireccion.Text = selectedRow.Cells["Dirección"].Value.ToString();
                txtTelefono.Text = selectedRow.Cells["Teléfono"].Value.ToString();

                // Deshabilitar el botón Guardar y habilitar Actualizar
                btnGuardar.Enabled = false;
                btnActualizar.Enabled = true;
            }
            else
            {
                // Habilitar el botón Guardar y deshabilitar Actualizar si no hay selección
                btnGuardar.Enabled = true;
                btnActualizar.Enabled = false;
            }
        }

        // Método para actualizar los datos de un cliente en la base de datos
        private void ActualizarCliente()
        {
            if (!ValidarCampos()) return;

            if (customersTable.SelectedRows.Count > 0)
            {
                int customerId = Convert.ToInt32(customersTable.SelectedRows[0].Cells["ID"].Value);
                string query = "UPDATE jsoberanis_db.Customers SET NIT = @NIT, FirstName = @FirstName, LastName = @LastName, Address = @Address, Phone = @Phone WHERE CustomerID = @CustomerID";
                //string query = "UPDATE Customers SET NIT = @NIT, FirstName = @FirstName, LastName = @LastName, Address = @Address, Phone = @Phone WHERE CustomerID = @CustomerID";
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", customerId);
                        command.Parameters.AddWithValue("@NIT", txtNIT.Text);
                        command.Parameters.AddWithValue("@FirstName", txtNombre.Text);
                        command.Parameters.AddWithValue("@LastName", txtApellido.Text);
                        command.Parameters.AddWithValue("@Address", txtDireccion.Text);
                        command.Parameters.AddWithValue("@Phone", txtTelefono.Text);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cliente actualizado exitosamente.");
                            CustomersCarga();
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar el cliente.");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al actualizar el cliente: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente para actualizar.");
            }
        }

        // Método para eliminar un cliente seleccionado
        private void EliminarCliente()
        {
            if (customersTable.SelectedRows.Count > 0)
            {
                int customerId = Convert.ToInt32(customersTable.SelectedRows[0].Cells["ID"].Value);

                var confirmacion = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar este cliente?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmacion == DialogResult.Yes)
                {
                    string query = "DELETE FROM jsoberanis_db.Customers WHERE CustomerID = @CustomerID";
                    //string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";
                    try
                    {
                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@CustomerID", customerId);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cliente eliminado exitosamente.");
                                CustomersCarga(); // Recargar los datos
                                LimpiarCampos(); // Limpiar los campos
                            }
                            else
                            {
                                MessageBox.Show("No se pudo eliminar el cliente.");
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error al eliminar el cliente: " + ex.Message);
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
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente para eliminar.");
            }
        }

        #endregion

        #region Métodos Auxiliares

        // Método para limpiar los campos del formulario
        private void LimpiarCampos()
        {
            txtNIT.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            btnGuardar.Enabled = true;
            btnActualizar.Enabled = false;
        }

        #endregion

        #region Búsqueda

        // Método para filtrar clientes según la búsqueda en tiempo real
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT CustomerID as ID, NIT, FirstName as Nombre, LastName as Apellido, Address as Dirección, Phone as Teléfono FROM jsoberanis_db.Customers WHERE FirstName LIKE @search OR LastName LIKE @search OR NIT LIKE @search";
            //string query = "SELECT CustomerID as ID, NIT, FirstName as Nombre, LastName as Apellido, Address as Dirección, Phone as Teléfono FROM Customers WHERE FirstName LIKE @search OR LastName LIKE @search OR NIT LIKE @search";

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@search", "%" + txtBuscar.Text + "%");
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                customersTable.DataSource = dataTable;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al buscar clientes: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        #endregion
    }
}
