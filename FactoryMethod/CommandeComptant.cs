using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class CommandeComptant : Commande
    {
        public CommandeComptant(double montant) : base(montant) { }

        public override void Payer()
        {
            Console.WriteLine($"Le paiement de la commande au comptant de : {montant} EUR est validé.");
        }

        public override bool Valider()
        {
            return true;
        }
    }
}
