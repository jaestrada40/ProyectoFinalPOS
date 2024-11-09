namespace ProyectoFinalPOS
{
    partial class ToastForm
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
            components = new System.ComponentModel.Container();
            toastBorder = new Panel();
            picIcon = new PictureBox();
            lbType = new Label();
            lbMessage = new Label();
            toastTimer = new System.Windows.Forms.Timer(components);
            toastHide = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            SuspendLayout();
            // 
            // toastBorder
            // 
            toastBorder.BackColor = Color.YellowGreen;
            toastBorder.Location = new Point(-1, 0);
            toastBorder.Name = "toastBorder";
            toastBorder.Size = new Size(10, 77);
            toastBorder.TabIndex = 0;
            // 
            // picIcon
            // 
            picIcon.Location = new Point(21, 12);
            picIcon.Name = "picIcon";
            picIcon.Size = new Size(44, 42);
            picIcon.TabIndex = 1;
            picIcon.TabStop = false;
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbType.Location = new Point(99, 16);
            lbType.Name = "lbType";
            lbType.Size = new Size(42, 20);
            lbType.TabIndex = 2;
            lbType.Text = "Type";
            // 
            // lbMessage
            // 
            lbMessage.AutoSize = true;
            lbMessage.Location = new Point(99, 46);
            lbMessage.Name = "lbMessage";
            lbMessage.Size = new Size(67, 20);
            lbMessage.TabIndex = 3;
            lbMessage.Text = "Message";
            lbMessage.Click += label2_Click;
            // 
            // ToastForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 75);
            Controls.Add(lbMessage);
            Controls.Add(lbType);
            Controls.Add(picIcon);
            Controls.Add(toastBorder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ToastForm";
            Text = "ToastForm";
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel toastBorder;
        private PictureBox picIcon;
        private Label lbType;
        private Label lbMessage;
        private System.Windows.Forms.Timer toastTimer;
        private System.Windows.Forms.Timer toastHide;
    }
}