using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrairieAbstractFactory.Models
{
    public class AutomobileHybride : Automobile
    {
        public AutomobileHybride(string couleur, string modele, int puissance, double espace) : base(couleur, modele, puissance, espace) { }

        public override void AfficheCaracteristique()
        {
            Console.WriteLine($"Automobile hybride de modele {Modele}, de couleur {Couleur}, de puissance {Puissance} et d'espace {Espace}.");
        }
    }
}
