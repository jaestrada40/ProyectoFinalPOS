namespace ProyectoFinalPOS
{
    public partial class FormLogIn : Form
    {

        public FormLogIn()
        {
            InitializeComponent();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            Form MenuPrincipal = new MenuPrincipal();
            this.Hide();
            MenuPrincipal.ShowDialog();
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
