namespace ProyectoFinalPOS
{
    partial class MenuVentas
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
            flowProductos = new FlowLayoutPanel();
            buttonBuscar = new Button();
            textBoxId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(35, 41);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "Ingrese el Nombre del Producto";
            textBoxNombre.Size = new Size(392, 27);
            textBoxNombre.TabIndex = 0;
            // 
            // flowProductos
            // 
            flowProductos.Location = new Point(35, 96);
            flowProductos.Name = "flowProductos";
            flowProductos.Size = new Size(577, 384);
            flowProductos.TabIndex = 1;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(899, 36);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(135, 32);
            buttonBuscar.TabIndex = 2;
            buttonBuscar.Text = "Buscar Producto";
            buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(433, 41);
            textBoxId.Name = "textBoxId";
            textBoxId.PlaceholderText = "Ingrese el Código del Producto";
            textBoxId.Size = new Size(277, 27);
            textBoxId.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 18);
            label1.Name = "label1";
            label1.Size = new Size(160, 20);
            label1.TabIndex = 4;
            label1.Text = "Búsqueda por Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(433, 18);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 5;
            label2.Text = "Búsqueda por Código";
            // 
            // MenuVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 504);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxId);
            Controls.Add(buttonBuscar);
            Controls.Add(flowProductos);
            Controls.Add(textBoxNombre);
            Name = "MenuVentas";
            Text = "Menu de Ventas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNombre;
        private FlowLayoutPanel flowProductos;
        private Button buttonBuscar;
        private TextBox textBoxId;
        private Label label1;
        private Label label2;
    }
}