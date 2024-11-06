namespace ProyectoFinalPOS.Recibo
{
    partial class ReciboForm
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
            lblEncabezado = new Label();
            lblFecha = new Label();
            lblTotal = new Label();
            flowLayoutPanelRecibo = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // lblEncabezado
            // 
            lblEncabezado.AutoSize = true;
            lblEncabezado.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEncabezado.ForeColor = Color.White;
            lblEncabezado.Location = new Point(12, 9);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(142, 18);
            lblEncabezado.TabIndex = 0;
            lblEncabezado.Text = "Recibo de Compra";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.ForeColor = Color.White;
            lblFecha.Location = new Point(414, 9);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(41, 16);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha";
            lblFecha.Click += lblFecha_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(335, 245);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(46, 18);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total";
            // 
            // flowLayoutPanelRecibo
            // 
            flowLayoutPanelRecibo.ForeColor = Color.White;
            flowLayoutPanelRecibo.Location = new Point(12, 42);
            flowLayoutPanelRecibo.Name = "flowLayoutPanelRecibo";
            flowLayoutPanelRecibo.Size = new Size(575, 183);
            flowLayoutPanelRecibo.TabIndex = 4;
            // 
            // ReciboForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 42, 60);
            ClientSize = new Size(599, 281);
            Controls.Add(flowLayoutPanelRecibo);
            Controls.Add(lblTotal);
            Controls.Add(lblFecha);
            Controls.Add(lblEncabezado);
            Name = "ReciboForm";
            Text = "Recibo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEncabezado;
        private Label lblFecha;
        private Label lblTotal;
        private FlowLayoutPanel flowLayoutPanelRecibo;
    }
}