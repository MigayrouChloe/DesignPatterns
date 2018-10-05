using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class DocumentHtml : IDocument
    {
        protected string _contenu;
        public string Contenu { protected get => _contenu; set => _contenu = value; }
       

        public void Dessine()
        {
            Console.WriteLine("Dessine le document HTML" + Contenu);
        }

        public void Imprime()
        {
            Console.WriteLine("Imprime le document HTML" + Contenu);
        }
    }
}
