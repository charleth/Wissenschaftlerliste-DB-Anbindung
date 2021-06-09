using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wissenschaftlerliste
{
    public class Wissenschaftler
    {
        public long ID { get; } // nur Getter kein Setter
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public int Geburtsjahr { get; set; }
        public string Fachrichtung { get; set; }



        public Wissenschaftler(long id, string vorname, string nachname, int geburtsjahr, string fachrichtung)
        {
            ID = id;
            Vorname = vorname;
            Nachname = nachname;
            Geburtsjahr = geburtsjahr;
            Fachrichtung = fachrichtung;
        }

        public override string ToString()
        {
            return "" + ID + " " + Vorname + " " + Nachname + " " + " -- " + Fachrichtung;
        }
    }
}