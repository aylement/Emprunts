using ClassLibraryEmprunt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibraryEmprunt.Emprunt;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Emprunt e;
            e = new Emprunt(120, 0.08, 150000, Periodicites.Trimestrielle);
            e.calculerNbrPaiement();
            Console.WriteLine(e.ToString());
            
        }

        
    }
}
