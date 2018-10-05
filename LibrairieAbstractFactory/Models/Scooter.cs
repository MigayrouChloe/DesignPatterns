using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrairieAbstractFactory.Models
{
    public abstract class Scooter
    {

        #region Proprietes
        protected string Couleur;
        protected string Modele;
        protected int Puissance;
        #endregion

        #region Methodes
        public Scooter(string couleur, string modele, int puissance)
        {
            this.Couleur = couleur;
            this.Modele = modele;
            this.Puissance = puissance;
        }

        public abstract void AfficheCaracteristique();
        
        #endregion

    }
}
