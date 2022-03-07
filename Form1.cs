using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VjezbaZaTestZrakoplov
{
    public partial class Form1 : Form
    {
        List<Zrakoplov> listaZrakoplova = new List<Zrakoplov>();   //stvaramo listu "listaZrakoplov" unutar klase Zrakoplov
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNupisi_Click(object sender, EventArgs e)
        {
            Zrakoplov zrakoplov = new Zrakoplov(CMBvrsta.Text, TXTime.Text, TRBbrzina.Value, DTPgod.Value, CHBda.Checked);   //određujemo sve inpute koje ulaze u objekt "zrakoplov"
            listaZrakoplova.Add(zrakoplov);                                                                                  //stavljamo sve varijable, unutar objekta "zrakoplov", u listu

            MessageBox.Show("Text", "ImeProzora", MessageBoxButtons.OK, MessageBoxIcon.Information);    //stvaramo Messagebox
        }

        private void BTNispisi_Click(object sender, EventArgs e)
        {
            RTBispis.Clear();                                       //brise svu vrijednost unutar RichTextBox-a prije novog ispisa

            foreach (Zrakoplov zrakoplov in listaZrakoplova)        //radnja za svaki unos unutar objekta "zrakoplov" iz klase "Zrakoplov", koji se nalaze u listi "listaZrakoplova"
            {
                RTBispis.AppendText(zrakoplov.ToString());          //određuje gdje stavlja ispis koji uzima iz evorride-a
            }
        }
    }
}
