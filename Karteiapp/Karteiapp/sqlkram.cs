using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.SQLite.EF6;
using System.Data.SQLite.Linq;

namespace Karteiapp
{
    class sqlkram
    {

        public static SQLiteConnection m_dbConnection;
        public void VerbindungAufbauen()
        {
            m_dbConnection = new SQLiteConnection("Data Source=KarteiDB.sqlite;Version=3;");
            m_dbConnection.Open();
        }

        public string ZeigeFragen()
        {
            m_dbConnection = new SQLiteConnection("Data Source=KarteiDB.sqlite;Version=3;");
            m_dbConnection.Open();
            string sql = "SELECT Frage FROM Karten";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            string erg = ""; 
            Boolean vorhanden=reader.Read();


            while (reader.Read())
            Console.WriteLine("Frage: " + reader["Frage"]);
            m_dbConnection.Close();

            return erg;
        }
    }
}
