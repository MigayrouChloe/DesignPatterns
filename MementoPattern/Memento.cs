using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class Memento
    {
        protected List<OptionVehicule> _etat;

        public List<OptionVehicule> GetEtat()
        {
            return _etat;
        }
        public void SetEtat (List<OptionVehicule> etatCharriot)
        {
            this._etat = etatCharriot;
        }
    }
}
