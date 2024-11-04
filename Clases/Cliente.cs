using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPOS.Clases
{
    internal class Cliente
    {
        public string Nit {  get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }

        public Cliente (string nit, string nombre, string apellido, string direccion, int telefono)
        {
            Nit = nit;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
        }
    }
}
