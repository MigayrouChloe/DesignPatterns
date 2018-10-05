using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrairieAbstractFactory.Models
{
    public class Catalogue
    {
        public static int nbAutos = 3;
        public static int nbScooters = 2;
        public IFabriqueVehicule fabrique; 

        public Automobile[] autos = new Automobile[nbAutos];
        public Scooter[] scooters = new Scooter[nbScooters];

        public void LoadCatalogue()
        {
            System.Console.WriteLine("Voulez-vous utiliser des véhicules électriques (1), à essence (2) ou hybride (3) :");
            string choix = System.Console.ReadLine();

            if (choix == "1")
            {
                fabrique = new FabriqueVehiculeElectricite();
            }
            else if (choix == "2")
            {
                fabrique = new FabriqueVehiculeEssence();
            }
            else
            {
                fabrique = new FabriqueVehiculeHybride();
            }

            for (int index = 0; index < nbAutos; index++)
                autos[index] = fabrique.CreeAutomobile("standard",
                  "jaune", 6 + index, 3.2);
            for (int index = 0; index < nbScooters; index++)
                scooters[index] = fabrique.CreeScooter("classic",
                  "rouge", 2 + index);
            foreach (Automobile auto in autos)
                auto.AfficheCaracteristique();
            foreach (Scooter scooter in scooters)
                scooter.AfficheCaracteristique();
        }

    }


}