using ClassLibraryEmprunt;
using ClassLibraryVerificateur;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClassLibraryEmprunt.Emprunt;

namespace Emprunts
{
    public partial class Form1 : Form
    {
        Emprunt emprunt;
        public Form1()
        {
            InitializeComponent();

            foreach (Periodicites p in Periodicites.GetValues(typeof(Periodicites)))
            {
                this.listRemboursement.Items.Add(p);
            }
            emprunt = new Emprunt(1, 0.07, 1, Periodicites.Mensuelle);
            
            MiseAJourIHM();
        }
       
        public void MiseAJourIHM()
        {
            //on assigne la valeur du scroll et du capital
            scrollRemboursement.Value = emprunt.DureeMois;
            textEmprunt.Text = emprunt.Capital.ToString();
            labelRemboursement.Text = scrollRemboursement.Value.ToString();

            //mise à jour scroll et STEP
            if (scrollRemboursement.Value < (int)emprunt.MaPeriodiciteCourante)
            {
                scrollRemboursement.Value = (int)emprunt.MaPeriodiciteCourante;
            }
            scrollRemboursement.LargeChange = (int)emprunt.MaPeriodiciteCourante;
            scrollRemboursement.SmallChange = (int)emprunt.MaPeriodiciteCourante;
            scrollRemboursement.Minimum = (int)emprunt.MaPeriodiciteCourante;

            //ici on va permettre au scroll de prendre en compte le STEP via la souris
            

            // on calcule le nombre de paiement et la samme à rembourser à chaque paiement
            nbrPaiement.Text = emprunt.CalculerNbrPaiement().ToString();
            sommeFinale.Text = emprunt.CalculerSommeRemboursement();
        }
        private void textEmprunt_TextChanged(object sender, EventArgs e)
        {
            if (textEmprunt.Text != "" && Validateur.VerifierMontant(textEmprunt.Text))
            {
                emprunt.Capital = Int32.Parse(textEmprunt.Text);
                scrollRemboursement.Enabled = true;
                labelRemboursement.Enabled = true;
                listRemboursement.Enabled = true;
                erreurEmprunt.Clear();
                MiseAJourIHM();
            }
            else
            {
                scrollRemboursement.Enabled = false;
                labelRemboursement.Enabled = false;
                nbrPaiement.Text = "";
                listRemboursement.SelectedIndex = 0;
            }
        }

        private void textEmprunt_KeyPress(object sender, KeyPressEventArgs e)
        {
            erreurEmprunt.SetError(textEmprunt, "Cette case ne peut que contenir des caractères numériques, pas de virgule.");
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    
        private void scrollRemboursement_ValueChanged(object sender, EventArgs e)
        {
            emprunt.DureeMois = scrollRemboursement.Value;
            MiseAJourIHM();
        }

        private void listRemboursement_SelectedIndexChanged(object sender, EventArgs e)
        {

            emprunt.MaPeriodiciteCourante = (Periodicites)listRemboursement.SelectedItem;

            MiseAJourIHM();
        }

 
        private void btnValider_Click(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            string chemin = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\Emprunts\Emprunt.txt";
            Stream stream = new FileStream(chemin, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, emprunt);
            stream.Close();
        }

        private void btn_Change(object sender, EventArgs e)
        {
            if (btnSept.Checked)
            {
                emprunt.Interet = 0.07;
            }
            else if (btnHuit.Checked)
            {
                emprunt.Interet = 0.08;
            }
            else if (btnNeuf.Checked)
            {
                emprunt.Interet = 0.09;
            }
            MiseAJourIHM();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            string chemin = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\Emprunts\Emprunt.txt";
            Stream stream = new FileStream(chemin, FileMode.Open, FileAccess.Read);
            emprunt = (Emprunt)formatter.Deserialize(stream);
            stream.Close();

            MiseAJourIHM();

        }
    }
}
