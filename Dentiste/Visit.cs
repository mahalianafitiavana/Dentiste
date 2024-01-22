using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentiste
{
    public class Visit
    {
        String id;
        DateTime dates;
        double amount;
        String idclient;

        public string Id { get => id; set => id = value; }
        public DateTime Dates { get => dates; set => dates = value; }
        public double Amount { get => amount; set => amount = value; }
        public string Idclient { get => idclient; set => idclient = value; }
        public void save(Connexion c)
        {
            bool isConnected = false;
            if (c == null)
                c = new Connexion();
                isConnected = c.connect();

            string sql = "insert into visit values ('"+Id+"', null ,'"+Dates+"','"+Idclient+"')";
            Console.WriteLine(sql);
            using (NpgsqlCommand command = new NpgsqlCommand(sql, c.Connection))
            {
                command.ExecuteNonQuery();
            }
            if (isConnected)
                c.disconnect();
        }
        public void construirePK(Connexion connexion)
        {
            bool isconnected = false;
            if (connexion == null)
                connexion = new Connexion();
                isconnected = connexion.connect();
            string sql = " select get_idvisit() ";
            using (NpgsqlCommand command = new NpgsqlCommand(sql, connexion.Connection))
            {
                this.Id = (string) command.ExecuteScalar();
            }
            if (isconnected) 
                connexion.disconnect();            
        }



    }
}
