namespace ProyectoFinalPOS
{
    partial class NuevoCliente
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
            txtNombre = new TextBox();
            buttonGuardar = new Button();
            txtApellido = new TextBox();
            txtNit = new TextBox();
            txtDireccion = new TextBox();
            label1 = new Label();
            txtNumero = new TextBox();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(22, 110);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Primer Nombre";
            txtNombre.Size = new Size(243, 23);
            txtNombre.TabIndex = 0;
            // 
            // buttonGuardar
            // 
            buttonGuardar.BackColor = Color.FromArgb(0, 119, 70);
            buttonGuardar.FlatStyle = FlatStyle.Flat;
            buttonGuardar.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGuardar.Location = new Point(22, 262);
            buttonGuardar.Margin = new Padding(3, 2, 3, 2);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(243, 36);
            buttonGuardar.TabIndex = 2;
            buttonGuardar.Text = "Guardar Cliente";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(22, 146);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Primer Apellido";
            txtApellido.Size = new Size(243, 23);
            txtApellido.TabIndex = 3;
            // 
            // txtNit
            // 
            txtNit.Location = new Point(22, 74);
            txtNit.Margin = new Padding(3, 2, 3, 2);
            txtNit.Name = "txtNit";
            txtNit.PlaceholderText = "Ingrese su NIT";
            txtNit.Size = new Size(243, 23);
            txtNit.TabIndex = 4;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(22, 183);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Dirección Fiscal";
            txtDireccion.Size = new Size(243, 23);
            txtDireccion.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 23);
            label1.Name = "label1";
            label1.Size = new Size(123, 19);
            label1.TabIndex = 6;
            label1.Text = "Nuevo Cliente";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(22, 220);
            txtNumero.Margin = new Padding(3, 2, 3, 2);
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "Número Telefónico";
            txtNumero.Size = new Size(243, 23);
            txtNumero.TabIndex = 7;
            // 
            // NuevoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 42, 60);
            ClientSize = new Size(292, 318);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Controls.Add(txtDireccion);
            Controls.Add(txtNit);
            Controls.Add(txtApellido);
            Controls.Add(buttonGuardar);
            Controls.Add(txtNombre);
            ForeColor = Color.Snow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "NuevoCliente";
            Text = "Nuevo Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Button buttonGuardar;
        private TextBox txtApellido;
        private TextBox txtNit;
        private TextBox txtDireccion;
        private Label label1;
        private TextBox txtNumero;
    }
}