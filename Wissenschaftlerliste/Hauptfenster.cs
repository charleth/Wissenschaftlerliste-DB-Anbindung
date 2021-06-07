using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Wissenschaftlerliste
{
    public partial class Hauptfenster : Form
    {
        private List<Wissenschaftler> alleWissenschaftler = new List<Wissenschaftler>();
        public Hauptfenster()
        {
            InitializeComponent();
            DatenLaden();
        }
        private void DatenLaden()
        {
            //DB-Verbindungsobjekt mit den Verbindungsparametern anlegen
            MySqlConnection conn = new MySqlConnection("SERVER=localhost;UID=root;PWD=VkzbcSwY3Af4ZtW;DATABASE=wissenschaftlerliste");
            // Server kontaktieren
            conn.Open(); // Login auf DB-Servger + using Wissenschaftler
            // Command-Objekt erstellen
            MySqlCommand cmd = conn.CreateCommand();
            //SQL-Code nennen (getestetes SQL kopieren)
            cmd.CommandText = "select ID,vorname,nachname,geburtsjahr,fachrichtung from wissenschaftler";
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                int id = reader.GetInt32(0); // Spaltennummer beginnt mit 0
                string vorname = reader.GetString(1);
                string nachname = reader.GetString(2);
                int geburtsjahr = reader.GetInt32(3);
                string fachrichtung = reader.GetString(4);
                //Objekt erstellen und in Listen einfügen
                Wissenschaftler w = new Wissenschaftler(id, vorname, nachname, geburtsjahr, fachrichtung);
                alleWissenschaftler.Add(w);
                listBoxWissenschaftler.Items.Add(w.ToString());
            }
            // Reader schließen
            reader.Close();
            //DB-Verbindung schließen
            conn.Close(); // Logout an DB-Server schicken
            //listBoxWissenschaftler.Items.Add("plop");
        }

        private void buttonLoeschen_Click(object sender, EventArgs e)
        {
            int index = listBoxWissenschaftler.SelectedIndex;
            if(index < 0 || index >=alleWissenschaftler.Count)
            {
                // nichts markiert, aus der Funktion rausspringen
                return;
            }
            Wissenschaftler zuloeschen = alleWissenschaftler[index];
            // jetzt Datenbankskript... 
           
            //DB-Verbindungsobjekt mit den Verbindungsparametern anlegen
            MySqlConnection conn = new MySqlConnection("SERVER=localhost;UID=root;PWD=VkzbcSwY3Af4ZtW;DATABASE=wissenschaftlerliste");
            // Server kontaktieren
            conn.Open(); // Login auf DB-Servger + using Wissenschaftler
            // Command-Objekt erstellen
            MySqlCommand cmd = conn.CreateCommand();
            //SQL-Code nennen (getestetes SQL kopieren)
            cmd.CommandText = "delete from wissenschaftler where id="+zuloeschen.ID;
            cmd.ExecuteNonQuery();
            //DB-Verbindung schließen
            conn.Close(); // Logout an DB-Server schicken
            alleWissenschaftler.RemoveAt(index);
            listBoxWissenschaftler.Items.RemoveAt(index);
        }
    }
}
