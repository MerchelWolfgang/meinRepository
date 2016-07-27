using System; // extras optionen text-edior  C# allgemein  zeilennummern
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uebung_Faehre_Fortbildung
{
    public partial class Formfaehre : Form  //2
    {
        Faehre faehre = null;  //Adresse einer Klasse hinterlegt  
        public Formfaehre() //4
        {
            InitializeComponent();
        //    faehre = new Faehre(); // Methode Aufruf des Konstruktors Initialisierung  5
        }

        private void buttonfaehreneu_Click(object sender, EventArgs e)
        {
            faehre = new Faehre(); // Methode Aufruf des Konstruktors Initialisierung  5
            faehre.Baujahr = Convert.ToInt32 ( textBoxbaujahr.Text);
            faehre.Laenge = Convert.ToDecimal(textBoxlaenge.Text);
            faehre.Name = textBoxfaehrename.Text;
            toolStripStatusLabelmeldung.Text = "Fähre " + faehre.Name + " wurde angelegt";
        }
    }
}
 