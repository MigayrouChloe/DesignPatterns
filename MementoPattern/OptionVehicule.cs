using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class OptionVehicule
    {
        protected string _nom { get; set; }
        public List<OptionVehicule> _optionsIncompatibles { get; protected set; }

        public OptionVehicule(string nom)
        {
            this._nom = nom;
            _optionsIncompatibles = new List<OptionVehicule>();
            _optionsIncompatibles.Add(this);
        }

        public void AjouteOptionIncompatibles(OptionVehicule optionIncompatible)
        {
            if (!_optionsIncompatibles.Contains(optionIncompatible))
            {
                _optionsIncompatibles.Add(optionIncompatible);
            }
        }

        public void AfficheCaracteristique()
        {
            Console.Write($"{_nom.ToUpper()} est incompatible avec : \n");
            foreach (var item in _optionsIncompatibles)
            {
                Console.WriteLine("-" + item._nom);
            }
            Console.WriteLine("\n");
        }

        public void Affiche()
        {
            Console.Write($"{_nom.ToUpper()}");
        }
    }
}
