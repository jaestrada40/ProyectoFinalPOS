using Microsoft.Data.SqlClient;
using ProyectoFinalPOS.DBconexion;
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

namespace ProyectoFinalPOS.Productos
{
    public partial class ProductCard : UserControl
    {
        private Product producto;

        public ProductCard()
        {
            InitializeComponent();
        }

        public void SetProductData(Product product)
        {
            this.producto = product;
            lblName.Text = producto.Name;
            lblDescription.Text = producto.Description;
            lblPrice.Text = $"Precio: Q{producto.Price:F2}";
            lblStock.Text = $"Stock: {producto.Stock}";

            if (!string.IsNullOrEmpty(producto.ImagePath) && File.Exists(producto.ImagePath))
            {
                pictureBoxImage.Image = Image.FromFile(producto.ImagePath);
            }
            else
            {
                pictureBoxImage.Image = null;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void lblStock_Click(object sender, EventArgs e)
        {

        }
    }
}
