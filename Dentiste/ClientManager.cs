using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentiste
{
    public class ClientManager : IClientManager
    {
        public Client buildClient(String name, DateTime birth, Connexion connexion)
        {
            Client c = new Client();
            c.Naissance = birth;
            c.Nom = name;           
            return c;
        }
    }
}
