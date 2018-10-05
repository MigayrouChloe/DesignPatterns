using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public class User
    {
        public void LoadResponsabilityChain()
        {
            Vehicule monVehicule1 = new Vehicule("4x4");
            Console.WriteLine("Impression description du vehicule 1");
            Console.WriteLine(monVehicule1.DonneDescription());

            Modele monVehicule2 = new Modele("mon modele", "mon nom");
            Console.WriteLine("\nImpression description du vehicule 2");
            Console.WriteLine(monVehicule2.DonneDescription());

            Marque monVehicule3 = new Marque("ma desc1", "ma desc2", null);
            Console.WriteLine("\nImpression description du vehicule 3");
            Console.WriteLine(monVehicule3.DonneDescription());
        }

    }
}
