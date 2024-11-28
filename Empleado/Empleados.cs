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
using System.Windows.Automation.Text;
using System.Windows.Forms;

namespace ProyectoFinalPOS.Empleado
{
    public partial class Empleados : UserControl
    {
        private SqlConnection connection = DatabaseConnections.GetInstance().GetConnection();
        public Empleados()
        {
            InitializeComponent();
            EmployeeCarga();
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            employeesTable.SelectionChanged += EmployeesTable_SelectionChanged;
            // Deshabilitar el botón Actualizar al iniciar
            btnActualizar.Enabled = false;
        }

        private void EmployeeCarga()
        {
            //string query = "SELECT EmployeeID as ID, FirstName as Nombre, LastName as Apellido, IdentificationNumber as Identificación, Position as Position, Username as Usuario FROM jsoberanis_db.Employees";
            string query = "SELECT EmployeeID as ID, FirstName as Nombre, LastName as Apellido, IdentificationNumber as Identificación, Position as Position, Username as Usuario FROM Employees";
            try
            {
                // Asegúrate de que la conexión esté abierta antes de usarla
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                // Llena un DataTable con los datos de la consulta
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, this.connection);
                // Ejecuta la consutla de sql y llena el objeto dataTable
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Asigna el DataTable como fuente de datos del DataGridView
                employeesTable.DataSource = dataTable;
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

        private void GuardarEmpleado()
        {
            if (!ValidarCampos())
            {
                MessageBox.Show("Por favor, verifica que todos los campos sean correctos antes de guardar.");
                return;
            }

            // Consulta para verificar si el Username ya existe
            string checkUsernameQuery = "SELECT COUNT(*) FROM jsoberanis_db.Employees WHERE Username = @Username";
            // Consulta para verificar si el IdentificationNumber ya existe
            string checkIdQuery = "SELECT COUNT(*) FROM jsoberanis_db.Employees WHERE IdentificationNumber = @IdentificationNumber";

            // Consulta para verificar si el Username ya existe
            //string checkUsernameQuery = "SELECT COUNT(*) FROM Employees WHERE Username = @Username";
            // Consulta para verificar si el IdentificationNumber ya existe
            //string checkIdQuery = "SELECT COUNT(*) FROM Employees WHERE IdentificationNumber = @IdentificationNumber";

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                bool usernameExists = false;
                bool idExists = false;

                // Verificamos si el Username ya existe
                using (SqlCommand checkUsernameCommand = new SqlCommand(checkUsernameQuery, connection))
                {
                    checkUsernameCommand.Parameters.AddWithValue("@Username", txtUsername.Text);
                    // Si existe, se asigna true
                    usernameExists = (int)checkUsernameCommand.ExecuteScalar() > 0;
                }

                // Verificamos si el IdentificationNumber ya existe
                using (SqlCommand checkIdCommand = new SqlCommand(checkIdQuery, connection))
                {
                    checkIdCommand.Parameters.AddWithValue("@IdentificationNumber", txtID.Text);
                    // Si existe, se asigna true
                    idExists = (int)checkIdCommand.ExecuteScalar() > 0;
                }

                // Si alguno de los valores existe, mostramos los mensajes correspondientes
                if (usernameExists && idExists)
                {
                    MessageBox.Show("El Username y el IdentificationNumber ya están registrados.");
                    return;
                }
                else if (usernameExists)
                {
                    MessageBox.Show("El Username ya está registrado.");
                    return;
                }
                else if (idExists)
                {
                    MessageBox.Show("El IdentificationNumber ya está registrado.");
                    return;
                }
                // Si no hay duplicados, realizamos la inserción
                string insertQuery = @"
                                    INSERT INTO jsoberanis_db.Employees (FirstName, LastName, IdentificationNumber, Position, Username, PasswordHash) 
                                    VALUES (@FirstName, @LastName, @IdentificationNumber, @Position, @Username, @PasswordHash)";
                // Si no hay duplicados, realizamos la inserción
                //string insertQuery = @"
                //                    INSERT INTO Employees (FirstName, LastName, IdentificationNumber, Position, Username, PasswordHash) 
                //                    VALUES (@FirstName, @LastName, @IdentificationNumber, @Position, @Username, @PasswordHash)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", txtNombre.Text);
                    command.Parameters.AddWithValue("@LastName", txtApellido.Text);
                    command.Parameters.AddWithValue("@IdentificationNumber", txtID.Text);
                    command.Parameters.AddWithValue("@Position", txtPosition.Text);
                    command.Parameters.AddWithValue("@Username", txtUsername.Text);
                    command.Parameters.AddWithValue("@PasswordHash", txtPassword.Text);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Empleado guardado exitosamente.");
                        EmployeeCarga();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el empleado.");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al guardar el empleado: " + ex.Message);
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

            // Validación de Nombre (solo letras y tildes)
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtNombre.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ]+$"))
            {
                MessageBox.Show("El nombre solo debe contener letras");
                return false;
            }

            // Validación de Apellido (solo letras y tildes)
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtApellido.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ]+$"))
            {
                MessageBox.Show("El apellido solo debe contener letras.");
                return false;
            }

            // Validación del ID (máximo 15 dígitos numéricos)
            string idPattern = @"^\d{1,15}$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtID.Text, idPattern))
            {
                MessageBox.Show("El ID debe contener solo números y no más de 15 dígitos.");
                return false;
            }

            // Validación del Position solo letras y tildes)
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtPosition.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ]+$"))
            {
                MessageBox.Show("El apellido solo debe contener letras.");
                return false;
            }

            // Validación de Username (más de 6 caracteres, alfanumérico)
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtUsername.Text, @"^[a-zA-Z0-9]{6,}$"))
            {
                MessageBox.Show("El usuario debe tener al menos 6 caracteres alfanuméricos.");
                return false;
            }

            // Validación de Password (al menos 4 caracteres)
            if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text.Length < 4)
            {
                MessageBox.Show("La contraseña no puede estar vacía y debe tener al menos 4 caracteres.");
                return false;
            }

            return true;
        }


        // Método para cargar los datos del cliente seleccionado
        private void EmployeesTable_SelectionChanged(object sender, EventArgs e)
        {
            if (employeesTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = employeesTable.SelectedRows[0];
                txtNombre.Text = selectedRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = selectedRow.Cells["Apellido"].Value.ToString();
                txtID.Text = selectedRow.Cells["ID"].Value.ToString();
                txtPosition.Text = selectedRow.Cells["Position"].Value.ToString();
                txtUsername.Text = selectedRow.Cells["Usuario"].Value.ToString();
                //txtPassword.Text = selectedRow.Cells["Contraseña"].Value.ToString();

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
        private void ActualizarEmpleados()
        {
            if (employeesTable.SelectedRows.Count > 0)
            {
                int employeeId = Convert.ToInt32(employeesTable.SelectedRows[0].Cells["ID"].Value);
                string query = "UPDATE jsoberanis_db.Employees SET FirstName = @FirstName, LastName = @LastName, IdentificationNumber = @IdentificationNumber, Position = @Position, Username = @Username, PasswordHash = @PasswordHash WHERE EmployeeID = @EmployeeID";
                //string query = "UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, IdentificationNumber = @IdentificationNumber, Position = @Position, Username = @Username, PasswordHash = @PasswordHash WHERE EmployeeID = @EmployeeID";

                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", employeeId);
                        command.Parameters.AddWithValue("@FirstName", txtNombre.Text);
                        command.Parameters.AddWithValue("@LastName", txtApellido.Text);
                        command.Parameters.AddWithValue("@IdentificationNumber", txtID.Text);
                        command.Parameters.AddWithValue("@Position", txtPosition.Text);
                        command.Parameters.AddWithValue("@Username", txtUsername.Text);
                        command.Parameters.AddWithValue("@PasswordHash", txtPassword.Text);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Empleado actualizado exitosamente.");
                            EmployeeCarga();
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar el empleado.");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al actualizar el empleado: " + ex.Message);
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
        private void EliminarEmpleado()
        {
            if (employeesTable.SelectedRows.Count > 0)
            {
                int employeeId = Convert.ToInt32(employeesTable.SelectedRows[0].Cells["ID"].Value);

                // Mostrar un cuadro de diálogo de confirmación
                var confirmacion = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar este empleado?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                // Procede con la eliminación solo si el usuario confirma con "Sí"
                if (confirmacion == DialogResult.Yes)
                {
                    string query = "DELETE FROM jsoberanis_db.Employees WHERE EmployeeID = @EmployeeID";
                    //string query = "DELETE FROM Employees WHERE EmployeeID = @EmployeeID";

                    try
                    {
                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@EmployeeID", employeeId);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Empleado eliminado exitosamente.");
                                EmployeeCarga();
                                LimpiarCampos();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo eliminar el empleado.");
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error al eliminar el empleado: " + ex.Message);
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
                MessageBox.Show("Por favor, selecciona un empleado para eliminar.");
            }
        }

        // Método para buscar empleado por ID o nombre
        private void BuscarEmpleado()
        {
            // Eliminar espacios en blanco alrededor del texto
            string searchValue = txtBuscar.Text.Trim();

            // Si el campo de búsqueda está vacío, carga todos los clientes
            if (string.IsNullOrWhiteSpace(searchValue))
            {
                EmployeeCarga();
                return;
            }

            // Si hay texto en el campo, realiza la búsqueda
            string query = "SELECT EmployeeID as ID, IdentificationNumber as [No. de Identificador],Position as Cargo, FirstName as Nombre, LastName as Apellido, Username as Usuario FROM jsoberanis_db.Employees WHERE IdentificationNumber LIKE @search OR FirstName LIKE @search OR Username LIKE @search";
            //string query = "SELECT EmployeeID as ID, IdentificationNumber as [No. de Identificador] ,Position as Cargo, FirstName as Nombre, LastName as Apellido, Username as Usuario FROM Employees WHERE IdentificationNumber LIKE @search OR FirstName LIKE @search OR Username LIKE @search;";

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

                    employeesTable.DataSource = dataTable;
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
            BuscarEmpleado(); // Llama al método de búsqueda cada vez que el texto cambia
        }


        // Método para limpiar los campos de texto
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtID.Text = "";
            txtPosition.Text = "";
            txtApellido.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            employeesTable.ClearSelection();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarEmpleado();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarEmpleados();
        }

        private void btnLimiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarEmpleado();
        }
    }
}
