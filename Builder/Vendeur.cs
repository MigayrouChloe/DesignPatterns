using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Vendeur
    {
        protected ConstructeurLiasseVehicule Constructeur;

        public Vendeur(ConstructeurLiasseVehicule constructeur)
        {
            this.Constructeur = constructeur;
        }

        public Liasse Construit(string nomClient)
        {
            Constructeur.ConstruitBonDeCommande(nomClient);
            Constructeur.ConstruitDemandeImmatriculation(nomClient);
            Liasse liasse = Constructeur.Resulat();
            return liasse;

        }

    }
}
