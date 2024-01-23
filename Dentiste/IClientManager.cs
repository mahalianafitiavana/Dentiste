using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentiste
{
    public interface IClientManager
    {
        Client buildClient(String name, DateTime birth, Connexion connexion);
        
    }
}
