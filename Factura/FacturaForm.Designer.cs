namespace ProyectoFinalPOS.Factura
{
    partial class FacturaForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblCliente = new Label();
            lblEmpleado = new Label();
            lblNIT = new Label();
            lblTotal = new Label();
            facturaTable = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)facturaTable).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Tahoma", 9F);
            lblCliente.Location = new Point(125, 47);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(109, 14);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Nombre de Cliente";
            lblCliente.Click += lblCliente_Click;
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Font = new Font("Tahoma", 9F);
            lblEmpleado.Location = new Point(125, 19);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(125, 14);
            lblEmpleado.TabIndex = 2;
            lblEmpleado.Text = "Nombre de Empleado";
            // 
            // lblNIT
            // 
            lblNIT.AutoSize = true;
            lblNIT.Font = new Font("Tahoma", 9F);
            lblNIT.Location = new Point(125, 75);
            lblNIT.Name = "lblNIT";
            lblNIT.Size = new Size(27, 14);
            lblNIT.TabIndex = 3;
            lblNIT.Text = "NIT";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Tahoma", 9F);
            lblTotal.Location = new Point(125, 103);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(35, 14);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total";
            // 
            // facturaTable
            // 
            facturaTable.AllowUserToAddRows = false;
            facturaTable.AllowUserToDeleteRows = false;
            facturaTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            facturaTable.BackgroundColor = SystemColors.GrayText;
            facturaTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            facturaTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            facturaTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 11F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            facturaTable.DefaultCellStyle = dataGridViewCellStyle2;
            facturaTable.GridColor = SystemColors.InactiveCaption;
            facturaTable.Location = new Point(12, 134);
            facturaTable.Name = "facturaTable";
            facturaTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            facturaTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            facturaTable.RowHeadersWidth = 51;
            facturaTable.Size = new Size(776, 304);
            facturaTable.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label1.Location = new Point(40, 19);
            label1.Name = "label1";
            label1.Size = new Size(70, 14);
            label1.TabIndex = 43;
            label1.Text = "Empleado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label2.Location = new Point(40, 47);
            label2.Name = "label2";
            label2.Size = new Size(53, 14);
            label2.TabIndex = 44;
            label2.Text = "Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label3.Location = new Point(40, 103);
            label3.Name = "label3";
            label3.Size = new Size(42, 14);
            label3.TabIndex = 45;
            label3.Text = "Total:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label4.Location = new Point(40, 75);
            label4.Name = "label4";
            label4.Size = new Size(31, 14);
            label4.TabIndex = 46;
            label4.Text = "NIT:";
            // 
            // FacturaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(facturaTable);
            Controls.Add(lblTotal);
            Controls.Add(lblNIT);
            Controls.Add(lblEmpleado);
            Controls.Add(lblCliente);
            Name = "FacturaForm";
            Text = "Factura";
            Load += FacturaForm_Load;
            ((System.ComponentModel.ISupportInitialize)facturaTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCliente;
        private Label lblEmpleado;
        private Label lblNIT;
        private Label lblTotal;
        private DataGridView facturaTable;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}