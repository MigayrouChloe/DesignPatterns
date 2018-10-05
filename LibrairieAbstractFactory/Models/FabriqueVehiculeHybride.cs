using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrairieAbstractFactory.Models
{
    public class FabriqueVehiculeHybride : IFabriqueVehicule
    {
        public Automobile CreeAutomobile(string couleur, string modele, int puissance, double espace)
        {
            AutomobileHybride monAutomobile = new AutomobileHybride(couleur, modele, puissance, espace);
            return monAutomobile;
        }

        public Scooter CreeScooter(string couleur, string modele, int puissance)
        {
            ScooterHybride monScooterHybride = new ScooterHybride(couleur, modele, puissance);
            return monScooterHybride;
        }
    }
}
