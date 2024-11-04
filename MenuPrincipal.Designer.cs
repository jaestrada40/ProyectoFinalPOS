namespace ProyectoFinalPOS
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label4 = new Label();
            btnCerrar = new Button();
            panel2 = new Panel();
            label6 = new Label();
            button6 = new Button();
            btnEmpleados = new Button();
            btnClientes = new Button();
            btnProductos = new Button();
            btnVentas = new Button();
            btnDashboard = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dashboard1 = new Dashboard();
            ventas1 = new Ventas.Ventas();
            productos1 = new Productos.Productos();
            clientes1 = new Clientes.Clientes();
            empleados1 = new Empleado.Empleados();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnCerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 35);
            panel1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(193, 18);
            label4.TabIndex = 11;
            label4.Text = "Sistema Gestión de Servicios";
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(1060, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(40, 35);
            btnCerrar.TabIndex = 10;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkOliveGreen;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(btnEmpleados);
            panel2.Controls.Add(btnClientes);
            panel2.Controls.Add(btnProductos);
            panel2.Controls.Add(btnVentas);
            panel2.Controls.Add(btnDashboard);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 665);
            panel2.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(46, 625);
            label6.Name = "label6";
            label6.Size = new Size(33, 18);
            label6.TabIndex = 13;
            label6.Text = "Salir";
            // 
            // button6
            // 
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = Properties.Resources.account_logout_24;
            button6.Location = new Point(12, 620);
            button6.Name = "button6";
            button6.Size = new Size(24, 24);
            button6.TabIndex = 7;
            button6.UseVisualStyleBackColor = true;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.DarkOliveGreen;
            btnEmpleados.Cursor = Cursors.Hand;
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Tahoma", 11F);
            btnEmpleados.ForeColor = Color.White;
            btnEmpleados.Image = Properties.Resources.administrator_2_32;
            btnEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.Location = new Point(12, 492);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(200, 40);
            btnEmpleados.TabIndex = 12;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = false;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.DarkOliveGreen;
            btnClientes.Cursor = Cursors.Hand;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Tahoma", 11F);
            btnClientes.ForeColor = Color.White;
            btnClientes.Image = Properties.Resources.group_32;
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(12, 433);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(200, 40);
            btnClientes.TabIndex = 11;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.DarkOliveGreen;
            btnProductos.Cursor = Cursors.Hand;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Tahoma", 11F);
            btnProductos.ForeColor = Color.White;
            btnProductos.Image = Properties.Resources.shopping_basket_32;
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(12, 373);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(200, 40);
            btnProductos.TabIndex = 10;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.DarkOliveGreen;
            btnVentas.Cursor = Cursors.Hand;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Tahoma", 11F);
            btnVentas.ForeColor = Color.White;
            btnVentas.Image = Properties.Resources.cart_59_32;
            btnVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentas.Location = new Point(12, 312);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(200, 40);
            btnVentas.TabIndex = 9;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click_1;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.DarkOliveGreen;
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Tahoma", 11F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = Properties.Resources.dashboard_2_32;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(12, 251);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(200, 40);
            btnDashboard.TabIndex = 8;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(31, 202);
            label5.Name = "label5";
            label5.Size = new Size(148, 19);
            label5.TabIndex = 7;
            label5.Text = "Bienvenido, usuario";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logomarket1;
            pictureBox1.Location = new Point(31, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(dashboard1);
            flowLayoutPanel1.Controls.Add(ventas1);
            flowLayoutPanel1.Controls.Add(productos1);
            flowLayoutPanel1.Controls.Add(clientes1);
            flowLayoutPanel1.Controls.Add(empleados1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(225, 35);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(875, 665);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // dashboard1
            // 
            dashboard1.Location = new Point(3, 3);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(875, 665);
            dashboard1.TabIndex = 12;
            // 
            // ventas1
            // 
            ventas1.Location = new Point(3, 674);
            ventas1.Name = "ventas1";
            ventas1.Size = new Size(875, 665);
            ventas1.TabIndex = 12;
            // 
            // productos1
            // 
            productos1.Location = new Point(3, 1345);
            productos1.Name = "productos1";
            productos1.Size = new Size(875, 665);
            productos1.TabIndex = 12;
            // 
            // clientes1
            // 
            clientes1.Location = new Point(3, 2016);
            clientes1.Name = "clientes1";
            clientes1.Size = new Size(875, 665);
            clientes1.TabIndex = 12;
            // 
            // empleados1
            // 
            empleados1.Location = new Point(3, 2687);
            empleados1.Name = "empleados1";
            empleados1.Size = new Size(875, 665);
            empleados1.TabIndex = 0;
            // 
            // MenuPrincipal
            // 
            AccessibleRole = AccessibleRole.TitleBar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 700);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnCerrar;
        private Label label4;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label5;
        private Button btnDashboard;
        private Button btnEmpleados;
        private Button btnClientes;
        private Button btnProductos;
        private Button btnVentas;
        private Button button6;
        private Label label6;
        private FlowLayoutPanel flowLayoutPanel1;
        private Dashboard dashboard1;
        private Ventas.Ventas ventas1;
        private Productos.Productos productos1;
        private Clientes.Clientes clientes1;
        private Empleado.Empleados empleados1;
    }
}