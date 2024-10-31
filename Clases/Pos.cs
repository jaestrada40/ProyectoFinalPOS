using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPOS.Clases
{
    internal class Pos
    {
        public List<Cliente> clientes { get; }
        public List<Empleado> empleados { get; }
        public List<Producto> productos { get; }

        public Pos()
        {
            clientes = inicializarClientes();
            empleados = inicializarEmpleados();
            productos = inicializarProductos();
        }

        public List<Producto> inicializarProductos()
        {
            List <Producto> productosActuales = new List<Producto>();
            //Agregar lista de productos
            return productosActuales;
        }

        public List<Empleado> inicializarEmpleados()
        {
            List <Empleado> empleadosActuales = new List<Empleado>();
            //Empleados ya registrados
            return empleadosActuales;
        }

        public List<Cliente> inicializarClientes()
        {
            List <Cliente> clientesActuales = new List<Cliente>();
            //Clientes que ya compraron
            return clientesActuales;
        }

        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }

        public void EliminarProducto(Producto produto)
        {
            productos.Remove(produto);
        }

        //Editar producto
        public void AgregarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public void EliminarCliente(Cliente cliente)
        {
            clientes.Remove(cliente);
        }

        //Editar Cliente
        public void AgregarEmpleado(Empleado empleado)
        {
            empleados.Add(empleado);
        }

        public void EliminarEmpleado(Empleado empleado)
        {
            empleados.Remove(empleado);
        }

        //Editar Empleado
    }
}
