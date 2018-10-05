using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Client
    {

        protected IList<Commande> commandes = new List<Commande>();

        protected abstract Commande CreerCommande(double montant);

        public void NouvelleCommande(double montant)
        {
            Commande commande = this.CreerCommande(montant);
            if (commande.Valider())
            {
                commande.Payer();
                commandes.Add(commande);
            }
                
        }

    }
}
