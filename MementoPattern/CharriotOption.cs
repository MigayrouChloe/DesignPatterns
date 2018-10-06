using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class CharriotOption
    {
        protected List<OptionVehicule> _options { get; set; }

        public Memento AjouteOption(OptionVehicule nouvelleOption)
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

        public void Annule(Memento memento)
        {
            _options = memento.GetEtat();
        }

    }
}
