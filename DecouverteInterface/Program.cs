using DecouverteInterface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DecouverteInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Commande maCommandeFrancaise = new Commande()
            {
                PaysEnCours = new France(),
                MontantHt = 1000M
            };

            

            Commande maCommandeLuxembourgeoise = new Commande()
            {
                PaysEnCours = new Luxembourg(),
                MontantHt = 1000M
            };


            Console.WriteLine("Le montant total de la commande francaise est de " + maCommandeFrancaise.CalculeMontantTtc());
            Console.WriteLine("Le montant total de la commande luxembourgoise est de " + maCommandeLuxembourgeoise.CalculeMontantTtc());

            maCommandeFrancaise.MontantHt = maCommandeLuxembourgeoise.MontantHt = 5860 ;
   

            Console.WriteLine("Test avec arrondi a deux apres la virugle ");
            Console.WriteLine($"Le montant total de la commande francaise est de {maCommandeFrancaise.CalculeMontantTtc().ToString("N2")}");
            Console.WriteLine($"Le montant total de la commande luxembourgoise est de {maCommandeLuxembourgeoise.CalculeMontantTtc().ToString("N2")}");


        }
    }
}
