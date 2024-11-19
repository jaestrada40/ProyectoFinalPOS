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
            btnBuscar = new PictureBox();
            txtImagePath = new TextBox();
            label7 = new Label();
            pictureBoxProducto = new PictureBox();
            btnImagen = new Button();
            ((System.ComponentModel.ISupportInitialize)productsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProducto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(18, 31);
            label1.Name = "label1";
            label1.Size = new Size(156, 34);
            label1.TabIndex = 1;
            label1.Text = "Productos";
            // 
            // productsTable
            // 
            productsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsTable.Location = new Point(18, 379);
            productsTable.Margin = new Padding(3, 4, 3, 4);
            productsTable.Name = "productsTable";
            productsTable.RowHeadersWidth = 51;
            productsTable.Size = new Size(961, 479);
            productsTable.TabIndex = 2;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = SystemColors.Window;
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Location = new Point(134, 106);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(220, 27);
            txtCodigo.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.Window;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(134, 148);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(220, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = SystemColors.Window;
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.Location = new Point(427, 107);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(134, 27);
            txtPrecio.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = SystemColors.Window;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Location = new Point(134, 199);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(427, 27);
            txtDescripcion.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 110);
            label2.Name = "label2";
            label2.Size = new Size(64, 18);
            label2.TabIndex = 8;
            label2.Text = "Código:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label3.Location = new Point(27, 151);
            label3.Name = "label3";
            label3.Size = new Size(72, 18);
            label3.TabIndex = 9;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label4.Location = new Point(27, 202);
            label4.Name = "label4";
            label4.Size = new Size(101, 18);
            label4.TabIndex = 10;
            label4.Text = "Descripción:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label6.Location = new Point(360, 110);
            label6.Name = "label6";
            label6.Size = new Size(61, 18);
            label6.TabIndex = 12;
            label6.Text = "Precio:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaptionText;
            btnGuardar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnGuardar.ForeColor = SystemColors.ControlLight;
            btnGuardar.Location = new Point(156, 254);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 41);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ActiveCaptionText;
            btnActualizar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnActualizar.ForeColor = SystemColors.ControlLight;
            btnActualizar.Location = new Point(282, 254);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(120, 41);
            btnActualizar.TabIndex = 14;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ActiveCaptionText;
            btnEliminar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnEliminar.ForeColor = SystemColors.ControlLight;
            btnEliminar.Location = new Point(408, 254);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 41);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ActiveCaptionText;
            btnLimpiar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnLimpiar.ForeColor = SystemColors.ControlLight;
            btnLimpiar.Location = new Point(534, 254);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(120, 41);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label5.Location = new Point(360, 151);
            label5.Name = "label5";
            label5.Size = new Size(55, 18);
            label5.TabIndex = 18;
            label5.Text = "Stock:";
            // 
            // txtStock
            // 
            txtStock.BackColor = SystemColors.Window;
            txtStock.BorderStyle = BorderStyle.FixedSingle;
            txtStock.Location = new Point(427, 148);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(134, 27);
            txtStock.TabIndex = 17;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = SystemColors.Window;
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Location = new Point(160, 326);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(460, 27);
            txtBuscar.TabIndex = 19;
            // 
            // btnBuscar
            // 
            btnBuscar.Image = Properties.Resources.search_12_24;
            btnBuscar.Location = new Point(630, 326);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(24, 24);
            btnBuscar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnBuscar.TabIndex = 20;
            btnBuscar.TabStop = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtImagePath
            // 
            txtImagePath.BackColor = SystemColors.Window;
            txtImagePath.BorderStyle = BorderStyle.FixedSingle;
            txtImagePath.Location = new Point(653, 107);
            txtImagePath.Name = "txtImagePath";
            txtImagePath.Size = new Size(254, 27);
            txtImagePath.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label7.Location = new Point(578, 109);
            label7.Name = "label7";
            label7.Size = new Size(69, 18);
            label7.TabIndex = 22;
            label7.Text = "Imagen:";
            // 
            // pictureBoxProducto
            // 
            pictureBoxProducto.Location = new Point(756, 207);
            pictureBoxProducto.Name = "pictureBoxProducto";
            pictureBoxProducto.Size = new Size(151, 146);
            pictureBoxProducto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProducto.TabIndex = 23;
            pictureBoxProducto.TabStop = false;
            // 
            // btnImagen
            // 
            btnImagen.BackColor = SystemColors.ActiveCaptionText;
            btnImagen.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnImagen.ForeColor = SystemColors.ControlLight;
            btnImagen.Location = new Point(787, 148);
            btnImagen.Name = "btnImagen";
            btnImagen.Size = new Size(120, 41);
            btnImagen.TabIndex = 24;
            btnImagen.Text = "Subir";
            btnImagen.UseVisualStyleBackColor = false;
            btnImagen.Click += btnImagen_Click;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            Controls.Add(btnImagen);
            Controls.Add(pictureBoxProducto);
            Controls.Add(label7);
            Controls.Add(txtImagePath);
            Controls.Add(btnBuscar);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "Productos";
            Size = new Size(1000, 887);
            ((System.ComponentModel.ISupportInitialize)productsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBuscar).EndInit();
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
        private PictureBox btnBuscar;
        private TextBox txtImagePath;
        private Label label7;
        private PictureBox pictureBoxProducto;
        private Button btnImagen;
    }
}
