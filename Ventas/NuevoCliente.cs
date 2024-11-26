using Microsoft.Data.SqlClient;
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
    public partial class NuevoCliente : Form
    {
        private SqlConnection connection = DatabaseConnections.GetInstance().GetConnection();
        public NuevoCliente()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            //Verificacion de campos en blanco
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtNit.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                MessageBox.Show("Por Favor, complete todos los campos.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarNit(txtNit.Text.Trim()))
            {
                MessageBox.Show("El NIT ingresado no tiene un formato válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!long.TryParse(txtNumero.Text.Trim(), out _))
            {
                MessageBox.Show("El teléfono debe contener solo números.", "Error de validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //verificacion si ya existe el cliente
            if (ClienteDuplicado(txtNit.Text.Trim()))
            {
                MessageBox.Show("Ya existe un cliente con este NIT.", "Cliente duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    

            //Crear en tabla SQL
            string query = @"INSERT INTO jsoberanis_db.Customers (FirstName, LastName, NIT, Address, Phone) 
                             VALUES (@FirstName, @LastName, @NIT, @Address, @Phone)";
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", txtNombre.Text.Trim());
                    command.Parameters.AddWithValue("@LastName", txtApellido.Text.Trim());
                    command.Parameters.AddWithValue("@NIT", txtNit.Text.Trim());
                    command.Parameters.AddWithValue("@Address", txtDireccion.Text.Trim());
                    command.Parameters.AddWithValue("@Phone", txtNumero.Text.Trim());

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cliente guardado exitosamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el cliente.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al guardar el cliente: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        //Validacion de longitud del NIT
        private bool ValidarNit(string nit)
        {
            return nit.Length >= 8 && nit.Length <= 9;
        }


        //Metodo para clientes duplicados
        private bool ClienteDuplicado(string nit)
        {
            string query = "SELECT COUNT(*) FROM jsoberanis_db.Customers WHERE NIT = @NIT";
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NIT", nit);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0; // Devuelve true si el cliente ya existe
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error al verificar duplicados: " + ex.Message, "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    } 
}

    