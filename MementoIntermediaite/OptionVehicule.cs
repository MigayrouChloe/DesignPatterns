using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoIntermediaite
{
    public class OptionVehicule
    {
        private string _nom;

        public string Nom
        {
            get { return _nom; }
            set { this._nom = value; }
        }

        public OptionVehicule(string nom)
        {
            this._nom = nom;
        }
    }
}
