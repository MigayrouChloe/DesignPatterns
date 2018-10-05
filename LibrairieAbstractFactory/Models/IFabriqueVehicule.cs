using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrairieAbstractFactory.Models
{
    public interface IFabriqueVehicule
    {
        Automobile CreeAutomobile(string couleur, string modele, int puissance, double espace);
        Scooter CreeScooter(string couleur, string modele, int puissance);
    }
}
