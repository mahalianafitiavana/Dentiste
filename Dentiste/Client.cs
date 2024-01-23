using Npgsql;
using System;
using System.Collections.Generic;

namespace Dentiste
{
    public class Client
    {
        string id;
        string nom;
        DateTime naissance;
        public Client() { }
        public Client(string id,string nom, DateTime naissance)
        {
            this.id = id;
            this.nom = nom;
            this.naissance = naissance;
        }
        public string Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public DateTime Naissance { get => naissance; set => naissance = value; }

        public static List<Client> all(Connexion c)
        {   
            List<Client> list = new List<Client>();
            try
            {
                bool isConnected = false;
                if (c == null)
                    c = new Connexion();
                    c.connect();
                    isConnected = true;
                string sql = "SELECT * FROM Client";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, c.Connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            list.Add(new Client(reader["idclient"].ToString(), reader["name"].ToString(), (DateTime)reader["Birth"]));
                            // Faites quelque chose avec les valeurs (par exemple, les imprimer)
                            Console.WriteLine($"ID Client: {reader["idclient"]}, Nom: {reader["name"]}, Date de naissance: {(DateTime)reader["Birth"]}");
                    }
                }
                if (isConnected)
                    c.disconnect();
            }
            catch (System.Exception)
            {
                if (c != null)
                    c.disconnect();
                throw;
            }
            return list;
        }
        public void save(Connexion c)
        {
            NpgsqlTransaction transaction = null;
            bool isConnected = false;
            if (c == null)
                c = new Connexion();
                c.connect();
                isConnected = true;
            string sql = "select  insert_client('" + Nom + "', '" + Naissance.ToString("yyyy-MM-dd") + "')";
            using (NpgsqlCommand command = new NpgsqlCommand(sql, c.Connection))
            {
                command.Transaction = transaction;
                this.Id = (string)command.ExecuteScalar();
            }
            if (isConnected)
                c.disconnect();
        }

    }
}
