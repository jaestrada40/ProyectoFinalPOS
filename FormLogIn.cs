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

            // Validaci�n de campos vac�os
            // if (username == null || username == "" || password == null || password == "")
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, ingrese el usuario y la contrase�a.", "Campos vac�os", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar credenciales
            if (ValidarCredenciales(username, password))
            {
                // Si las credenciales son correctas, abre el men� principal
                Form menuPrincipal = new MenuPrincipal();
                this.Hide();
                menuPrincipal.ShowDialog();
                this.Close();
            }
            else
            {
                // Si las credenciales son incorrectas, muestra un mensaje de error
                MessageBox.Show("Usuario o contrase�a incorrectos", "Error de inicio de sesi�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    // Agregar los par�metros para la consulta
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@PasswordHash", password); // Aseg�rate de que el password est� encriptado si la base de datos as� lo requiere

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

        private void chkVerContrase�a_CheckedChanged(object sender, EventArgs e)
        {
            // Es un operador ternario que eval�a si chkVerContrase�a.Checked es true o false.
            textBoxPassword.PasswordChar = chkVerContrase�a.Checked ? '\0' : '*';
        }
    }
}
