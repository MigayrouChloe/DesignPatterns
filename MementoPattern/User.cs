using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class User
    {
        public List<OptionVehicule> CreeOption()
        {
            List<OptionVehicule> lesOptionsExistantes = new List<OptionVehicule>
            {
                new OptionVehicule("Moteur 4x4"),
                new OptionVehicule("Trois portes"),
                new OptionVehicule("Accoudoir"),
                new OptionVehicule("Sieges sportifs"),
                new OptionVehicule("Sieges en cuirs"),
            };

            lesOptionsExistantes[1].AjouteOptionIncompatibles(lesOptionsExistantes[0]);
            lesOptionsExistantes[0].AjouteOptionIncompatibles(lesOptionsExistantes[1]);
            lesOptionsExistantes[2].AjouteOptionIncompatibles(lesOptionsExistantes[3]);
            lesOptionsExistantes[3].AjouteOptionIncompatibles(lesOptionsExistantes[2]);
            lesOptionsExistantes[3].AjouteOptionIncompatibles(lesOptionsExistantes[4]);
            lesOptionsExistantes[4].AjouteOptionIncompatibles(lesOptionsExistantes[3]);

            return lesOptionsExistantes;
        }
        public void AfficheProgrammeChoix()
        {
            List<OptionVehicule> optionExistantes = CreeOption();

            int compteur = 0;
            foreach (var item in optionExistantes)
            {
                compteur = compteur + 1;
                Console.Write("(" + compteur.ToString() + ") ");
                item.AfficheCaracteristique();
            }
            int choix = int.Parse(Console.ReadLine());


            CharriotOption monCharriot = new CharriotOption();
            monCharriot.AjouteOption(optionExistantes[choix-1]);

           
        }




    }
}
