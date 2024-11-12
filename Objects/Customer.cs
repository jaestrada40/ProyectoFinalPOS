﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPOS.Objects
{
    internal class Customer
    {
        public int CustomerID { get; set; } 
        public string NIT { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}"; 
        }
    }

}
