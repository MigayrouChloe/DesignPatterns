using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class DocumentBonDeCommande : Document
    {
        public override void Afficher()
        {
            Console.WriteLine($"Affichage du bon de commande : \n {this.Contenu}.");
        }

        public override void Imprimer()
        {
            Console.WriteLine($"Impression du bon de commande : \n {this.Contenu}.");
        }
    }
}
