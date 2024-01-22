using System;
using System.Windows.Forms;

namespace Dentiste
{
    public partial class ClientForm : Form
    {
        Client client;
        Visit visit;
        public Client Client { get => client; set => client = value; }
        public Visit Visit { get => visit; set => visit = value; }
        public ClientForm()
        {
            InitializeComponent();
        }

        public ClientForm(Client client, Visit visit)
        {
            this.Client = client;
            this.Visit = visit;
        }

        public Client buildClient (String name , DateTime birth, Connexion connexion)
        {
            Client c = new Client();
            c.insert(connexion);
            return c;
        }

        private void newclient_Click(object sender, EventArgs e)
        {
            this.Client = this.buildClient(this.name.Text, this.birth.Value,null);

        }
    }
}
