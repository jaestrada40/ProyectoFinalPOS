using Microsoft.Data.SqlClient;
using ProyectoFinalPOS.DBconexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalPOS
{
    public partial class FormSigUp : Form
    {

        private SqlConnection connection = DatabaseConnections.GetInstance().GetConnection();
        public FormSigUp()
        {
            InitializeComponent();
            this.ActiveControl = txtNombre;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            FormLogIn loginForm = new FormLogIn();
            loginForm.ShowDialog();
            this.Hide();
        }


        private void RegistrarEmpleado()
        {
            // Validación para comprobar que todos los campos estén llenos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtIdentificador.Text) ||
                string.IsNullOrWhiteSpace(txtPosition.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Encriptar la contraseña antes de guardarla
            string hashedPassword = PasswordHelper.HashPassword(txtContraseña.Text);

            // Consulta SQL para insertar un nuevo empleado
            //string query = "INSERT INTO jsoberanis_db.Employees (FirstName, LastName, IdentificationNumber, Position, Username, PasswordHash) " +
            //               "VALUES (@FirstName, @LastName, @IdentificationNumber, @Position, @Username, @PasswordHash)";
            string query = "INSERT INTO Employees (FirstName, LastName, IdentificationNumber, Position, Username, PasswordHash) " +
               "VALUES (@FirstName, @LastName, @IdentificationNumber, @Position, @Username, @PasswordHash)";

            try
            {
                // Abrir la conexión si está cerrada
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Asignar valores a los parámetros
                    command.Parameters.AddWithValue("@FirstName", txtNombre.Text);
                    command.Parameters.AddWithValue("@LastName", txtApellido.Text);
                    command.Parameters.AddWithValue("@IdentificationNumber", txtIdentificador.Text);
                    command.Parameters.AddWithValue("@Position", txtPosition.Text);
                    command.Parameters.AddWithValue("@Username", txtUsuario.Text);
                    // Guardar el hash de la contraseña
                    command.Parameters.AddWithValue("@PasswordHash", hashedPassword); 

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Empleado registrado exitosamente.");
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar el empleado.");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al registrar el empleado: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión si está abierta
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        // Método para limpiar los campos después de guardar
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtIdentificador.Text = "";
            txtPosition.Text = "";
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }

        private void btnRegistrase_Click(object sender, EventArgs e)
        {
            RegistrarEmpleado();
        }

        private void chkVerContraseña_CheckedChanged(object sender, EventArgs e)
        {
            // Es un operador ternario que evalúa si chkVerContraseña.Checked es true o false.
            txtContraseña.PasswordChar = chkVerContraseña.Checked ? '\0' : '*';
        }
        public class PasswordHelper
        {
            // Método para generar un hash de la contraseña usando SHA256
            public static string HashPassword(string password)
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                    // Devuelve el hash en formato hexadecimal
                    return BitConverter.ToString(bytes).Replace("-", "").ToLower(); 
                }
            }
        }
    }
}
