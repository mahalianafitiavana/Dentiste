using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentiste
{
    public partial class VisitService : IVisitServiceSignature
    {
        public VisitFormParams Build(Connexion connexion, int[][] notes)
        {
            VisitFormParams para = new VisitFormParams();
            para.Idclient = "CL000018";
            Visit visit = new Visit(); visit.construirePK(connexion); visit.Dates = DateTime.Now ; visit.Idclient = "CL000018";
            List<Historic> list = new List<Historic>();
            for (int i = 0; i < notes.Length; i++)
            {
                for (int j = 0; j < notes[i].Length; j++)
                {
                    list.Add(new Historic(notes[i][j],(i+1)*10 +(j+1), visit.Id));
                    int n = (i + 1) * 10 + (j + 1);
                    Console.WriteLine("Note : "+ notes[i][j]+ " Dent"+ n + "  idvisit "+ visit.Id);
                }
            }
            para.Visit = visit; para.Historics = list;
            return para;
        }

        public void Save(Connexion connexion, VisitFormParams param)
        {
            param.Visit.save(connexion);
            foreach (Historic historic in param.Historics)
            {
                historic.save(connexion);
            }
        }
    }
}
