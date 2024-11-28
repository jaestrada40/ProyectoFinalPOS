namespace ProyectoFinalPOS.Ventas
{
    partial class Ventas
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnNuevo = new Button();
            btnNit = new Button();
            textBuscar = new TextBox();
            txtNit = new TextBox();
            panel2 = new Panel();
            pnlCarrito = new Panel();
            flowLayoutPanelCarrito = new FlowLayoutPanel();
            panel4 = new Panel();
            btnPagar = new Button();
            panel8 = new Panel();
            lblTotal = new Label();
            label1 = new Label();
            panel3 = new Panel();
            lblCliente = new Label();
            panel6 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnEliminar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlCarrito.SuspendLayout();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 119, 70);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnNuevo);
            panel1.Controls.Add(btnNit);
            panel1.Controls.Add(textBuscar);
            panel1.Controls.Add(txtNit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(999, 105);
            panel1.TabIndex = 21;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(37, 42, 60);
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(304, 15);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(131, 41);
            btnNuevo.TabIndex = 23;
            btnNuevo.Text = "Nuevo Cliente";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnNit
            // 
            btnNit.BackColor = Color.FromArgb(37, 42, 60);
            btnNit.FlatAppearance.BorderSize = 0;
            btnNit.FlatStyle = FlatStyle.Flat;
            btnNit.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            btnNit.ForeColor = Color.White;
            btnNit.Location = new Point(195, 15);
            btnNit.Margin = new Padding(3, 4, 3, 4);
            btnNit.Name = "btnNit";
            btnNit.Size = new Size(103, 41);
            btnNit.TabIndex = 22;
            btnNit.Text = "Buscar";
            btnNit.UseVisualStyleBackColor = false;
            btnNit.Click += btnNit_Click;
            // 
            // textBuscar
            // 
            textBuscar.Location = new Point(27, 63);
            textBuscar.Name = "textBuscar";
            textBuscar.PlaceholderText = "Ingrese el Código o Nombre del Producto para Buscar";
            textBuscar.Size = new Size(550, 27);
            textBuscar.TabIndex = 21;
            // 
            // txtNit
            // 
            txtNit.Location = new Point(27, 21);
            txtNit.Name = "txtNit";
            txtNit.PlaceholderText = "Ingrese su NIT";
            txtNit.Size = new Size(161, 27);
            txtNit.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.Controls.Add(pnlCarrito);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(698, 105);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(301, 782);
            panel2.TabIndex = 22;
            // 
            // pnlCarrito
            // 
            pnlCarrito.BackColor = Color.FromArgb(37, 42, 60);
            pnlCarrito.Controls.Add(flowLayoutPanelCarrito);
            pnlCarrito.Dock = DockStyle.Fill;
            pnlCarrito.Location = new Point(0, 59);
            pnlCarrito.Margin = new Padding(3, 4, 3, 4);
            pnlCarrito.Name = "pnlCarrito";
            pnlCarrito.Size = new Size(301, 555);
            pnlCarrito.TabIndex = 2;
            // 
            // flowLayoutPanelCarrito
            // 
            flowLayoutPanelCarrito.AutoScroll = true;
            flowLayoutPanelCarrito.AutoSize = true;
            flowLayoutPanelCarrito.Dock = DockStyle.Fill;
            flowLayoutPanelCarrito.Location = new Point(0, 0);
            flowLayoutPanelCarrito.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanelCarrito.Name = "flowLayoutPanelCarrito";
            flowLayoutPanelCarrito.Size = new Size(301, 555);
            flowLayoutPanelCarrito.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(37, 42, 60);
            panel4.Controls.Add(btnPagar);
            panel4.Controls.Add(panel8);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 614);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(301, 168);
            panel4.TabIndex = 1;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.FromArgb(0, 119, 70);
            btnPagar.FlatAppearance.BorderSize = 0;
            btnPagar.FlatStyle = FlatStyle.Flat;
            btnPagar.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPagar.ForeColor = Color.White;
            btnPagar.Location = new Point(61, 85);
            btnPagar.Margin = new Padding(3, 4, 3, 4);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(183, 56);
            btnPagar.TabIndex = 3;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(37, 42, 60);
            panel8.Controls.Add(lblTotal);
            panel8.Controls.Add(label1);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(301, 44);
            panel8.TabIndex = 2;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(82, 9);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(76, 24);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Q 0.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 24);
            label1.TabIndex = 0;
            label1.Text = "Total:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(37, 42, 60);
            panel3.Controls.Add(lblCliente);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(301, 59);
            panel3.TabIndex = 0;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = Color.White;
            lblCliente.Location = new Point(7, 19);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(75, 21);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            lblCliente.Click += lblCliente_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(flowLayoutPanel1);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 105);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(698, 782);
            panel6.TabIndex = 23;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(699, 813);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(37, 42, 60);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(441, 15);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(131, 41);
            btnEliminar.TabIndex = 24;
            btnEliminar.Text = "Limpiar Cliente";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Ventas";
            Size = new Size(999, 887);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            pnlCarrito.ResumeLayout(false);
            pnlCarrito.PerformLayout();
            panel4.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel pnlCarrito;
        private Panel panel4;
        private Panel panel3;
        private Panel panel6;
        private Panel panel8;
        private Label lblTotal;
        private Label label1;
        private Button btnPagar;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblCliente;
        private FlowLayoutPanel flowLayoutPanelCarrito;
        private TextBox txtNit;
        private TextBox textBuscar;
        private Button btnNit;
        private Button btnNuevo;
        private Button btnEliminar;
    }
}
