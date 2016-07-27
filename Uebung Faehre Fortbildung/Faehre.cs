using System; // Doppelklick auf Program.cs
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung_Faehre_Fortbildung
{
    class Faehre   // STANDARD INTERNAL sonst public   3
        // klassendiagramm  rechtsklick auf projekt - Ansicht - Klassendiagramm  ----   Variablen = Felder
    {
        private String name; // String Datentypen für alle Sprachen
        private Decimal laenge;
        private int baujahr;

        public int Baujahr
        {
            get
            {
                return baujahr;
            }

            set
            {
                baujahr = value;
            }
         }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public decimal Laenge
        {
            get
            {
                return laenge;
            }

            set
            {
                laenge = value;
            }
        }

        public Faehre()  // Konstruktor
        {
            Name = "Concord";
            Baujahr = 2001;
            Laenge = 155;
                                   
        }
        public int MaxGewicht { get; set; } //Methode vom System angelegt
    }
}
