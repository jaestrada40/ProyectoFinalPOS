using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalPOS
{
    public partial class ToastForm : Form
    {
        int toastX, toastY;
        public ToastForm(string type, string message)
        {
            InitializeComponent();
            lbType.Text = type;
            lbMessage.Text = message;

            switch (type)
            {
                case "Miembros":
                    toastBorder.BackColor = Color.FromArgb(57, 155, 53);
                    //picIcon.Image = Properties.Resources.AddMember;
                    break;
                case "Gestionar Libros":
                    toastBorder.BackColor = Color.FromArgb(227, 50, 43);
                    //picIcon.Image = Properties.Resources.Book;
                    break;
                case "Realizar Préstamo":
                    toastBorder.BackColor = Color.FromArgb(18, 136, 192);
                    //picIcon.Image = Properties.Resources.prestarLibro;
                    break;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ToastForm_Load(object sender, EventArgs e)
        {
            Position();
        }
        private void Position()
        {
            int ScreenWidht = Screen.PrimaryScreen.WorkingArea.Width;
            int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            toastX = ScreenWidht - this.Width - 5;
            toastY = ScreenHeight - this.Height + 70;

            this.Location = new Point(toastX, toastY);

        }
        private void toastTimer_Tick(object sender, EventArgs e)
        {
            toastY -= 10;
            this.Location = new Point(toastX, toastY);
            if (toastY <= 960)
            {
                toastTimer.Stop();
                toastHide.Start();
            }
        }
        int y = 100;
        private void toastHide_Tick(object sender, EventArgs e)
        {
            y--;
            if (y <= 0)
            {
                toastY += 1;
                this.Location = new Point(toastX, toastY += 10);
                if (toastY > 800)
                {
                    toastHide.Stop();
                    y = 100;
                    this.Close();
                }
            }
        }
    }
}
