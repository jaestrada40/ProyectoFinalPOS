using ProyectoFinalPOS.Objects;
using ProyectoFinalPOS.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalPOS
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            dashboard1 = new Dashboard();
            addUserControl(dashboard1);

            // Mostrar el nombre completo (FirstName + Username)
            lblNombre.Text = $"Bienvenido, {Global.FirstName}";
            lblUsuario.Text = $"Usuario: {Global.Username}";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form MenuMantenimiento = new MenuMantenimiento();
            MenuMantenimiento.Show();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            dashboard1 = new Dashboard();
            addUserControl(dashboard1);
        }

        private void btnVentas_Click_1(object sender, EventArgs e)
        {
            ventas1 = new Ventas.Ventas();
            addUserControl(ventas1);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            productos1 = new Productos.Productos();
            addUserControl(productos1);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            clientes1 = new Clientes.Clientes();
            addUserControl(clientes1);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            empleados1 = new Empleado.Empleados();
            addUserControl(empleados1);
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas cerrar sesión?",
                                                  "Cerrar sesión",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                FormLogIn formLogIn = new FormLogIn();
                formLogIn.Show();
                this.Close();
            }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            historial1 = new Historial.Historial();
            addUserControl(historial1);
        }
    }
}
