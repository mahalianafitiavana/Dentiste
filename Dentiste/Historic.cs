
using Npgsql;
using System;

namespace Dentiste
{
    public class Historic
    {
        string id;
        int idtooth;
        int note;
        String idVisit;

        public Historic(int idtooth, int note,String idVisit)
        {
            Idtooth = idtooth;
            Note = note;
            IdVisit = idVisit;
        }
        public Historic() { }
        public string Id { get => id; set => id = value; }
        public int Idtooth { get => idtooth; set => idtooth = value; }
        public int Note { get => note; set => note = value; }
        public string IdVisit { get => idVisit; set => idVisit = value; }

        public void save (Connexion c)
        {
            NpgsqlTransaction transaction = null;
            try
            {
                bool isConnected = false;
                if (c == null)
                    c = new Connexion();
                    isConnected = c.connect(); 
                transaction = c.Connection.BeginTransaction();
                string sql = " insert into historique values (default , " + this.Idtooth + "," + this.Note + ", '" + this.IdVisit + "')";
                Console.WriteLine(sql);                    
                using (NpgsqlCommand command = new NpgsqlCommand(sql, c.Connection))
                {
                    command.Transaction = transaction;
                    command.ExecuteNonQuery();
                }
                transaction.Commit();
                if (isConnected)
                   c.disconnect();
            }
            catch (System.Exception)
            {
                transaction?.Rollback();
                if (c != null)
                    c.disconnect();               
                throw;
            }
        }
    }
}
