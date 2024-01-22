using System;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Dentiste
{
    public partial class VisitForm : Form
    {
        IVisitServiceSignature service;
        public VisitForm(IVisitServiceSignature service)
        {
            InitializeComponent();
            this.service = service;
        }
        public NumericUpDown getinput(string name)
        {
            foreach (Control control in this.Controls)
            {
                if (control.Name == name && control is NumericUpDown)
                    return (NumericUpDown)control;
            }
            return null ;
        }
        public int[][] notelist()
        {
            int[][] notes = new int[4][]; // Initialiser le premier tableau avec une taille de 4
            for (int i = 0; i < 4; i++)
            {
                notes[i] = new int[8]; // Allouer chaque sous-tableau avec une taille de 8
                string input = "dent" + (i + 1);
                for (int j = 0; j < 8; j++)
                {
                    input += (j + 1).ToString();
                    if (this.getinput(input) != null)
                    notes[i][j] = int.Parse(this.getinput(input).Value.ToString());
                    Console.WriteLine((i + 1) + " " + (j + 1) + "  " + this.getinput(input).Name + "   " + this.getinput(input).Value.ToString());
                    input = "dent" + (i + 1);
                }
            }
            return notes;
        }


        private void ConsulForm_Load(object sender, EventArgs e)
        {

        }
        
        private void valider_Click(object sender, EventArgs e)
        {
            Connexion connexion = new Connexion();
            connexion.connect();
            VisitFormParams para = service.Build(connexion,this.notelist());
            service.Save(connexion, para);
            connexion.disconnect();
        }
    }
}
