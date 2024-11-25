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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblEncabezado
            // 
            lblEncabezado.AutoSize = true;
            lblEncabezado.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEncabezado.ForeColor = Color.White;
            lblEncabezado.Location = new Point(234, 111);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(184, 23);
            lblEncabezado.TabIndex = 0;
            lblEncabezado.Text = "Recibo de Compra";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.ForeColor = Color.White;
            lblFecha.Location = new Point(234, 144);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(54, 21);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha";
            lblFecha.Click += lblFecha_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(473, 636);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(59, 23);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total";
            // 
            // flowLayoutPanelRecibo
            // 
            flowLayoutPanelRecibo.ForeColor = Color.White;
            flowLayoutPanelRecibo.Location = new Point(14, 204);
            flowLayoutPanelRecibo.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanelRecibo.Name = "flowLayoutPanelRecibo";
            flowLayoutPanelRecibo.Size = new Size(657, 392);
            flowLayoutPanelRecibo.TabIndex = 4;
            // 
            // buttonCompletar
            // 
            buttonCompletar.BackColor = Color.FromArgb(0, 119, 70);
            buttonCompletar.FlatStyle = FlatStyle.Popup;
            buttonCompletar.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCompletar.ForeColor = SystemColors.ButtonHighlight;
            buttonCompletar.Location = new Point(14, 629);
            buttonCompletar.Margin = new Padding(3, 4, 3, 4);
            buttonCompletar.Name = "buttonCompletar";
            buttonCompletar.Size = new Size(158, 38);
            buttonCompletar.TabIndex = 5;
            buttonCompletar.Text = "Cerrar";
            buttonCompletar.UseVisualStyleBackColor = false;
            buttonCompletar.Click += buttonCompletar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ecoMarket;
            pictureBox1.Location = new Point(247, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // ReciboForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 42, 60);
            ClientSize = new Size(685, 680);
            Controls.Add(pictureBox1);
            Controls.Add(buttonCompletar);
            Controls.Add(flowLayoutPanelRecibo);
            Controls.Add(lblTotal);
            Controls.Add(lblFecha);
            Controls.Add(lblEncabezado);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReciboForm";
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
    }
}