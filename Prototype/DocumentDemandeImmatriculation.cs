using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class DocumentDemandeImmatriculation : Document
    {
        public override void Afficher()
        {
            Console.WriteLine($"Affichage de la demande d'immatriculation : \n {this.Contenu}.");
        }

        public override void Imprimer()
        {
            Console.WriteLine($"Affichage de la demande d'immatriculation : \n {this.Contenu}.");
        }
    }
}
