using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrairieAbstractFactory.Models
{
    public class FabriqueVehiculeElectricite : IFabriqueVehicule
    {
        public Automobile CreeAutomobile(string couleur, string modele,int puissance, double espace)
        {
            AutomobileElectricite monAutomobileElectrique = new AutomobileElectricite(couleur, modele, puissance, espace);
            return monAutomobileElectrique;
        }

        public Scooter CreeScooter(string couleur, string modele, int puissance)
        {
            ScooterElectricite monScooterElectrique = new ScooterElectricite(couleur, modele,puissance);
            return monScooterElectrique;
        }
    }
}