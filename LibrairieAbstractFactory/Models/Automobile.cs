using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrairieAbstractFactory.Models
{
    public abstract class Automobile
    {
        #region Proprietes
        protected string Couleur;
        protected string Modele;
        protected int Puissance;
        protected double Espace;
        #endregion

        #region Methodes
        /// <summary>
        /// Constructeur parent 
        /// </summary>

        public Automobile(string couleur, string modele, int puissance, double espace)
        {
            this.Couleur = couleur;
            this.Modele = modele;
            this.Puissance = puissance;
            this.Espace = espace;
        }

        public abstract void AfficheCaracteristique();
        #endregion





    }
}
