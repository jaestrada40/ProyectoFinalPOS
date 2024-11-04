namespace ProyectoFinalPOS
{
    partial class MantenimientoProducto
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
            textBoxProducto = new TextBox();
            buttonBuscar = new Button();
            btnAgregar = new PictureBox();
            label1 = new Label();
            flowProductos = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)btnAgregar).BeginInit();
            SuspendLayout();
            // 
            // textBoxProducto
            // 
            textBoxProducto.Location = new Point(52, 57);
            textBoxProducto.Name = "textBoxProducto";
            textBoxProducto.PlaceholderText = "Ingrese el Nombre del Producto";
            textBoxProducto.Size = new Size(431, 27);
            textBoxProducto.TabIndex = 0;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(504, 50);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(175, 41);
            buttonBuscar.TabIndex = 1;
            buttonBuscar.Text = "Buscar Producto";
            buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(761, 34);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(68, 57);
            btnAgregar.TabIndex = 2;
            btnAgregar.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(854, 55);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 3;
            label1.Text = "Nuevo Producto";
            // 
            // flowProductos
            // 
            flowProductos.Location = new Point(52, 119);
            flowProductos.Name = "flowProductos";
            flowProductos.Size = new Size(987, 477);
            flowProductos.TabIndex = 4;
            // 
            // MantenimientoProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 624);
            Controls.Add(flowProductos);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Controls.Add(buttonBuscar);
            Controls.Add(textBoxProducto);
            Name = "MantenimientoProducto";
            Text = "Mantenimiento de Productos";
            ((System.ComponentModel.ISupportInitialize)btnAgregar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxProducto;
        private Button buttonBuscar;
        private PictureBox btnAgregar;
        private Label label1;
        private FlowLayoutPanel flowProductos;
    }
}