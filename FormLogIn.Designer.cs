
namespace ProyectoFinalPOS
{
    partial class FormLogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            textBoxUsuario = new TextBox();
            textBoxPassword = new TextBox();
            buttonIngresar = new Button();
            label3 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            btnClose = new Button();
            panel2 = new Panel();
            checkBox1 = new CheckBox();
            btnCerrar = new Button();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BorderStyle = BorderStyle.None;
            textBoxUsuario.Font = new Font("Century Gothic", 10F);
            textBoxUsuario.ForeColor = Color.FromArgb(41, 128, 185);
            textBoxUsuario.Location = new Point(63, 5);
            textBoxUsuario.Multiline = true;
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.PlaceholderText = "Ingresar Usuario";
            textBoxUsuario.RightToLeft = RightToLeft.No;
            textBoxUsuario.Size = new Size(423, 47);
            textBoxUsuario.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.ForeColor = Color.FromArgb(41, 128, 185);
            textBoxPassword.Location = new Point(65, 5);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.PlaceholderText = "Ingresar Contraseña";
            textBoxPassword.Size = new Size(423, 47);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonIngresar
            // 
            buttonIngresar.BackColor = Color.DarkOliveGreen;
            buttonIngresar.FlatStyle = FlatStyle.Flat;
            buttonIngresar.Font = new Font("Tahoma", 14F);
            buttonIngresar.ForeColor = Color.White;
            buttonIngresar.Location = new Point(65, 428);
            buttonIngresar.Name = "buttonIngresar";
            buttonIngresar.Size = new Size(393, 65);
            buttonIngresar.TabIndex = 5;
            buttonIngresar.Text = "Ingresar";
            buttonIngresar.UseVisualStyleBackColor = false;
            buttonIngresar.Click += buttonIngresar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.ForeColor = Color.DarkOliveGreen;
            label3.Location = new Point(43, 180);
            label3.Name = "label3";
            label3.Size = new Size(172, 37);
            label3.TabIndex = 6;
            label3.Text = "Iniciar Sesión";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 707);
            panel1.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(216, 633);
            label8.Name = "label8";
            label8.Size = new Size(115, 19);
            label8.TabIndex = 5;
            label8.Text = "Group #3 USPG";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(216, 612);
            label7.Name = "label7";
            label7.Size = new Size(91, 19);
            label7.TabIndex = 4;
            label7.Text = "Develop By ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(203, 442);
            label6.Name = "label6";
            label6.Size = new Size(128, 33);
            label6.TabIndex = 3;
            label6.Text = "Servicios";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(68, 392);
            label5.Name = "label5";
            label5.Size = new Size(269, 33);
            label5.TabIndex = 2;
            label5.Text = "Sistema Gestión de";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(125, 340);
            label4.Name = "label4";
            label4.Size = new Size(206, 33);
            label4.TabIndex = 1;
            label4.Text = "Bienvenidos al";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logomarket;
            pictureBox1.Location = new Point(55, 37);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 208);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.FromArgb(41, 128, 185);
            btnClose.Location = new Point(811, 0);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(46, 53);
            btnClose.TabIndex = 8;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(buttonIngresar);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(343, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(514, 707);
            panel2.TabIndex = 9;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(386, 381);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(129, 22);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Ver contraseña";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.DarkOliveGreen;
            btnCerrar.Location = new Point(467, 1);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(46, 53);
            btnCerrar.TabIndex = 9;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(textBoxPassword);
            panel4.Location = new Point(8, 313);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(496, 59);
            panel4.TabIndex = 8;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(17, 15);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 32);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(textBoxUsuario);
            panel3.ForeColor = SystemColors.AppWorkspace;
            panel3.Location = new Point(8, 247);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(496, 59);
            panel3.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(17, 15);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 32);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // FormLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 707);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(btnClose);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar Sesión";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }


        #endregion
        private TextBox textBoxUsuario;
        private TextBox textBoxPassword;
        private Button buttonIngresar;
        private Label label3;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label7;
        private Button btnClose;
        private Panel panel2;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Button btnCerrar;
        private CheckBox checkBox1;
    }
}
