﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoIntermediaite
{
    class CharriotOption
    {
        private List<OptionVehicule> _optionsCharriot = new List<OptionVehicule>();

        public void AddOptions(OptionVehicule optionAAjouter)
        {
            _optionsCharriot.Add(optionAAjouter);
        }

        //public List<OptionVehicule> OptionsCharriot
        //{
        //    get { return _optionsCharriot; }

        //    set { _optionsCharriot = value; }
        //}

        public Memento SaveMemento()
        {
            List<OptionVehicule> nouvelleReferenceListe = new List<OptionVehicule>();
            foreach (OptionVehicule item in _optionsCharriot)
            {
                nouvelleReferenceListe.Add(item);
            }
            return new Memento(nouvelleReferenceListe);
        }

        public void RestoreMemento(Memento mementoARestaurer)
        {
            this._optionsCharriot.Clear();
            foreach(OptionVehicule item in mementoARestaurer.OptionsSauvegardees)
            {
                this._optionsCharriot.Add(item);
            }

            Console.WriteLine("Charriot restauré : ");
            foreach (OptionVehicule item in this._optionsCharriot)
            {
                Console.WriteLine(item.Nom);
            }
            Console.WriteLine();
        }

        public void Affiche()
        {
            Console.WriteLine("Contenu du charriot : ");
            foreach (OptionVehicule item in _optionsCharriot)
            {
                Console.WriteLine(item.Nom);    
            }
            Console.WriteLine();
        }
    }
}
