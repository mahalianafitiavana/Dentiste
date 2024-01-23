using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentiste
{
    public class VisitFormParams
    {
        Visit visit;
        List<Historic> historics;
        String client;
      
        public Visit Visit { get => visit; set => visit = value; }
        public List<Historic> Historics { get => historics; set => historics = value; }
        public String Idclient { get => client; set => client = value; }

        
    }
}
