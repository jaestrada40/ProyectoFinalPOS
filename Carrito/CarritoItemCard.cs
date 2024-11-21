using System;
using System.Windows.Forms;
using ProyectoFinalPOS.Objects;

namespace ProyectoFinalPOS.Carrito
{
    public partial class CarritoItemCard : UserControl
    {
        private Product producto;
        private int cantidad = 1;
        // Propiedad para obtener el ID del producto
        public int ProductID => producto.ProductID;

        // Evento para notificar cuando se elimina un producto del carrito
        public event EventHandler<Product> ProductoEliminado;


        // Agregar la propiedad para acceder al precio
        public decimal Price => producto.Price;

        // Crear un campo para la cantidad
        public int Cantidad { get => cantidad; }

        public event EventHandler<(Product producto, int cantidad)> CantidadReducida; // Nuevo evento para reducir la cantidad manualmente

        // public string ProductName => producto.Name;

        public CarritoItemCard(Product product)
        {
            InitializeComponent();
            this.producto = product;
            lblName.Text = product.Name;
            lblPrice.Text = $"Q {product.Price:F2}";

            numericEliminar.Minimum = 1;
            numericEliminar.Maximum = cantidad;
            numericEliminar.Value = 1;


            ActualizarCantidad();
        }

        public void IncrementarCantidad()
        { 
            cantidad++;
            ActualizarCantidad();
            numericEliminar.Maximum = cantidad;
        }

        private void ActualizarCantidad()
        {
            lblCantidad.Text = $"{cantidad}";
            lblPrice.Text = $"Q{(producto.Price * cantidad):F2}";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int cantidadAEliminar = (int)numericEliminar.Value;
            if (cantidadAEliminar >= cantidad)
            {
                // Dispara el evento ProductoEliminado pasando el producto actual
                ProductoEliminado?.Invoke(this, producto);
                // Eliminar este control del panel del carrito
                this.Parent?.Controls.Remove(this);
                ActualizarCantidad();
            }
            else
            {
                cantidad -= cantidadAEliminar;
                CantidadReducida?.Invoke(this, (producto, cantidadAEliminar));
                ActualizarCantidad();

                numericEliminar.Maximum = cantidad;
            }
        }

        private void numericEliminar_ValueChanged(object sender, EventArgs e)
        {
            int cantidadAEliminar = (int)numericEliminar.Value;

            if (cantidadAEliminar > 0 && cantidadAEliminar <= cantidad)
            {
                cantidad -= cantidadAEliminar;
                ActualizarCantidad();

                // Disparar el evento para notificar al control padre
                CantidadReducida?.Invoke(this, (producto, cantidadAEliminar));
            }
        }
    }
}
