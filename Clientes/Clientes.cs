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
        }

        // Método para cargar los datos en el DataGridView
        private void CustomersCarga()
        {
            //string query = "SELECT CustomerID as ID, NIT, FirstName as Nombre, LastName as Apellido, Address as Dirección, Phone as Teléfono FROM jsoberanis_db.Customers";
            string query = "SELECT CustomerID as ID, NIT, FirstName as Nombre, LastName as Apellido, Address as Dirección, Phone as Teléfono FROM Customers";
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
            //string query = "INSERT INTO jsoberanis_db.Customers (NIT, FirstName, LastName, Address, Phone) VALUES (@NIT, @FirstName, @LastName, @Address, @Phone)";
            string query = "INSERT INTO Customers (NIT, FirstName, LastName, Address, Phone) VALUES (@NIT, @FirstName, @LastName, @Address, @Phone)";

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
            }
        }

        // Método para actualizar los datos de un cliente en la base de datos
        private void ActualizarCliente()
        {
            if (customersTable.SelectedRows.Count > 0)
            {
                int customerId = Convert.ToInt32(customersTable.SelectedRows[0].Cells["ID"].Value);
                //string query = "UPDATE jsoberanis_db.Customers SET NIT = @NIT, FirstName = @FirstName, LastName = @LastName, Address = @Address, Phone = @Phone WHERE CustomerID = @CustomerID";
                string query = "UPDATE Customers SET NIT = @NIT, FirstName = @FirstName, LastName = @LastName, Address = @Address, Phone = @Phone WHERE CustomerID = @CustomerID";

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
            //string query = "SELECT CustomerID as ID, NIT, FirstName as Nombre, LastName as Apellido, Address as Dirección, Phone as Teléfono FROM jsoberanis_db.Customers WHERE NIT LIKE @search OR FirstName LIKE @search";
            string query = "SELECT CustomerID as ID, NIT, FirstName as Nombre, LastName as Apellido, Address as Dirección, Phone as Teléfono FROM Customers WHERE NIT LIKE @search OR FirstName LIKE @search";

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

                string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";

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
            BuscarCliente(); // Llama al método de búsqueda cada vez que el texto cambia
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
