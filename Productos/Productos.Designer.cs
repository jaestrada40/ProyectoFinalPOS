namespace ProyectoFinalPOS.Productos
{
    partial class Productos
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
            label1 = new Label();
            productsTable = new DataGridView();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtDescripcion = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            btnGuardar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            label5 = new Label();
            txtStock = new TextBox();
            txtBuscar = new TextBox();
            txtImagePath = new TextBox();
            label7 = new Label();
            pictureBoxProducto = new PictureBox();
            btnImagen = new Button();
            ((System.ComponentModel.ISupportInitialize)productsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProducto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(16, 23);
            label1.Name = "label1";
            label1.Size = new Size(124, 27);
            label1.TabIndex = 1;
            label1.Text = "Productos";
            // 
            // productsTable
            // 
            productsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsTable.Location = new Point(16, 284);
            productsTable.Name = "productsTable";
            productsTable.RowHeadersWidth = 51;
            productsTable.Size = new Size(841, 359);
            productsTable.TabIndex = 13;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = SystemColors.Window;
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Location = new Point(117, 80);
            txtCodigo.Margin = new Padding(3, 2, 3, 2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(193, 23);
            txtCodigo.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.Window;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(117, 111);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(193, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = SystemColors.Window;
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.Location = new Point(374, 80);
            txtPrecio.Margin = new Padding(3, 2, 3, 2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(118, 23);
            txtPrecio.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = SystemColors.Window;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Location = new Point(117, 149);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(374, 23);
            txtDescripcion.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 82);
            label2.Name = "label2";
            label2.Size = new Size(54, 14);
            label2.TabIndex = 8;
            label2.Text = "Código:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label3.Location = new Point(24, 113);
            label3.Name = "label3";
            label3.Size = new Size(58, 14);
            label3.TabIndex = 9;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label4.Location = new Point(24, 152);
            label4.Name = "label4";
            label4.Size = new Size(80, 14);
            label4.TabIndex = 10;
            label4.Text = "Descripción:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label6.Location = new Point(315, 82);
            label6.Name = "label6";
            label6.Size = new Size(48, 14);
            label6.TabIndex = 12;
            label6.Text = "Precio:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaptionText;
            btnGuardar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnGuardar.ForeColor = SystemColors.ControlLight;
            btnGuardar.Location = new Point(136, 190);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(105, 31);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ActiveCaptionText;
            btnActualizar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnActualizar.ForeColor = SystemColors.ControlLight;
            btnActualizar.Location = new Point(247, 190);
            btnActualizar.Margin = new Padding(3, 2, 3, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(105, 31);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ActiveCaptionText;
            btnEliminar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnEliminar.ForeColor = SystemColors.ControlLight;
            btnEliminar.Location = new Point(357, 190);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(105, 31);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ActiveCaptionText;
            btnLimpiar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnLimpiar.ForeColor = SystemColors.ControlLight;
            btnLimpiar.Location = new Point(467, 190);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(105, 31);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label5.Location = new Point(315, 113);
            label5.Name = "label5";
            label5.Size = new Size(46, 14);
            label5.TabIndex = 18;
            label5.Text = "Stock:";
            // 
            // txtStock
            // 
            txtStock.BackColor = SystemColors.Window;
            txtStock.BorderStyle = BorderStyle.FixedSingle;
            txtStock.Location = new Point(374, 111);
            txtStock.Margin = new Padding(3, 2, 3, 2);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(118, 23);
            txtStock.TabIndex = 4;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = SystemColors.Window;
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Location = new Point(140, 244);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(403, 23);
            txtBuscar.TabIndex = 11;
            // 
            // txtImagePath
            // 
            txtImagePath.BackColor = SystemColors.Window;
            txtImagePath.BorderStyle = BorderStyle.FixedSingle;
            txtImagePath.Location = new Point(571, 80);
            txtImagePath.Margin = new Padding(3, 2, 3, 2);
            txtImagePath.Name = "txtImagePath";
            txtImagePath.Size = new Size(222, 23);
            txtImagePath.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label7.Location = new Point(506, 82);
            label7.Name = "label7";
            label7.Size = new Size(57, 14);
            label7.TabIndex = 22;
            label7.Text = "Imagen:";
            // 
            // pictureBoxProducto
            // 
            pictureBoxProducto.Location = new Point(662, 155);
            pictureBoxProducto.Margin = new Padding(3, 2, 3, 2);
            pictureBoxProducto.Name = "pictureBoxProducto";
            pictureBoxProducto.Size = new Size(132, 110);
            pictureBoxProducto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProducto.TabIndex = 23;
            pictureBoxProducto.TabStop = false;
            // 
            // btnImagen
            // 
            btnImagen.BackColor = SystemColors.ActiveCaptionText;
            btnImagen.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnImagen.ForeColor = SystemColors.ControlLight;
            btnImagen.Location = new Point(689, 111);
            btnImagen.Margin = new Padding(3, 2, 3, 2);
            btnImagen.Name = "btnImagen";
            btnImagen.Size = new Size(105, 31);
            btnImagen.TabIndex = 6;
            btnImagen.Text = "Subir";
            btnImagen.UseVisualStyleBackColor = false;
            btnImagen.Click += btnImagen_Click;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            Controls.Add(btnImagen);
            Controls.Add(pictureBoxProducto);
            Controls.Add(label7);
            Controls.Add(txtImagePath);
            Controls.Add(txtBuscar);
            Controls.Add(label5);
            Controls.Add(txtStock);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDescripcion);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(productsTable);
            Controls.Add(label1);
            Name = "Productos";
            Size = new Size(875, 665);
            ((System.ComponentModel.ISupportInitialize)productsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView productsTable;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtDescripcion;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Button btnGuardar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Label label5;
        private TextBox txtStock;
        private TextBox txtBuscar;
        private TextBox txtImagePath;
        private Label label7;
        private PictureBox pictureBoxProducto;
        private Button btnImagen;
    }
}
