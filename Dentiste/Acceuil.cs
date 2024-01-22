﻿using System;
using System.Drawing;
using System.Windows.Forms;
using MouveForm;
namespace Dentiste
{
    public partial class Acceuil : Form
    {

        public Acceuil()
        {
            InitializeComponent();
        }

        private void Active(Button button)
        {
            foreach (Control ctr in navbar.Controls)
                if (ctr.GetType() == typeof(Button))
                    if (ctr.Name == button.Name)
                        button.BackColor = ColorTranslator.FromHtml("#66abf1");
                    else
                        ctr.BackColor = Color.FromArgb(20, 40, 64);
                        button.ForeColor = Color.White;
        }


        private void Acceuil_Load(object sender, EventArgs e)
        {
            MouveForm.Mouve.Go(reduire);
            p.Height = home.Height;
            position(home);
            Active(home);
        }
        private void position (Button button)
        {
            p.Location = new System.Drawing.Point(button.Location.X-p.Width,button.Location.Y);
        }

        /// <summary>
        /// BUTTON
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void visit_Click(object sender, EventArgs e)
        {
            position(visit);
            Active(visit);
            VisitService serice = new VisitService();
            VisitForm c = new VisitForm(serice);
            c.Show();
        }

        private void care_Click(object sender, EventArgs e)
        {
            position(this.care);
            Active(care);
        }

        private void client_Click(object sender, EventArgs e)
        {
            position(this.client);
            Active(client);
        }
        private void home_Click(object sender, EventArgs e)
        {
            position(this.home);
            Active(home);
        }

    }
}
