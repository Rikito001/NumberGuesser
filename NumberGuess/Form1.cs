using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace NumberGuess
{
    public partial class NumberGuesser : Form
    {
        int najviac = 0;
        int najmenej = 0;
        int hadaneCisloInt;
        int pokus = 0;
        int pocitadlo = 0;
        //Random hadaneCislo = new Random();

        public NumberGuesser()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MinCislo_TextChanged(object sender, EventArgs e)
        {
        }

        private void MaxCislo_TextChanged(object sender, EventArgs e)
        {
        }

        private void SpustHru_Click(object sender, EventArgs e)
        {
            try
            {
                pocitadlo = 0;


                //if (!Int32.TryParse(MaxCislo.Text, out najviac) || Int32.TryParse(MinCislo.Text, out najmenej)) 
                //{
                //    label3.Text = "Vlož číselné hodnoty";
                //}


                //Int32.TryParse(MaxCislo.Text, out najviac);
                //Int32.TryParse(MinCislo.Text, out najmenej);

                najmenej = Convert.ToInt32(Vstup1.Value);
                //updateCount(najviac);
                najviac = Convert.ToInt32(Vstup2.Value);

                Random hadaneCislo = new Random();
                hadaneCisloInt = hadaneCislo.Next(najmenej, najviac);
                label3.Text = "Uhádni číslo od " + najmenej + " do " + najviac;
                TajneRiesenie.Text = "Ukáž riešenie";
                PocetPokusov.Text = "Počet pokusov: ";
            }

            catch (System.ArgumentOutOfRangeException)
            {
                label3.Text = "Prvé číslo musí byť menšie ako druhé";
            }

            //Int32.TryParse(pokusHadat.Text, out pokus);
            //if (pokus == hadaneCisloInt) { vysledok.Text = "Gratulujem, uhádol si! Výsledok bol "+pokus; }
            //else { vysledok.Text = "Neuhádol si, skús znova!"; }

        }

        private void TajneRiesenie_Click(object sender, EventArgs e)
        {
            TajneRiesenie.Text = "Riešenie je " + hadaneCisloInt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32.TryParse(pokusHadat.Text, out pokus);
            pocitadlo = pocitadlo + 1;
            PocetPokusov.Text = "Počet pokusov: " + pocitadlo;

            if (pokus == hadaneCisloInt)
            {
               vysledok.Text = "Gratulujem, uhádol si!\n   Výsledok bol " + pokus;
            }

            else
            {
               vysledok.Text = "Neuhádol si, skús znova!";
            }
        }
    }
}
