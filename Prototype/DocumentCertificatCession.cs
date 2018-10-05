using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class DocumentCertificatCession : Document
    {
        public override void Afficher()
        {
            Console.WriteLine($"Affichage du certificat de cession : \n {this.Contenu}.");
        }

        public override void Imprimer()
        {
            Console.WriteLine($"Affichage du certificat de cession : \n {this.Contenu}.");
        }
    }
}
