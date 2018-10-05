using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Commande
    {
        protected double montant;

        public Commande(double montant)
        {
            this.montant = montant;
        }

        public abstract void Payer();
        public abstract bool Valider();

    }
}
