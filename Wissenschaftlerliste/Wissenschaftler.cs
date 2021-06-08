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
        public string Vorname { get; }
        public string Nachname { get; }
        public int Geburtsjahr { get; }
        public string Fachrichtung { get; }



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
            return "" + ID + " " + Vorname + " " + Nachname + " ";
        }
    }
}