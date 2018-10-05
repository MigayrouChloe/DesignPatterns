using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public class Marque : ObjetBase
    {
        protected string _premiereDescription, _deuxiemeDescription;
        protected string _nom;

        public Marque(string premiereDescription, string deuxiemeDescription, string nom)
        {
            this._premiereDescription = premiereDescription;
            this._deuxiemeDescription = deuxiemeDescription;
            this._nom = nom;
        }

        protected override string Description
        {
            get
            {
                if ((_premiereDescription != null) && (_deuxiemeDescription != null))
                    return $"Marque {_nom} : {_premiereDescription} {_deuxiemeDescription}";
                else if (_premiereDescription != null)
                    return $"Marque {_nom} : {_premiereDescription}";
                else return $"Marque {_nom}";
            }
        }
    }
}
