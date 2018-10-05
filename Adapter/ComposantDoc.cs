using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public partial class ComposantDoc : Component
    {
        protected string _contenu;

        public void DocFixeContenu(string contenu)
        {
            this._contenu = contenu;
        }

        public void DocPrepareAffichage()
        {
            Console.WriteLine("Prepare la structure du document");
        }

        public void DocRafraichit()
        {
            Console.WriteLine(_contenu);
        }

        public void DocTermineAffichage()
        {
            Console.WriteLine("Finalise la mise en page du document");
        }

        public void DocEnvoiImprimante()
        {
            Console.WriteLine("Imprime le document .doc");
        }

    }
}
