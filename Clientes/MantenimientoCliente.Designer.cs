namespace ProyectoFinalPOS
{
    partial class MantenimientoCliente
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
            textBoxNombre = new TextBox();
            buttonCliente = new Button();
            btnAgregar = new PictureBox();
            label1 = new Label();
            flowMiembros = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)btnAgregar).BeginInit();
            SuspendLayout();
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(40, 40);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "Escriba el Nombre del Cliente";
            textBoxNombre.Size = new Size(367, 27);
            textBoxNombre.TabIndex = 0;
            // 
            // buttonCliente
            // 
            buttonCliente.Location = new Point(431, 38);
            buttonCliente.Name = "buttonCliente";
            buttonCliente.Size = new Size(136, 31);
            buttonCliente.TabIndex = 1;
            buttonCliente.Text = "Buscar Cliente";
            buttonCliente.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(719, 26);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(76, 57);
            btnAgregar.TabIndex = 2;
            btnAgregar.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(801, 47);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 3;
            label1.Text = "Agregar Miembro";
            // 
            // flowMiembros
            // 
            flowMiembros.Location = new Point(41, 109);
            flowMiembros.Name = "flowMiembros";
            flowMiembros.Size = new Size(960, 379);
            flowMiembros.TabIndex = 4;
            // 
            // MantenimientoCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 523);
            Controls.Add(flowMiembros);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Controls.Add(buttonCliente);
            Controls.Add(textBoxNombre);
            Name = "MantenimientoCliente";
            Text = "Mantenimiento de Clientes";
            ((System.ComponentModel.ISupportInitialize)btnAgregar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNombre;
        private Button buttonCliente;
        private PictureBox btnAgregar;
        private Label label1;
        private FlowLayoutPanel flowMiembros;
    }
}