using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class Document
    {
        protected string Contenu { get; set; }

        public void SetContenu(string contenu)
        {
            this.Contenu = contenu;
        }
        public Document Dupliquer()
        {
            return (Document)this.MemberwiseClone();
        }

        public abstract void Imprimer();
        public abstract void Afficher();
    }
}
