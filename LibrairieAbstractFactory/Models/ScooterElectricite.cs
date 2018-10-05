using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrairieAbstractFactory.Models
{
    public class ScooterElectricite : Scooter
    {

        public ScooterElectricite(string couleur, string modele, int puissance) : base(couleur, modele, puissance) { }

        public override void AfficheCaracteristique()
        {
            Console.WriteLine($"Scooter électrique de modele {Modele}, de couleur {Couleur} et de puissance {Puissance}.");
        }

    }
}
