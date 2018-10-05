using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class ClientComptant : Client
    {
        protected override Commande CreerCommande(double montant)
        {
            return new CommandeComptant(montant);
        }
    }
}
