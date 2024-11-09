namespace ProyectoFinalPOS
{
    partial class FormularioPrueba
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            btnDashboar = new Button();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 42, 60);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1164, 38);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(37, 42, 60);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnDashboar);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 673);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(250, 38);
            panel3.Name = "panel3";
            panel3.Size = new Size(914, 673);
            panel3.TabIndex = 2;
            // 
            // btnDashboar
            // 
            btnDashboar.FlatAppearance.BorderSize = 0;
            btnDashboar.FlatStyle = FlatStyle.Flat;
            btnDashboar.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboar.ForeColor = Color.White;
            btnDashboar.Image = Properties.Resources.administrator_2_32;
            btnDashboar.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboar.Location = new Point(12, 206);
            btnDashboar.Name = "btnDashboar";
            btnDashboar.Size = new Size(212, 44);
            btnDashboar.TabIndex = 0;
            btnDashboar.Text = "Dashboard";
            btnDashboar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.administrator_2_32;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(12, 266);
            button1.Name = "button1";
            button1.Size = new Size(212, 44);
            button1.TabIndex = 1;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoLogin;
            pictureBox1.Location = new Point(12, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 110);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // FormularioPrueba
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 711);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormularioPrueba";
            Text = "FormularioPrueba";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnDashboar;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
    }
}