using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentiste
{
    public class Client
    {
        string id;
        string nom;
        DateTime naissance;

        public Client() { }

        public Client(string nom, DateTime naissance)
        {
            this.nom = nom;
            this.naissance = naissance;
        }
        public string Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public DateTime Naissance { get => naissance; set => naissance = value; }

        public void setId(Connexion c)
        {

        }
        public void insert(Connexion c)
        {
            NpgsqlTransaction transaction = null;
            try
            {
                bool isConnected = false;
                if (c == null)
                {
                    c = new Connexion();
                    c.connect();
                    isConnected = true;
                }
                transaction = c.Connection.BeginTransaction();
                string sql = "select  insert_client('" + Nom + "', '" + Naissance.ToString("yyyy-MM-dd") + "')";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, c.Connection))
                {
                    command.Transaction = transaction;
                    this.Id = (string)command.ExecuteScalar();
                }
                transaction.Commit();

                if (isConnected)
                {
                    c.disconnect();
                }
            }
            catch (System.Exception)
            {
                // En cas d'erreur, effectuer un rollback
                transaction?.Rollback();
                if (c != null)
                {
                    c.disconnect();
                }
                throw;
            }
        }

    }
}
