namespace ProyectoFinalPOS.Clientes
{
    partial class Clientes
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
            customersTable = new DataGridView();
            txtBuscar = new TextBox();
            txtNIT = new TextBox();
            lblNit = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            lblDireccón = new Label();
            txtDireccion = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)customersTable).BeginInit();
            SuspendLayout();
            // 
            // customersTable
            // 
            customersTable.AllowUserToAddRows = false;
            customersTable.AllowUserToDeleteRows = false;
            customersTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customersTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customersTable.Location = new Point(16, 273);
            customersTable.Name = "customersTable";
            customersTable.ReadOnly = true;
            customersTable.RowHeadersWidth = 51;
            customersTable.Size = new Size(841, 374);
            customersTable.TabIndex = 1;
            // 
            // txtBuscar
            // 
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Location = new Point(16, 228);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(841, 23);
            txtBuscar.TabIndex = 2;
            // 
            // txtNIT
            // 
            txtNIT.BorderStyle = BorderStyle.FixedSingle;
            txtNIT.Location = new Point(102, 61);
            txtNIT.Name = "txtNIT";
            txtNIT.Size = new Size(100, 23);
            txtNIT.TabIndex = 4;
            // 
            // lblNit
            // 
            lblNit.AutoSize = true;
            lblNit.Location = new Point(27, 64);
            lblNit.Name = "lblNit";
            lblNit.Size = new Size(25, 15);
            lblNit.TabIndex = 5;
            lblNit.Text = "NIT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 102);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 6;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(339, 102);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 7;
            label3.Text = "Apellido:";
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(102, 94);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(231, 23);
            txtNombre.TabIndex = 8;
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Location = new Point(407, 94);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(231, 23);
            txtApellido.TabIndex = 9;
            // 
            // lblDireccón
            // 
            lblDireccón.AutoSize = true;
            lblDireccón.Location = new Point(27, 143);
            lblDireccón.Name = "lblDireccón";
            lblDireccón.Size = new Size(60, 15);
            lblDireccón.TabIndex = 10;
            lblDireccón.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            txtDireccion.Location = new Point(102, 135);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(231, 23);
            txtDireccion.TabIndex = 11;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(339, 143);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(55, 15);
            lblTelefono.TabIndex = 12;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Location = new Point(407, 135);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(231, 23);
            txtTelefono.TabIndex = 13;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(2, 16, 72);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(102, 176);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 31);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(2, 16, 72);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(314, 176);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 31);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(2, 16, 72);
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(208, 176);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(100, 31);
            btnActualizar.TabIndex = 17;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccón);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblNit);
            Controls.Add(txtNIT);
            Controls.Add(txtBuscar);
            Controls.Add(customersTable);
            Name = "Clientes";
            Size = new Size(875, 665);
            ((System.ComponentModel.ISupportInitialize)customersTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView customersTable;
        private TextBox txtBuscar;
        private TextBox txtNIT;
        private Label lblNit;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblDireccón;
        private TextBox txtDireccion;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnActualizar;
    }
}
