using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoIntermediaite
{
    class Program
    {
        static void Main(string[] args)
        {
            OptionVehicule SiegeCuir = new OptionVehicule("Siege en cuir");
            OptionVehicule SiegeSportif = new OptionVehicule("Siege sportif");
            OptionVehicule Accoudoir = new OptionVehicule("Accoudoir");

            List<OptionVehicule> optionsExistantes = new List<OptionVehicule>
            {
                SiegeCuir, SiegeSportif, Accoudoir
            };

            CharriotOption monCharriot = new CharriotOption();
            CareTaker monCharriotMemory = new CareTaker();

            string choix = "";
            while (choix.ToLower() != "exit")
            {
                Console.WriteLine("Souhaitez vous : " +
                    "\n (A) Ajouter une option. " +
                    "\n (R) Restaurer l'état précedent de votre charriot. " +
                    "\n (Exit) Quitter l'application"  );
                choix = Console.ReadLine();
                Console.Clear();
                if (choix == "A")
                {
                    Console.WriteLine("Quelle option souhaitez vous ajouter ?");

                    int compteur = 0;
                    foreach (OptionVehicule option in optionsExistantes)
                    {
                        Console.WriteLine(compteur + ") " + option.Nom);
                        compteur = compteur + 1;
                    }

                    choix = Console.ReadLine();

                    if (int.TryParse(choix, out int choiEntier))
                    {
                        monCharriotMemory.Memento = monCharriot.SaveMemento();
                        monCharriot.AddOptions(optionsExistantes[choiEntier]);
                        monCharriot.Affiche();
                    }
                }
                else if (choix == "R")
                {
                    monCharriot.RestoreMemento(monCharriotMemory.Memento);
                    monCharriot.Affiche();
                }
            }


        }
    }
}
