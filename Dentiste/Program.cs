using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentiste
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /* Application.EnableVisualStyles();
             Application.SetCompatibleTextRenderingDefault(false);
             Application.Run(new Form1());*/
            Client client = new Client("Mah", new DateTime(2003, 03, 03));
            Connexion c = new Connexion();
            c.connect();
            client.insert(c);
            c.disconnect();
            Console.WriteLine(client.Id);
        }
    }
}
