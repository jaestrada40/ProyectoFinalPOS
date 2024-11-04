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

namespace ProyectoFinalPOS.Empleado
{
    public partial class Empleados : UserControl
    {
        private SqlConnection connection = DatabaseConnections.GetInstance().GetConnection();
        public Empleados()
        {
            InitializeComponent();
            EmployeeCarga();
        }

        private void EmployeeCarga()
        {
            string query = "SELECT EmployeeID, FirstName, LastName, IdentificationNumber, Position, Username, PasswordHash FROM Employees";
            try
            {
                // Asegúrate de que la conexión esté abierta antes de usarla
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                // Llena un DataTable con los datos de la consulta
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, this.connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Asigna el DataTable como fuente de datos del DataGridView
                employeesTable.DataSource = dataTable;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                // Opcional: cierra la conexión si no quieres mantenerla abierta
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
