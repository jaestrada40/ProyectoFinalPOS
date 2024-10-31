using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPOS.Clases
{
    internal class Empleado
    {
        public string Nombre {  get; set; }
        public string Apellido { get; set; }
        public int Dpi { get; set; }
        public string Cargo { get; set; }
        public string Usuario { get; set; }
        public string Contrasenia { get; set; }

        public Empleado (string nombre, string apellido,  int dpi, string cargo, string usuario, string contrasenia)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dpi = dpi;
            Cargo = cargo;
            Usuario = usuario;
            Contrasenia = contrasenia;
        }
    }
}
