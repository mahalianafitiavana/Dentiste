using System;
using System.Windows.Forms;

namespace Dentiste
{
    public partial class Acceuil : Form
    {
        public Acceuil()
        {
            InitializeComponent();
        }

        private void Acceuil_Load(object sender, EventArgs e)
        {
            position(home);
        }
        private void position (Button button)
        {
            p.Location = new System.Drawing.Point(button.Location.X-p.Width,button.Location.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void quit_Click(object sender, EventArgs e)
        {
            position(quit);
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reduire_Paint(object sender, PaintEventArgs e)
        {

        }

        private void visit_Click(object sender, EventArgs e)
        {
            position(visit);
        }

        private void care_Click(object sender, EventArgs e)
        {
            position(this.care);
        }

        private void home_Click(object sender, EventArgs e)
        {
            position(this.home);
        }
    }
}
