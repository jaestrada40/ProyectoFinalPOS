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
    public partial class MenuMantenimiento : Form
    {
        public MenuMantenimiento()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Form MantenimientoProducto = new MantenimientoProducto();
            MantenimientoProducto.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Form MantenimientoCliente = new MantenimientoCliente();
            MantenimientoCliente.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Form MantenimientoEmpleado = new MantenimientoEmpleado();
            MantenimientoEmpleado.Show();
        }
    }
}

