using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class CommandeCredit : Commande
    {

        public CommandeCredit(double montant) : base(montant) { }

        public override void Payer()
        {
            Console.WriteLine($"Le paiement de la commande au crédit de {montant} EUR est validé");
        }

        public override bool Valider()
        {
            return (montant >= 1000.0) && (montant <= 5000.0);
        }
    }
}
