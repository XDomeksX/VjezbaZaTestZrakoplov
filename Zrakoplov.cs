using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaZaTestZrakoplov
{
    internal class Zrakoplov
    {
        string vrsta, ime;    //dajemo varijable za sve potrebne podatke inputa
        int snaga;
        DateTime god;
        bool aerodinamika;

        public Zrakoplov(string vrsta, string ime, int snaga, DateTime god, bool aerodinamika)      //stvaramo konstruktor; "Generate constructor"
        {
            this.vrsta = vrsta;
            this.ime = ime;
            this.snaga = snaga;
            this.god = god;
            this.aerodinamika = aerodinamika;
        }

        public override string ToString()    //override nam treba svaki put kad želimo da program izbaci nešto u ispisu!
        {
            return "Vrsta: " + this.vrsta + Environment.NewLine + "Ime: " + this.ime + Environment.NewLine + "Snaga: " + this.snaga + Environment.NewLine + "Godina proizvodnje: " + this.god.Year + Environment.NewLine + "Aerodinamika: " + this.aerodinamika + Environment.NewLine;
        }

        public string Vrsta { get => vrsta; set => vrsta = value; }        //stvaramo getere i setere (svojstva); "Encapsulate field (use property)"
        public string Ime { get => ime; set => ime = value; }
        public int Snaga { get => snaga; set => snaga = value; }
        public DateTime God { get => god; set => god = value; }
        public bool Aerodinamika { get => aerodinamika; set => aerodinamika = value; }
    }
}
