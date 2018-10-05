using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ConstructeurLiasseVehiculePdf : ConstructeurLiasseVehicule
    {
        public ConstructeurLiasseVehiculePdf()
        {
            liasse = new LiasseHtml();
        }


        public override void ConstruitBonDeCommande(string nomClient)
        {
            string document = "<HTML>Bon de commande Client : " + nomClient + "</HTML>";
            liasse.AjouteDocument(document);
        }

        public override void ConstruitDemandeImmatriculation(string nomClient)
        {
            string document = "<HTML>Demande d'immatriculation Demandeur : " + nomClient + "</HTML>";
            liasse.AjouteDocument(document);
        }
    }
}
