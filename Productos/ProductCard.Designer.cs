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
            btnRegistrarse = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.Location = new Point(19, 3);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(157, 129);
            pictureBoxImage.TabIndex = 0;
            pictureBoxImage.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(51, 151);
            lblName.Name = "lblName";
            lblName.Size = new Size(67, 18);
            lblName.TabIndex = 1;
            lblName.Text = "Nombre";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.White;
            lblDescription.Location = new Point(49, 180);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(71, 14);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Descripcióm";
            lblDescription.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.White;
            lblPrice.Location = new Point(56, 209);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(56, 18);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Precio";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStock.ForeColor = Color.White;
            lblStock.Location = new Point(63, 238);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(42, 14);
            lblStock.TabIndex = 4;
            lblStock.Text = "Stock";
            lblStock.Click += lblStock_Click;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.BackColor = Color.FromArgb(0, 119, 70);
            btnRegistrarse.FlatAppearance.BorderSize = 0;
            btnRegistrarse.FlatStyle = FlatStyle.Flat;
            btnRegistrarse.Font = new Font("Tahoma", 11F, FontStyle.Bold);
            btnRegistrarse.ForeColor = Color.White;
            btnRegistrarse.Location = new Point(0, 267);
            btnRegistrarse.Margin = new Padding(3, 2, 3, 2);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(200, 33);
            btnRegistrarse.TabIndex = 12;
            btnRegistrarse.Text = "Agregar";
            btnRegistrarse.UseVisualStyleBackColor = false;
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 41, 59);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btnRegistrarse);
            Controls.Add(lblStock);
            Controls.Add(lblPrice);
            Controls.Add(lblDescription);
            Controls.Add(lblName);
            Controls.Add(pictureBoxImage);
            Name = "ProductCard";
            Size = new Size(198, 298);
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxImage;
        private Label lblName;
        private Label lblDescription;
        private Label lblPrice;
        private Label lblStock;
        private Button btnRegistrarse;
    }
}
