using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrairieAbstractFactory.Models
{
    public class FabriqueVehiculeEssence : IFabriqueVehicule
    {
        public Automobile CreeAutomobile(string couleur, string modele, int puissance, double espace)
        {
            AutomobileEssence monAutomobileEssence = new AutomobileEssence(couleur, modele, puissance, espace);
            return monAutomobileEssence;
        }

        public Scooter CreeScooter(string couleur, string modele, int puissance)
        {
            ScooterEssence monScooterEssence = new ScooterEssence(couleur,modele,puissance);
            return monScooterEssence;
        }
    }
}
