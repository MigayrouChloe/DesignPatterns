﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrairieAbstractFactory.Models
{
    public class AutomobileEssence : Automobile
    {
        /// <summary>
        /// Constructeur d'automobileEssence. Les informations passées en parametres seront retransmises au constructeur de la classe parent via le :base()
        /// </summary>
        public AutomobileEssence(string couleur, string modele, int puissance, double espace)
                                    : base(couleur, modele, puissance, espace) { }

        public override void AfficheCaracteristique()
        {
            Console.WriteLine($"Automobile essence de modele {Modele}, de couleur {Couleur}, de puissance {Puissance} et d'espace {Espace}.");
        }
    }
}
