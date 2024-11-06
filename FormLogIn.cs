using Microsoft.Data.SqlClient;
using ProyectoFinalPOS.DBconexion;
using System.Data;

namespace ProyectoFinalPOS
{
    public partial class FormLogIn : Form
    {
        private SqlConnection connection = DatabaseConnections.GetInstance().GetConnection();

        public FormLogIn()
        {
            InitializeComponent();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            string username = textBoxUsuario.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            // Validación de campos vacíos
            // if (username == null || username == "" || password == null || password == "")
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

        private bool ValidarCredenciales(string username, string password)
        {
            string query = "SELECT COUNT(1) FROM Employees WHERE Username = @Username AND PasswordHash = @PasswordHash";
            bool esValido = false;

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar los parámetros para la consulta
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@PasswordHash", password); // Asegúrate de que el password esté encriptado si la base de datos así lo requiere

                    // Ejecutar la consulta
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    esValido = (count == 1);
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
    }
}
