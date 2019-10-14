using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryEmprunt
{
    [Serializable]
   public class Emprunt
    {
        private int capital;
        private double interet;
        private int dureeMois;
        private Periodicites maPeriodiciteCourante;

        public int Capital { get => capital; set => capital = value; }
        public double Interet { get => interet; set => interet = value; }
        public int DureeMois { get => dureeMois; set => dureeMois = value; }
        public Periodicites MaPeriodiciteCourante { get => maPeriodiciteCourante; set => maPeriodiciteCourante = value; }

        public enum Periodicites
        {
            Mensuelle = 1,
            Bimestrielle = 2,
            Trimestrielle = 3,
            Semestrielle = 6,
            Annuelle = 12
        }
        public Emprunt()
        {
        }
        public Emprunt(int dureeEmprunt, double interetEmprunt, int capitalEmprunt, Periodicites periodEmprunt) {
            this.interet = interetEmprunt;
            this.capital = capitalEmprunt;
            this.dureeMois = dureeEmprunt;
            this.maPeriodiciteCourante = periodEmprunt;

        }
       public int CalculerNbrPaiement()
        {
            int nbrPaiement = dureeMois / (int)maPeriodiciteCourante;
            return nbrPaiement;
        }
        public string CalculerSommeRemboursement()
        {
           double t = interet / 12 * (int)maPeriodiciteCourante;
            //double t = Int32.Parse(nbrPaiement.Text);
            //int pourcentage = ((K * 7) / 100) / 12;
            //double x = K * (pourcentage / (1 - (1 + pourcentage)));
            //double testFinale = Math.Pow(x, t);
            //sommeFinale.Text = testFinale.ToString();
            int n = dureeMois / (int)maPeriodiciteCourante;
            double r = capital * (t / (1 - Math.Pow(1 + t, -1 * n)));
            return r.ToString();
            
        }
        public override string ToString()
        {
            return "Périodicité choisie : " + maPeriodiciteCourante.ToString() + " capital choisi : " + capital.ToString() + " intérêt choisi : " + interet.ToString() + " durée en mois : " + dureeMois.ToString() + " le nombre de paiements sera de : " + this.CalculerNbrPaiement() + " et la somme a remboursé à chaque paiement sera de : " + this.CalculerSommeRemboursement(); ;
        }


    }
}
