using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class CharriotOption
    {
        protected List<OptionVehicule> _options = new List<OptionVehicule>();

        public IMemento AjouteOption(OptionVehicule nouvelleOption)
        {
            Memento memento = new Memento();
            memento.SetEtat(_options);

            foreach (var item in nouvelleOption._optionsIncompatibles)
            {
                _options.Remove(item);
            }

            _options.Add(nouvelleOption);


            return memento;
        }

        public void Annule(IMemento iMemento)
        {
            Memento mementoInstance = iMemento as Memento;
            if (mementoInstance == null)
                return;
            _options = mementoInstance.GetEtat();
        }

        public void Affiche()
        {
            Console.WriteLine("Contenu du chariot d'option :");
            foreach (var item in _options)
            {
                item.Affiche();
            }
        }

    }
}
