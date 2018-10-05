using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Vendeur monPremierVendeur = Vendeur.Instance();
            Console.WriteLine("Affichage sans valeur");
            monPremierVendeur.Affiche();
            Console.WriteLine(monPremierVendeur.GetHashCode());

            monPremierVendeur.Adresse = "18 rue LB";
            monPremierVendeur.Email = "@premier_test.fr";
            monPremierVendeur.Nom = "IZAC";

            Console.WriteLine("\nAffichage du premier vendeur");
            monPremierVendeur.Affiche();
            Console.WriteLine(monPremierVendeur.GetHashCode());


            Vendeur monSecondVendeur = Vendeur.Instance();
            monSecondVendeur.Adresse = "43 rue PC";
            monSecondVendeur.Email = "@second_test.fr";
            monSecondVendeur.Nom = "MIGAYROU";

            Console.WriteLine("\nAffichage du second vendeur");
            monSecondVendeur.Affiche();
            Console.WriteLine(monSecondVendeur.GetHashCode());



            Console.WriteLine("\nEssaie sans singleton i.e. via le constructeur par defaut");
            Vendeur monTroisiemeVendeur = new Vendeur { Adresse = "4 rue St PR", Email = "@troisieme_test.fr", Nom = "Migayrou-Izac" };
            monTroisiemeVendeur.Affiche();
            Console.WriteLine(monTroisiemeVendeur.GetHashCode());

        }
    }
}
