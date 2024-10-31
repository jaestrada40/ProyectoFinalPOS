


namespace ProyectoFinalPOS
{
    partial class MenuMantenimiento
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
            btnProductos = new PictureBox();
            btnClientes = new PictureBox();
            btnEmpleados = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEmpleados).BeginInit();
            SuspendLayout();
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(80, 91);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(150, 143);
            btnProductos.TabIndex = 0;
            btnProductos.TabStop = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(302, 91);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(150, 143);
            btnClientes.TabIndex = 1;
            btnClientes.TabStop = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.Location = new Point(520, 91);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(150, 143);
            btnEmpleados.TabIndex = 2;
            btnEmpleados.TabStop = false;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 254);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 3;
            label1.Text = "Productos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(340, 254);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 4;
            label2.Text = "Clientes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(551, 254);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 5;
            label3.Text = "Empleados";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(75, 36);
            label4.Name = "label4";
            label4.Size = new Size(595, 37);
            label4.TabIndex = 6;
            label4.Text = "Seleccione una Opción a Realizar Mantenimiento";
            // 
            // MenuMantenimiento
            // 
            ClientSize = new Size(762, 344);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEmpleados);
            Controls.Add(btnClientes);
            Controls.Add(btnProductos);
            Name = "MenuMantenimiento";
            Text = "Menú de Mantenimiento";
            ((System.ComponentModel.ISupportInitialize)btnProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private PictureBox btnProductos;
        private PictureBox btnEmpleados;
        private PictureBox btnClientes;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}