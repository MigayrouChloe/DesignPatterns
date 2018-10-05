using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Vendeur
    {
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Email { get; set; }


        /// <summary>
        /// On cree l'objet une fois
        /// </summary>
        private static Vendeur _instance = null;

        /// <summary>
        /// Constructeur par défaut en private. Si l'on veut creer des singleton
        /// Ici a but pedagogique on le laisse pour faire des essais. 
        /// </summary>
        public Vendeur() { }


        /// <summary>
        /// Lors de la premiere initialisation, _instance est null donc on initialise. 
        /// Lorsque l'on recreera une instance de vendeur : _instance ne sera pas nulle et 
        /// donc la fonction enregistrera le nouveau vendeur dans l'espace memoire de _instance
        /// </summary>
        /// <returns></returns>
        public static Vendeur Instance()
        {
            if(_instance == null)
                _instance = new Vendeur();

            return _instance;
        }

        public void Affiche()
        {
            Console.WriteLine($" Nom : {this.Nom} \n Adresse : {this.Adresse} \n Email : {this.Email}");
        }


    }
}
