using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public class Modele : ObjetBase
    {
        protected string _nom;
        protected string _description;

        public Modele(string descriptionModele, string nom)
        {
            this._description = descriptionModele;
            this._nom = nom;
        }


        protected override string Description
        {
            get
            {
                if (_description != null)
                    return $"Modele {_nom} : {_description}";
                else return null;
            }
        }
    }
}
