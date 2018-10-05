using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /// <summary>
    /// L'objectif est de pouvoir utiliser une ddl installée par exemple ap. d'un Nugget.
    /// 
    /// Reference toutes les méthodes necessaires pour generer un document pdf i.e. on reference la bibliotheque installée dans ce code.
    /// On pourra ainsi venir modifier les proprietés sans avoir a modifier la dll importée
    /// </summary>
    public partial class ComposantPdf : Component
    {
        protected string _contenu;
 
        public void PdfFixeContenu(string contenu)
        {
            this._contenu = contenu; 
        }

        public void PdfPrepareAffichage()
        {
            Console.WriteLine("Affichage PDF : Début");
        }

        public void PdfRafraichit()
        {
            Console.WriteLine("Affichage contenu PDF : " + _contenu);
        }

        public void PdfTermineAffichage()
        {
            Console.WriteLine("Affichage PDF : Fin");
        }

        public void PdfEnvoieImprimante()
        {
            Console.WriteLine("Impression PDF : " + _contenu);
        }
    }
}
