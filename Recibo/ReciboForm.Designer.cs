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
            buttonCompletar = new Button();
            pictureBox1 = new PictureBox();
            lblCliente = new Label();
            lblNit = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblEncabezado
            // 
            lblEncabezado.AutoSize = true;
            lblEncabezado.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEncabezado.ForeColor = Color.White;
            lblEncabezado.Location = new Point(205, 83);
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
            lblFecha.Location = new Point(205, 108);
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
            lblTotal.Location = new Point(414, 477);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(46, 18);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total";
            // 
            // flowLayoutPanelRecibo
            // 
            flowLayoutPanelRecibo.ForeColor = Color.White;
            flowLayoutPanelRecibo.Location = new Point(12, 188);
            flowLayoutPanelRecibo.Name = "flowLayoutPanelRecibo";
            flowLayoutPanelRecibo.Size = new Size(575, 259);
            flowLayoutPanelRecibo.TabIndex = 4;
            // 
            // buttonCompletar
            // 
            buttonCompletar.BackColor = Color.FromArgb(0, 119, 70);
            buttonCompletar.FlatStyle = FlatStyle.Popup;
            buttonCompletar.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCompletar.ForeColor = SystemColors.ButtonHighlight;
            buttonCompletar.Location = new Point(12, 472);
            buttonCompletar.Name = "buttonCompletar";
            buttonCompletar.Size = new Size(138, 28);
            buttonCompletar.TabIndex = 5;
            buttonCompletar.Text = "Cerrar";
            buttonCompletar.UseVisualStyleBackColor = false;
            buttonCompletar.Click += buttonCompletar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ecoMarket;
            pictureBox1.Location = new Point(216, 12);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = Color.White;
            lblCliente.Location = new Point(205, 124);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(51, 16);
            lblCliente.TabIndex = 7;
            lblCliente.Text = "Cliente:";
            // 
            // lblNit
            // 
            lblNit.AutoSize = true;
            lblNit.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNit.ForeColor = Color.White;
            lblNit.Location = new Point(205, 140);
            lblNit.Name = "lblNit";
            lblNit.Size = new Size(32, 16);
            lblNit.TabIndex = 8;
            lblNit.Text = "NIT:";
            // 
            // ReciboForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 42, 60);
            ClientSize = new Size(599, 510);
            Controls.Add(lblNit);
            Controls.Add(lblCliente);
            Controls.Add(pictureBox1);
            Controls.Add(buttonCompletar);
            Controls.Add(flowLayoutPanelRecibo);
            Controls.Add(lblTotal);
            Controls.Add(lblFecha);
            Controls.Add(lblEncabezado);
            Name = "ReciboForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recibo";
            Load += ReciboForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEncabezado;
        private Label lblFecha;
        private Label lblTotal;
        private FlowLayoutPanel flowLayoutPanelRecibo;
        private Button buttonCompletar;
        private PictureBox pictureBox1;
        private Label lblCliente;
        private Label lblNit;
    }
}