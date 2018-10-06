using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class User
    {
        private static List<OptionVehicule> CreeOption()
        {

            OptionVehicule SiegeSportif = new OptionVehicule("Siege sportif");
            OptionVehicule SiegeCuir = new OptionVehicule("Siege en cuir");
            OptionVehicule Accoudoir = new OptionVehicule("Accoudoir");

            SiegeSportif.AjouteOptionIncompatibles(Accoudoir);
            SiegeSportif.AjouteOptionIncompatibles(SiegeCuir);
            SiegeCuir.AjouteOptionIncompatibles(SiegeSportif);
            Accoudoir.AjouteOptionIncompatibles(SiegeSportif);

            List<OptionVehicule> lesOptionsExistantes = new List<OptionVehicule>
            {
               SiegeSportif, SiegeCuir, Accoudoir
            };

            return lesOptionsExistantes;
        }
        private static List<OptionVehicule> _optionsExistantes = CreeOption();

        private static int _nbOption = (int)_optionsExistantes.LongCount();

        public void AfficheProgrammeChoix()
        {
            Console.WriteLine("Quelle option souhaitez vous ajouter à votre voiture?");
            int compteur = 0;
            foreach (var item in _optionsExistantes)
            {
                compteur = compteur + 1;
                Console.Write("(" + compteur.ToString() + ") ");
                item.AfficheCaracteristique();
            }

            Console.WriteLine("(Exit) Quitter le menu de choix");
            Console.WriteLine("(Cancel) Annuler le dernier ajout)");
        }

        public bool VerificationSaisieInt(string choix)
        {
            bool valeurAretourner = false;
            if (int.TryParse(choix, out int choixEntier))
                if (Enumerable.Range(1, _nbOption + 1).Contains(choixEntier))
                    valeurAretourner = true;
            return valeurAretourner;


        }

        public void SaisieCancel(string choix)
        {
            choix = choix.ToLower();
            if (choix == "exit")
                Environment.Exit(0);
        }


        public void GestionSaisie()
        {
            string choix = "";

            CharriotOption monCharriot = new CharriotOption();
            while(choix!= "Exit")
            {
                IMemento iMemento;
                AfficheProgrammeChoix();
                choix = Console.ReadLine();
                if (VerificationSaisieInt(choix))
                {
                    int choixEntier = int.Parse(choix);
                    iMemento = monCharriot.AjouteOption(_optionsExistantes[choixEntier - 1]);
                    Console.Clear();
                    monCharriot.Affiche();
                }

                if(choix == "Cancel")
                {
                    monCharriot.Annule(iMemento : IMemento);
                }
            }







        }



    }
}
