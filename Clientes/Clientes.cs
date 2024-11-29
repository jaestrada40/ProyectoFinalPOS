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
            // Deshabilitar el botón Actualizar al iniciar
            btnActualizar.Enabled = false;
        }

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
                // Ejecuta la consutla de sql y llena el objeto dataTable
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

        // Método para guardar un nuevo cliente en la base de datos
        private void GuardarCliente()
        {
            // Validación de campos antes de proceder
            if (!ValidarCampos())
            {
                return; // Si la validación falla, no procedemos con el guardado
            }

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
                        CustomersCarga();
                        LimpiarCampos();
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
            // Validación de NIT (no puede estar vacío)
            if (string.IsNullOrWhiteSpace(txtNIT.Text))
            {
                MessageBox.Show("El NIT no puede estar vacío.");
                return false;
            }

            // Validación del formato del NIT (de 6 a 8 dígitos seguidos de un guion y luego un dígito o 'K')
            string nitPattern = @"^\d{6,8}[0-9K]$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtNIT.Text, nitPattern))
            {
                MessageBox.Show("El NIT debe estar en un formato válido (ej: 121567K, 3567891, 48086370).");
                return false;
            }

            // Verificar que el NIT no esté duplicado
            if (EsNitDuplicado(txtNIT.Text))
            {
                MessageBox.Show("Este NIT ya está registrado.");
                return false;
            }

            // Validación de Nombre (no puede estar vacío y solo puede contener letras)
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtNombre.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ]+$"))
            {
                MessageBox.Show("El nombre solo debe contener letras.");
                return false;
            }

            // Validación de Apellido (no puede estar vacío y solo puede contener letras)
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El apellido no puede estar vacío.");
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtApellido.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ]+$"))
            {
                MessageBox.Show("El apellido solo debe contener letras.");
                return false;
            }

            // Validación de Dirección (no puede estar vacía)
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("La dirección no puede estar vacía.");
                return false;
            }

            // Validación de Teléfono: si no está vacío, debe contener exactamente 8 dígitos
            if (!string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtTelefono.Text, @"^\d{8}$"))
                {
                    MessageBox.Show("El teléfono debe contener exactamente 8 dígitos.");
                    return false;
                }
            }

            return true;
        }

        // Método para verificar si el NIT ya está registrado en la base de datos
        private bool EsNitDuplicado(string nit)
        {
            string query = "SELECT COUNT(*) FROM jsoberanis_db.Customers WHERE NIT = @NIT";
            //string query = "SELECT COUNT(*) FROM Customers WHERE NIT = @NIT";

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

                    // Si hay algún registro con el NIT, significa que está duplicado
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

        // Método para cargar los datos del cliente seleccionado
        private void CustomersTable_SelectionChanged(object sender, EventArgs e)
        {
            if (customersTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = customersTable.SelectedRows[0];
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
            // Validación de campos antes de proceder
            if (!ValidarCampos())
            {
                return; // Si la validación falla, no procedemos con el guardado
            }
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



        // Método para buscar clientes por NIT o nombre
        private void BuscarCliente()
        {
            // Eliminar espacios en blanco alrededor del texto
            string searchValue = txtBuscar.Text.Trim();

            // Si el campo de búsqueda está vacío, carga todos los clientes
            if (string.IsNullOrWhiteSpace(searchValue))
            {
                CustomersCarga();
                return;
            }

            // Si hay texto en el campo, realiza la búsqueda
            string query = "SELECT CustomerID as ID, NIT, FirstName as Nombre, LastName as Apellido, Address as Dirección, Phone as Teléfono FROM jsoberanis_db.Customers WHERE NIT LIKE @search OR FirstName LIKE @search";
            //string query = "SELECT CustomerID as ID, NIT, FirstName as Nombre, LastName as Apellido, Address as Dirección, Phone as Teléfono FROM Customers WHERE NIT LIKE @search OR FirstName LIKE @search";

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

                    customersTable.DataSource = dataTable;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al buscar el cliente: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        // Método para eliminar un cliente seleccionado
        private void EliminarCliente()
        {
            if (customersTable.SelectedRows.Count > 0)
            {
                int customerId = Convert.ToInt32(customersTable.SelectedRows[0].Cells["ID"].Value);

                // Mostrar un cuadro de diálogo de confirmación
                var confirmacion = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar este cliente?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                // Procede con la eliminación solo si el usuario confirma con "Sí"
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
                                CustomersCarga();
                                LimpiarCampos();
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

        // Método para limpiar los campos de texto
        private void LimpiarCampos()
        {
            txtNIT.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            customersTable.ClearSelection();
        }

        // Evento para el botón de guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarCliente();
        }

        // Evento para el botón de eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarCliente();
        }

        // Evento para el botón de buscar
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarCliente(); 
        }

        // Evento para el botón de actualizar
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarCliente();
        }

        private void btnLimiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

    }
}
