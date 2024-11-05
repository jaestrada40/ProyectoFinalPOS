﻿using Microsoft.Data.SqlClient;
using ProyectoFinalPOS.DBconexion;
using ProyectoFinalPOS.Objects;
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

        public ProductCard()
        {
            InitializeComponent();
        }

        public void SetProductData(Product product)
        {
            lblName.Text = product.Name;
            lblDescription.Text = product.Description;
            lblPrice.Text = $"${product.Price:F2}";
            lblStock.Text = $"Stock: {product.Stock}";

            // Cargar imagen si existe
            if (!string.IsNullOrEmpty(product.ImagePath) && File.Exists(product.ImagePath))
            {
                pictureBoxImage.Image = Image.FromFile(product.ImagePath);
            }
            else
            {
                pictureBoxImage.Image = null; 
            }
        }

        private void lblStock_Click(object sender, EventArgs e)
        {

        }
    }
}