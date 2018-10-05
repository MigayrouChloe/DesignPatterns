using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Utilisateur
    {
        public void LoadPrototype()
        {
            LiasseVierge maLiasseDeBase = LiasseVierge.Instance();
            maLiasseDeBase.Ajouter(new DocumentBonDeCommande());
            maLiasseDeBase.Ajouter(new DocumentCertificatCession());
            maLiasseDeBase.Ajouter(new DocumentDemandeImmatriculation());

            LiasseClient liasseClient = new LiasseClient("Migayrou");
            liasseClient.Afficher();

            LiasseClient liasseClient2 = new LiasseClient("Durant");
            liasseClient2.Afficher();
        }
    }
}
