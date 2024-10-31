
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
            textBoxUsuario = new TextBox();
            textBoxPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonIngresar = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(61, 186);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.PlaceholderText = "Ingresar Usuario";
            textBoxUsuario.Size = new Size(393, 27);
            textBoxUsuario.TabIndex = 1;
            textBoxUsuario.Text = " ";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(61, 261);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(393, 27);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.Text = " ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 163);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 3;
            label1.Text = "Nombre de Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 238);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // buttonIngresar
            // 
            buttonIngresar.Location = new Point(61, 316);
            buttonIngresar.Name = "buttonIngresar";
            buttonIngresar.Size = new Size(393, 38);
            buttonIngresar.TabIndex = 5;
            buttonIngresar.Text = "Ingresar";
            buttonIngresar.UseVisualStyleBackColor = true;
            buttonIngresar.Click += buttonIngresar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(61, 81);
            label3.Name = "label3";
            label3.Size = new Size(172, 37);
            label3.TabIndex = 6;
            label3.Text = "Iniciar Sesión";
            // 
            // FormLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 450);
            Controls.Add(label3);
            Controls.Add(buttonIngresar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsuario);
            Name = "FormLogIn";
            Text = "Iniciar Sesión";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private TextBox textBoxUsuario;
        private TextBox textBoxPassword;
        private Label label1;
        private Label label2;
        private Button buttonIngresar;
        private Label label3;
    }
}
