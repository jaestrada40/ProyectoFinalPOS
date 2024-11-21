using ProyectoFinalPOS.Carrito;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalPOS.Recibo
{
    public partial class ReciboForm : Form
    {
        public ReciboForm(List<CarritoItemCard> itemsCarrito, decimal total)
        {
            InitializeComponent();
            CargarRecibo(itemsCarrito, total);
        }

        private void CargarRecibo(List<CarritoItemCard> itemsCarrito, decimal total)
        {
            // Configurar encabezado
            lblEncabezado.Text = "Recibo de Compra";
            lblFecha.Text = $"Fecha: {DateTime.Now.ToString("dd/MM/yyyy HH:mm")}";

            // Agregar los productos al FlowLayoutPanel
            foreach (var item in itemsCarrito)
            {
                // Crear un contenedor para cada producto en el recibo
                var panelItem = new Panel
                {
                    Width = 550,
                    Height = 40,
                    BorderStyle = BorderStyle.FixedSingle
                };

                // Crear etiquetas con los detalles del producto
                var lblNombre = new Label
                {
                    Text = item.ProductName,
                    Location = new System.Drawing.Point(10, 10),
                    Width = 150
                };
                var lblCantidad = new Label
                {
                    Text = $"{item.Cantidad}",
                    Location = new System.Drawing.Point(170, 10),
                    Width = 100
                };
                var lblPrecio = new Label
                {
                    Text = $"Q{item.Price:F2}",
                    Location = new System.Drawing.Point(280, 10),
                    Width = 100
                };
                var lblSubtotal = new Label
                {
                    Text = $"Subtotal: Q{(item.Price * item.Cantidad):F2}",
                    Location = new System.Drawing.Point(390, 10),
                    Width = 100
                };

                // Agregar las etiquetas al panel
                panelItem.Controls.Add(lblNombre);
                panelItem.Controls.Add(lblCantidad);
                panelItem.Controls.Add(lblPrecio);
                panelItem.Controls.Add(lblSubtotal);

                // Agregar el panel al FlowLayoutPanel
                flowLayoutPanelRecibo.Controls.Add(panelItem);
            }

            // Mostrar el total
            lblTotal.Text = $"Total a pagar: Q{total:F2}";
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void ReciboForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonCompletar_Click(object sender, EventArgs e)
        {
            Form Factura = new Factura();
            Factura.Show();
        }
    }
}
