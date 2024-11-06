using ProyectoFinalPOS.Objects;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoFinalPOS.Ventas
{
    public class Carrito
    {
        public List<Product> Productos { get; private set; }

        public Carrito()
        {
            Productos = new List<Product>();
        }

        public void AgregarProducto(Product producto)
        {
            Productos.Add(producto);
        }

        public decimal CalcularTotal()
        {
            return Productos.Sum(p => p.Price);
        }
    }

}