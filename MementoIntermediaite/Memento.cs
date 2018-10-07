using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoIntermediaite
{
    public class Memento
    {
        private List<OptionVehicule> _optionsSauvegardees;

        public List<OptionVehicule> OptionsSauvegardees
        {
            get { return _optionsSauvegardees; }
            set
            {
                foreach (OptionVehicule item in value)
                {
                    _optionsSauvegardees.Add(item);
                }
            }
        }
        public Memento(List<OptionVehicule> mesOptionsASauvegarer)
        {
            this._optionsSauvegardees = mesOptionsASauvegarer;
            Console.WriteLine("Options sauvegardées  :");
            foreach(OptionVehicule item in _optionsSauvegardees)
            {
                Console.WriteLine(item.Nom);
            }
            Console.WriteLine();
        }
    }
}
