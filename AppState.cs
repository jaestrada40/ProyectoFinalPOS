using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinalPOS.Clases;

namespace ProyectoFinalPOS
{
    internal class AppState
    {
        private static AppState instance;
        public Pos posActual { get; set; }

        private AppState()
        {
            posActual = new Pos();
        }

        public static AppState Instance
        {
            get
            {
                if (instance == null)
                    instance = new AppState();
                return instance;
            }
        }
    }
}
