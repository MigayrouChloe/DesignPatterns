using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ChainOfResponsability
{
    public abstract class ObjetBase 
    {
        public ObjetBase Suivant { protected get; set; }

        protected abstract string Description { get; }

        public string DonneDescription()
        {
            string resultat = this.Description;
            if (resultat != null)
                return resultat;
            if (Suivant != null)
                return Suivant.DonneDescription();
            else return this._descriptionParDefaut();
        }

        private string _descriptionParDefaut()
        {
            return "Description par défaut";
        }
        
    }
}