using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrairieAbstractFactory.Models
{
    public class ScooterEssence : Scooter
    {
        public ScooterEssence(string couleur, string modele, int puissance) : base(couleur, modele, puissance) { }

        public override void AfficheCaracteristique()
        {
            Console.WriteLine($"Scooter à essence de modele {Modele}, de couleur {Couleur} et de puissance {Puissance}.");
        }

    }
}
