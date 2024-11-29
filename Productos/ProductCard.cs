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
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public int Cantidad { get; set; }
        public string ProductID { get; set; }
        private Product producto;

        // Evento para notificar cuando se agregue un producto al carrito
        public event EventHandler<Product> AgregarAlCarritoClicked;

        public ProductCard()
        {
            InitializeComponent();
            ProductName = string.Empty;
            ProductCode = string.Empty;
        }
        public void SetProductData(Product producto)
        {
            ProductName = producto.Name;
            ProductCode = producto.Code;

            this.producto = producto;
            lblName.Text = producto.Name;
            lblDescription.Text = producto.Description;
            lblPrice.Text = $"Precio: Q{producto.Price:F2}";
            lblStock.Text = $"Stock: {producto.Stock}";
            lblCodigo.Text = producto.Code;

            if (!string.IsNullOrEmpty(producto.ImagePath) && File.Exists(producto.ImagePath))
            {
                try
                {
                    pictureBoxImage.Load(producto.ImagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar la imagen desde el archivo local: {ex.Message}", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CargarImagenPredeterminada();
                }
            }
            else
            {
                CargarImagenPredeterminada();
            }
        }

        // Método para cargar la imagen quemada (predeterminada)
        private void CargarImagenPredeterminada()
        {
            try
            {
                pictureBoxImage.Load(producto.ImagePath);
                pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage; // Opcional, ajusta la imagen al tamaño del PictureBox
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la imagen predeterminada desde la URL: {ex.Message}", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //pictureBoxImage.Image = Properties.Resources.ImagePlaceholder; // Usa una imagen local en caso de falla
            }
        }


        private void lblStock_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarAlCarritoClicked?.Invoke(this, producto);
        }
    }
}
