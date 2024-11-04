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
            label1 = new Label();
            employeesTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)employeesTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F);
            label1.Location = new Point(16, 23);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 0;
            label1.Text = "Empleados";
            // 
            // employeesTable
            // 
            employeesTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            employeesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeesTable.Location = new Point(16, 284);
            employeesTable.Name = "employeesTable";
            employeesTable.Size = new Size(841, 359);
            employeesTable.TabIndex = 1;
            // 
            // Empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(employeesTable);
            Controls.Add(label1);
            Name = "Empleados";
            Size = new Size(875, 665);
            ((System.ComponentModel.ISupportInitialize)employeesTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView employeesTable;
    }
}
