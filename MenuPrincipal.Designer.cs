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
            btnMantenimiento = new PictureBox();
            btnVentas = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnMantenimiento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnVentas).BeginInit();
            SuspendLayout();
            // 
            // btnMantenimiento
            // 
            btnMantenimiento.AccessibleRole = AccessibleRole.TitleBar;
            btnMantenimiento.Location = new Point(108, 64);
            btnMantenimiento.Margin = new Padding(3, 2, 3, 2);
            btnMantenimiento.Name = "btnMantenimiento";
            btnMantenimiento.Size = new Size(172, 126);
            btnMantenimiento.TabIndex = 0;
            btnMantenimiento.TabStop = false;
            btnMantenimiento.Click += pictureBox1_Click;
            // 
            // btnVentas
            // 
            btnVentas.AccessibleRole = AccessibleRole.TitleBar;
            btnVentas.Location = new Point(324, 64);
            btnVentas.Margin = new Padding(3, 2, 3, 2);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(172, 126);
            btnVentas.TabIndex = 1;
            btnVentas.TabStop = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(61, 23);
            label1.Name = "label1";
            label1.Size = new Size(331, 30);
            label1.TabIndex = 2;
            label1.Text = "Selecione una opción para Iniciar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 203);
            label2.Name = "label2";
            label2.Size = new Size(139, 15);
            label2.TabIndex = 3;
            label2.Text = "Menú de Mantenimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(324, 203);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 4;
            label3.Text = "Menú de Ventas";
            // 
            // MenuPrincipal
            // 
            AccessibleRole = AccessibleRole.TitleBar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 260);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVentas);
            Controls.Add(btnMantenimiento);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuPrincipal";
            Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)btnMantenimiento).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnMantenimiento;
        private PictureBox btnVentas;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}