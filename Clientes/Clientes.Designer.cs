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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            lblCliente = new Label();
            btnLimiarCampos = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)customersTable).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // customersTable
            // 
            customersTable.AllowUserToAddRows = false;
            customersTable.AllowUserToDeleteRows = false;
            customersTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customersTable.BackgroundColor = Color.Gray;
            customersTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            customersTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            customersTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 11F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            customersTable.DefaultCellStyle = dataGridViewCellStyle2;
            customersTable.GridColor = SystemColors.InactiveCaption;
            customersTable.Location = new Point(18, 364);
            customersTable.Margin = new Padding(3, 4, 3, 4);
            customersTable.Name = "customersTable";
            customersTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            customersTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            customersTable.RowHeadersWidth = 51;
            customersTable.Size = new Size(961, 499);
            customersTable.TabIndex = 1;
            // 
            // txtBuscar
            // 
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Location = new Point(18, 304);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(961, 27);
            txtBuscar.TabIndex = 2;
            // 
            // txtNIT
            // 
            txtNIT.BorderStyle = BorderStyle.FixedSingle;
            txtNIT.CharacterCasing = CharacterCasing.Upper;
            txtNIT.Location = new Point(104, 95);
            txtNIT.Margin = new Padding(3, 4, 3, 4);
            txtNIT.Name = "txtNIT";
            txtNIT.Size = new Size(114, 27);
            txtNIT.TabIndex = 4;
            // 
            // lblNit
            // 
            lblNit.AutoSize = true;
            lblNit.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblNit.Location = new Point(18, 99);
            lblNit.Name = "lblNit";
            lblNit.Size = new Size(36, 18);
            lblNit.TabIndex = 5;
            lblNit.Text = "NIT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label2.Location = new Point(18, 149);
            label2.Name = "label2";
            label2.Size = new Size(72, 18);
            label2.TabIndex = 6;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label3.Location = new Point(375, 149);
            label3.Name = "label3";
            label3.Size = new Size(74, 18);
            label3.TabIndex = 7;
            label3.Text = "Apellido:";
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(104, 139);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(264, 27);
            txtNombre.TabIndex = 8;
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Location = new Point(453, 139);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(264, 27);
            txtApellido.TabIndex = 9;
            // 
            // lblDireccón
            // 
            lblDireccón.AutoSize = true;
            lblDireccón.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblDireccón.Location = new Point(18, 204);
            lblDireccón.Name = "lblDireccón";
            lblDireccón.Size = new Size(84, 18);
            lblDireccón.TabIndex = 10;
            lblDireccón.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            txtDireccion.Location = new Point(104, 193);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(264, 27);
            txtDireccion.TabIndex = 11;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblTelefono.Location = new Point(375, 204);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(78, 18);
            lblTelefono.TabIndex = 12;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Location = new Point(453, 193);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(264, 27);
            txtTelefono.TabIndex = 13;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(37, 42, 60);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(104, 248);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(114, 41);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            //btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(37, 42, 60);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(346, 248);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(114, 41);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            //btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(37, 42, 60);
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(225, 248);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(114, 41);
            btnActualizar.TabIndex = 17;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            //btnActualizar.Click += btnActualizar_Click;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = Color.White;
            lblCliente.Location = new Point(18, 19);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(283, 29);
            lblCliente.TabIndex = 18;
            lblCliente.Text = "Mantenimiento Cliente";
            // 
            // btnLimiarCampos
            // 
            btnLimiarCampos.BackColor = Color.FromArgb(37, 42, 60);
            btnLimiarCampos.Cursor = Cursors.Hand;
            btnLimiarCampos.FlatStyle = FlatStyle.Flat;
            btnLimiarCampos.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            btnLimiarCampos.ForeColor = Color.White;
            btnLimiarCampos.Location = new Point(467, 248);
            btnLimiarCampos.Margin = new Padding(3, 4, 3, 4);
            btnLimiarCampos.Name = "btnLimiarCampos";
            btnLimiarCampos.Size = new Size(114, 41);
            btnLimiarCampos.TabIndex = 19;
            btnLimiarCampos.Text = "Limpiar";
            btnLimiarCampos.UseVisualStyleBackColor = false;
            //btnLimiarCampos.Click += btnLimiarCampos_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 119, 70);
            panel1.Controls.Add(lblCliente);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 73);
            panel1.TabIndex = 20;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(btnLimiarCampos);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "Clientes";
            Size = new Size(1000, 887);
            ((System.ComponentModel.ISupportInitialize)customersTable).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label lblCliente;
        private Button btnLimiarCampos;
        private Panel panel1;
    }
}
