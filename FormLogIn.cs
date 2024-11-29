using Microsoft.Data.SqlClient;
using ProyectoFinalPOS.DBconexion;
using ProyectoFinalPOS.Objects;
using System.Data;
using static ProyectoFinalPOS.FormSigUp;

namespace ProyectoFinalPOS
{
    public partial class FormLogIn : Form
    {
        private SqlConnection connection = DatabaseConnections.GetInstance().GetConnection();

        public FormLogIn()
        {
            InitializeComponent();
            textBoxPassword.KeyDown += textBoxPassword_KeyDown;
            textBoxUsuario.KeyDown += textBoxUsuario_KeyDown;
            this.AcceptButton = buttonIngresar;
            this.ActiveControl = textBoxUsuario;
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            string username = textBoxUsuario.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            // Validación de campos vacíos
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, ingrese el usuario y la contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar credenciales
            if (ValidarCredenciales(username, password))
            {
                // Si las credenciales son correctas, abre el menú principal
                Form menuPrincipal = new MenuPrincipal();
                this.Hide();
                menuPrincipal.ShowDialog();
                this.Close();
            }
            else
            {
                // Si las credenciales son incorrectas, muestra un mensaje de error
                MessageBox.Show("Usuario o contraseña incorrectos", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                buttonIngresar_Click(sender, e);
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                buttonIngresar_Click(sender, e);
            }
        }

        private bool ValidarCredenciales(string username, string password)
        {
            //string query =  "SELECT EmployeeID, Username, FirstName, PasswordHash FROM jsoberanis_db.Employees WHERE Username = @Username";
            string query = "SELECT EmployeeID, Username, FirstName, PasswordHash FROM Employees WHERE Username = @Username";
            bool esValido = false;

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedPasswordHash = reader.GetString(3); // Obtener el hash de la contraseña almacenado en la base de datos

                            // Compara el hash de la contraseña ingresada con el hash almacenado
                            if (VerifyPassword(password, storedPasswordHash))
                            {
                                // Asignar los valores de EmployeeID, Username y FirstName
                                int employeeID = reader.GetInt32(0);
                                string usernameFromDb = reader.GetString(1);
                                string firstName = reader.GetString(2);

                                Global.EmployeeID = employeeID;
                                Global.Username = usernameFromDb;
                                Global.FirstName = firstName;

                                esValido = true;
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return esValido;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            FormSigUp formSigUp = new FormSigUp();
            formSigUp.ShowDialog();
            this.Hide();
        }

        private void chkVerContraseña_CheckedChanged(object sender, EventArgs e)
        {
            // Es un operador ternario que evalúa si chkVerContraseña.Checked es true o false.
            textBoxPassword.PasswordChar = chkVerContraseña.Checked ? '\0' : '*';
        }

        private bool VerifyPassword(string enteredPassword, string storedPasswordHash)
        {
            // Encriptar la contraseña ingresada y comparar con el hash almacenado
            string enteredPasswordHash = PasswordHelper.HashPassword(enteredPassword);
            return enteredPasswordHash == storedPasswordHash;
        }
    }
}
