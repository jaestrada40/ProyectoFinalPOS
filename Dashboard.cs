﻿using Microsoft.Data.SqlClient;
using ProyectoFinalPOS.DBconexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalPOS
{
    public partial class Dashboard : UserControl
    {
        private SqlConnection connection = DatabaseConnections.GetInstance().GetConnection();
        public Dashboard()
        {
            InitializeComponent();
            totalVentas();
            totalProducts();
            totalCustomers();
            totalEmployees();
        }



        private void totalVentas()
        {
            string query = "SELECT COUNT(*) AS TotalProducts FROM jsoberanis_db.Sales;";
            //string query = "SELECT COUNT(*) AS TotalVentas FROM Sales;";

            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int totalVentas = (int)command.ExecuteScalar();
                    lblVentasTotal.Text = $"{totalVentas}";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al obtener el total de ventas: " + ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }


        private void totalProducts()
        {
            string query = "SELECT COUNT(*) AS TotalProducts FRO" +
                "M jsoberanis_db.Products;";
            //string query = "SELECT COUNT(*) AS TotalProducts FROM Products;";

            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int totalProducts = (int)command.ExecuteScalar();
                    lblTotalProducts.Text = $"{totalProducts}";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al obtener el total de productos: " + ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }


        private void totalCustomers()
        {
            string query = "SELECT COUNT(*) AS TotalCustomers FROM jsoberanis_db.Customers;";
            //string query = "SELECT COUNT(*) AS TotalCustomers FROM Customers;";

            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int totalCustomer = (int)command.ExecuteScalar();
                    lblTotalCustomers.Text = $"{totalCustomer}";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al obtener el total de customers: " + ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void totalEmployees()
        {
            string query = "SELECT COUNT(*) AS TotalEmployees FROM jsoberanis_db.Employees;";
            //string query = "SELECT COUNT(*) AS TotalEmployees FROM Employees;";

            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int totalEmployees = (int)command.ExecuteScalar();
                    lblTotalEmployees.Text = $"{totalEmployees}";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al obtener el total de employees: " + ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }


    }
}
