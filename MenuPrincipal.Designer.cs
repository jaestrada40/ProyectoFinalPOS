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
            btnSignOut = new Button();
            btnEmpleados = new Button();
            btnClientes = new Button();
            btnProductos = new Button();
            btnVentas = new Button();
            btnDashboard = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            panelContainer = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 42, 60);
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
            panel2.BackColor = Color.FromArgb(37, 42, 60);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btnSignOut);
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
            label6.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(46, 625);
            label6.Name = "label6";
            label6.Size = new Size(44, 18);
            label6.TabIndex = 13;
            label6.Text = "Salir";
            // 
            // btnSignOut
            // 
            btnSignOut.Cursor = Cursors.Hand;
            btnSignOut.FlatAppearance.BorderSize = 0;
            btnSignOut.FlatStyle = FlatStyle.Flat;
            btnSignOut.Image = Properties.Resources.account_logout_24;
            btnSignOut.Location = new Point(12, 620);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(24, 24);
            btnSignOut.TabIndex = 7;
            btnSignOut.UseVisualStyleBackColor = true;
            btnSignOut.Click += btnSignOut_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.FromArgb(37, 42, 60);
            btnEmpleados.Cursor = Cursors.Hand;
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Tahoma", 11.25F, FontStyle.Bold);
            btnEmpleados.ForeColor = Color.White;
            btnEmpleados.Image = Properties.Resources.administrator_2_32;
            btnEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.Location = new Point(12, 455);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(200, 40);
            btnEmpleados.TabIndex = 12;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = false;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(37, 42, 60);
            btnClientes.Cursor = Cursors.Hand;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Tahoma", 11.25F, FontStyle.Bold);
            btnClientes.ForeColor = Color.White;
            btnClientes.Image = Properties.Resources.group_32;
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(12, 396);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(200, 40);
            btnClientes.TabIndex = 11;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.FromArgb(37, 42, 60);
            btnProductos.Cursor = Cursors.Hand;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Tahoma", 11.25F, FontStyle.Bold);
            btnProductos.ForeColor = Color.White;
            btnProductos.Image = Properties.Resources.shopping_basket_32;
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(12, 336);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(200, 40);
            btnProductos.TabIndex = 10;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.FromArgb(37, 42, 60);
            btnVentas.Cursor = Cursors.Hand;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Tahoma", 11.25F, FontStyle.Bold);
            btnVentas.ForeColor = Color.White;
            btnVentas.Image = Properties.Resources.cart_59_32;
            btnVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentas.Location = new Point(12, 275);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(200, 40);
            btnVentas.TabIndex = 9;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click_1;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(37, 42, 60);
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Tahoma", 11.25F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = Properties.Resources.dashboard_2_32;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(12, 214);
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
            label5.Location = new Point(31, 165);
            label5.Name = "label5";
            label5.Size = new Size(148, 19);
            label5.TabIndex = 7;
            label5.Text = "Bienvenido, usuario";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoLogin;
            pictureBox1.Location = new Point(12, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 89);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(225, 35);
            panelContainer.Margin = new Padding(3, 2, 3, 2);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(875, 665);
            panelContainer.TabIndex = 7;
            // 
            // MenuPrincipal
            // 
            AccessibleRole = AccessibleRole.TitleBar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 700);
            Controls.Add(panelContainer);
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
        private Button btnSignOut;
        private Label label6;
        private Dashboard dashboard1;
        private Productos.Productos productos1;
        private Clientes.Clientes clientes1;
        private Ventas.Ventas ventas1;
        private Empleado.Empleados empleados1;
        private Panel panelContainer;
    }
}