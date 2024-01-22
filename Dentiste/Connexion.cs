using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Dentiste
{
    public class Connexion
    {
        string database = @"Server=localhost;Port=5432;User Id = postgres;Password = postgres;Database=DENTISTERIE;";
        NpgsqlConnection connection;
        public NpgsqlConnection Connection { get => connection; set => connection = value; }

        public bool connect()
        {
            bool b = false;
            this.Connection = new NpgsqlConnection(this.database);
            this.Connection.Open();
            if (Connection.State == ConnectionState.Open)
            {
                Console.WriteLine("Ouverture de la Connection à la base de données avec succcès");
                b = true;
            }
            else
            {
                throw new Exception("Erreur lors de la Connection à la base de données avec succcès");
            }
            return b;
        }
        public void disconnect()
        {
            this.Connection.Close();
            if (Connection.State == ConnectionState.Closed)
            {
                Console.WriteLine("Fermeture de la Connection à la base de données avec succcès");
            }
        }
    }
}
