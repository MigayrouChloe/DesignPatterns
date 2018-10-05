using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ConstructeurLiasseVehiculeDoc : ConstructeurLiasseVehicule
    {
        public ConstructeurLiasseVehiculeDoc()
        {
            liasse = new LiasseDoc();
        }

        public override void ConstruitBonDeCommande(string nomClient)
        {
            string document = $"<DOC> Bon de commande client : {nomClient} <DOC>";
            liasse.AjouteDocument(document);
        }

        public override void ConstruitDemandeImmatriculation(string nomClient)
        {
            string document = $"<DOC> Demande d'immatriculation client : {nomClient} <DOC>";
            liasse.AjouteDocument(document);
        }
    }
}
