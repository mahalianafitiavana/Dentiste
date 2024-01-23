using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentiste
{
    public interface IVisitServiceSignature
    {
        void Save(Connexion connexion, VisitFormParams param);
        VisitFormParams Build(Connexion connexion, int[][] notes, Client client);
    }
}
