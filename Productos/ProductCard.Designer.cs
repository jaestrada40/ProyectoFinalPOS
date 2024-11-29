namespace ProyectoFinalPOS.Productos
{
    partial class ProductCard
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
            pictureBoxImage = new PictureBox();
            lblName = new Label();
            lblDescription = new Label();
            lblPrice = new Label();
            lblStock = new Label();
            btnAgregar = new Button();
            lblCodigo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.Dock = DockStyle.Top;
            pictureBoxImage.Location = new Point(0, 0);
            pictureBoxImage.Margin = new Padding(10);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Padding = new Padding(5);
            pictureBoxImage.Size = new Size(195, 135);
            pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImage.TabIndex = 0;
            pictureBoxImage.TabStop = false;
            // 
            // lblName
            // 
            lblName.Dock = DockStyle.Top;
            lblName.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(0, 135);
            lblName.Name = "lblName";
            lblName.Size = new Size(195, 18);
            lblName.TabIndex = 1;
            lblName.Text = "Nombre";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDescription
            // 
            lblDescription.Dock = DockStyle.Top;
            lblDescription.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.White;
            lblDescription.Location = new Point(0, 153);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(195, 33);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Descripción";
            lblDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPrice
            // 
            lblPrice.Dock = DockStyle.Top;
            lblPrice.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblPrice.ForeColor = Color.White;
            lblPrice.Location = new Point(0, 186);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(195, 32);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Precio";
            lblPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStock
            // 
            lblStock.Dock = DockStyle.Top;
            lblStock.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStock.ForeColor = Color.White;
            lblStock.Location = new Point(0, 218);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(195, 14);
            lblStock.TabIndex = 4;
            lblStock.Text = "Stock";
            lblStock.TextAlign = ContentAlignment.MiddleLeft;
            lblStock.Click += lblStock_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(0, 119, 70);
            btnAgregar.Dock = DockStyle.Bottom;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Tahoma", 11F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(0, 298);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(195, 39);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.Dock = DockStyle.Top;
            lblCodigo.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigo.ForeColor = Color.White;
            lblCodigo.Location = new Point(0, 232);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(195, 14);
            lblCodigo.TabIndex = 6;
            lblCodigo.Text = "Código";
            lblCodigo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 41, 59);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblCodigo);
            Controls.Add(btnAgregar);
            Controls.Add(lblStock);
            Controls.Add(lblPrice);
            Controls.Add(lblDescription);
            Controls.Add(lblName);
            Controls.Add(pictureBoxImage);
            Margin = new Padding(1);
            Name = "ProductCard";
            Size = new Size(195, 337);
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxImage;
        private Label lblName;
        private Label lblDescription;
        private Label lblPrice;
        private Label lblStock;
        private Button btnAgregar;
        private Label lblCodigo;
    }
}
