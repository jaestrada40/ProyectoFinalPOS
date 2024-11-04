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
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form MenuMantenimiento = new MenuMantenimiento();
            MenuMantenimiento.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Form MenuVentas = new MenuVentas();
            MenuVentas.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            ventas1.Visible = false;
            productos1.Visible = false;
            clientes1.Visible = false;
            empleados1.Visible = false;
        }

        private void btnVentas_Click_1(object sender, EventArgs e)
        {
            ventas1.Visible = true;
            dashboard1.Visible = false;
            productos1.Visible = false;
            clientes1.Visible = false;
            empleados1.Visible = false;
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            productos1.Visible = true;
            dashboard1.Visible = false;
            ventas1.Visible = false;
            clientes1.Visible = false;
            empleados1.Visible = false;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            clientes1.Visible = true;
            dashboard1.Visible = false;
            ventas1.Visible = false;
            productos1.Visible = false;
            empleados1.Visible = false;

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            empleados1.Visible = true;
            dashboard1.Visible = false;
            ventas1.Visible = false;
            productos1.Visible = false;
            clientes1.Visible = false;
        }
    }
}
