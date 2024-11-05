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
            lblVentas = new Label();
            panel2 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            btnPagar = new Button();
            panel8 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            btnPrint = new Button();
            panel6 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 119, 70);
            panel1.Controls.Add(lblVentas);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(875, 55);
            panel1.TabIndex = 21;
            // 
            // lblVentas
            // 
            lblVentas.AutoSize = true;
            lblVentas.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVentas.ForeColor = Color.White;
            lblVentas.Location = new Point(16, 14);
            lblVentas.Name = "lblVentas";
            lblVentas.Size = new Size(75, 23);
            lblVentas.TabIndex = 18;
            lblVentas.Text = "Ventas";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(612, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(263, 610);
            panel2.TabIndex = 22;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(37, 42, 60);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 44);
            panel5.Name = "panel5";
            panel5.Size = new Size(263, 440);
            panel5.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(37, 42, 60);
            panel4.Controls.Add(btnPagar);
            panel4.Controls.Add(panel8);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 484);
            panel4.Name = "panel4";
            panel4.Size = new Size(263, 126);
            panel4.TabIndex = 1;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.FromArgb(0, 119, 70);
            btnPagar.FlatAppearance.BorderSize = 0;
            btnPagar.FlatStyle = FlatStyle.Flat;
            btnPagar.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPagar.ForeColor = Color.White;
            btnPagar.Location = new Point(53, 64);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(160, 42);
            btnPagar.TabIndex = 3;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(37, 42, 60);
            panel8.Controls.Add(label2);
            panel8.Controls.Add(label1);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(263, 33);
            panel8.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(178, 7);
            label2.Name = "label2";
            label2.Size = new Size(81, 19);
            label2.TabIndex = 1;
            label2.Text = "Q 200.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(8, 7);
            label1.Name = "label1";
            label1.Size = new Size(58, 19);
            label1.TabIndex = 0;
            label1.Text = "Total:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(37, 42, 60);
            panel3.Controls.Add(btnPrint);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(263, 44);
            panel3.TabIndex = 0;
            // 
            // btnPrint
            // 
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Image = Properties.Resources.printer_24;
            btnPrint.Location = new Point(8, 6);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 32);
            btnPrint.TabIndex = 0;
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(flowLayoutPanel1);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 55);
            panel6.Name = "panel6";
            panel6.Size = new Size(612, 610);
            panel6.TabIndex = 23;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(609, 604);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Ventas";
            Size = new Size(875, 665);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblVentas;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel6;
        private Panel panel8;
        private Label label2;
        private Label label1;
        private Button btnPrint;
        private Button btnPagar;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
