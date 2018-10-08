using System;
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
            //Creer une nouvelle liste ici pour casser la reference entre les deux listes d'option
            return new Memento(_optionsCharriot);
        }

        public void RestoreMemento(Memento mementoARestaurer)
        {
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
