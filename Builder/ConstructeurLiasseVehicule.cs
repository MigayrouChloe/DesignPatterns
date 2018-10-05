using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class ConstructeurLiasseVehicule
    {
        protected Liasse liasse;

        public abstract void ConstruitBonDeCommande(string nomClient);
        public abstract void ConstruitDemandeImmatriculation(string nomDemandeur);

        public Liasse Resulat()
        {
            return this.liasse;
        }
    }
}
