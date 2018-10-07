using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStepMemento
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator monProduit = new Originator();
            CareTaker monProduitMemory = new CareTaker();

            // Sauvegarde de l'état initial i.e. lors de la creation de l'objet
            monProduitMemory.Memento = monProduit.SaveMemento();

            Console.WriteLine("Choississez l'état voulu. (Exit si vous souhaitez quitter)");
            string choix = Console.ReadLine();
            Console.Clear();
            monProduit.State = choix;

            // Intervention utilisateur 
            while (choix != "Exit")
            {
                Console.WriteLine("Voulez vous : \n Poursuivre. (P) \n Restaurer (R) l'état précedent. \n Sortir de l'application (Exit)");
                choix = Console.ReadLine();
                if (choix == "P")
                {
                    Console.Clear();
                    Console.WriteLine("Choississez l'état voulu.");
                    choix = Console.ReadLine();
                    monProduitMemory.Memento = monProduit.SaveMemento();
                    monProduit.State = choix;
                }
                else if (choix == "R")
                {
                    Console.Clear();
                    monProduit.RestoreMemento(monProduitMemory.Memento);
                    Console.WriteLine(monProduit.State);
                }
            }
            Environment.Exit(0);
        }
    }
}
