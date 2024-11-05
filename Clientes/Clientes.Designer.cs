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
            label1 = new Label();
            customersTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)customersTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 31);
            label1.Name = "label1";
            label1.Size = new Size(107, 33);
            label1.TabIndex = 0;
            label1.Text = "Clientes";
            // 
            // customersTable
            // 
            customersTable.AllowUserToAddRows = false;
            customersTable.AllowUserToDeleteRows = false;
            customersTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customersTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customersTable.Location = new Point(18, 379);
            customersTable.Margin = new Padding(3, 4, 3, 4);
            customersTable.Name = "customersTable";
            customersTable.ReadOnly = true;
            customersTable.RowHeadersWidth = 51;
            customersTable.Size = new Size(961, 479);
            customersTable.TabIndex = 1;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(customersTable);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Clientes";
            Size = new Size(1000, 887);
            ((System.ComponentModel.ISupportInitialize)customersTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView customersTable;
    }
}
