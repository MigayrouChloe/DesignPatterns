using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ClientVehicule
    {
        public void AfficherLiasse()
        {
            Console.WriteLine("Quel type de liasse souhaitez vous construire ? \n 1 ) HTML \n 2 ) PDF \n 3 ) DOC");
            string choix = Console.ReadLine();
            Console.WriteLine("Quel est le nom du client ?");
            string nom = Console.ReadLine();

            ConstructeurLiasseVehicule constructeur;

            if (choix == "1")
            {
                constructeur = new ConstructeurLiasseVehiculeHtml();
            }
            else if(choix =="2")
            {
                constructeur = new ConstructeurLiasseVehiculeHtml();
            }
            else
            {
                constructeur = new ConstructeurLiasseVehiculeDoc();
            }
            Vendeur vendeur = new Vendeur(constructeur);
            vendeur.Construit(nom).Imprime();
        }
    }
}
