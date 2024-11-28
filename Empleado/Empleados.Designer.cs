namespace ProyectoFinalPOS.Empleado
{
    partial class Empleados
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
            panel1 = new Panel();
            lblEmpleados = new Label();
            btnLimiarCampos = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsername = new TextBox();
            lblUsuario = new Label();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            lblID = new Label();
            txtID = new TextBox();
            txtBuscar = new TextBox();
            txtPosition = new TextBox();
            lblPosition = new Label();
            employeesTable = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeesTable).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 119, 70);
            panel1.Controls.Add(lblEmpleados);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(875, 55);
            panel1.TabIndex = 36;
            // 
            // lblEmpleados
            // 
            lblEmpleados.AutoSize = true;
            lblEmpleados.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmpleados.ForeColor = Color.White;
            lblEmpleados.Location = new Point(16, 14);
            lblEmpleados.Name = "lblEmpleados";
            lblEmpleados.Size = new Size(254, 23);
            lblEmpleados.TabIndex = 18;
            lblEmpleados.Text = "Mantenimiento Empleado";
            // 
            // btnLimiarCampos
            // 
            btnLimiarCampos.BackColor = Color.FromArgb(37, 42, 60);
            btnLimiarCampos.Cursor = Cursors.Hand;
            btnLimiarCampos.FlatStyle = FlatStyle.Flat;
            btnLimiarCampos.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            btnLimiarCampos.ForeColor = Color.White;
            btnLimiarCampos.Location = new Point(409, 199);
            btnLimiarCampos.Name = "btnLimiarCampos";
            btnLimiarCampos.Size = new Size(100, 31);
            btnLimiarCampos.TabIndex = 10;
            btnLimiarCampos.Text = "Limpiar";
            btnLimiarCampos.UseVisualStyleBackColor = false;
            btnLimiarCampos.Click += btnLimiarCampos_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(37, 42, 60);
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(197, 199);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(100, 31);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(37, 42, 60);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(303, 199);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 31);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(37, 42, 60);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(91, 199);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 31);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(416, 144);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(231, 23);
            txtPassword.TabIndex = 6;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblPassword.Location = new Point(328, 149);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(81, 14);
            lblPassword.TabIndex = 30;
            lblPassword.Text = "Contraseña:";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(91, 144);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(231, 23);
            txtUsername.TabIndex = 5;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblUsuario.Location = new Point(16, 152);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(56, 14);
            lblUsuario.TabIndex = 28;
            lblUsuario.Text = "Usuario:";
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Location = new Point(416, 69);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(231, 23);
            txtApellido.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(91, 69);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(231, 23);
            txtNombre.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label3.Location = new Point(328, 75);
            label3.Name = "label3";
            label3.Size = new Size(60, 14);
            label3.TabIndex = 25;
            label3.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label2.Location = new Point(16, 77);
            label2.Name = "label2";
            label2.Size = new Size(58, 14);
            label2.TabIndex = 24;
            label2.Text = "Nombre:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblID.Location = new Point(16, 109);
            lblID.Name = "lblID";
            lblID.Size = new Size(45, 14);
            lblID.TabIndex = 23;
            lblID.Text = "No. ID";
            // 
            // txtID
            // 
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Location = new Point(91, 106);
            txtID.Name = "txtID";
            txtID.Size = new Size(231, 23);
            txtID.TabIndex = 3;
            // 
            // txtBuscar
            // 
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Location = new Point(16, 241);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(841, 23);
            txtBuscar.TabIndex = 11;
            // 
            // txtPosition
            // 
            txtPosition.BorderStyle = BorderStyle.FixedSingle;
            txtPosition.Location = new Point(416, 106);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(231, 23);
            txtPosition.TabIndex = 4;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblPosition.Location = new Point(328, 112);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(47, 14);
            lblPosition.TabIndex = 37;
            lblPosition.Text = "Cargo:";
            // 
            // employeesTable
            // 
            employeesTable.AllowUserToAddRows = false;
            employeesTable.AllowUserToDeleteRows = false;
            employeesTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            employeesTable.BackgroundColor = Color.Gray;
            employeesTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            employeesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            employeesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 11F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            employeesTable.DefaultCellStyle = dataGridViewCellStyle2;
            employeesTable.GridColor = SystemColors.InactiveCaption;
            employeesTable.Location = new Point(17, 280);
            employeesTable.Name = "employeesTable";
            employeesTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            employeesTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            employeesTable.RowHeadersWidth = 51;
            employeesTable.Size = new Size(841, 374);
            employeesTable.TabIndex = 39;
            // 
            // Empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(employeesTable);
            Controls.Add(txtPosition);
            Controls.Add(lblPosition);
            Controls.Add(panel1);
            Controls.Add(btnLimiarCampos);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsuario);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblID);
            Controls.Add(txtID);
            Controls.Add(txtBuscar);
            Name = "Empleados";
            Size = new Size(875, 664);
            Load += Empleados_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)employeesTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label lblEmpleados;
        private Button btnLimiarCampos;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnGuardar;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUsername;
        private Label lblUsuario;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Label lblID;
        private TextBox txtID;
        private TextBox txtBuscar;
        private TextBox txtPosition;
        private Label lblPosition;
        private DataGridView employeesTable;
    }
}
