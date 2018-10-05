using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class DocumentDoc : IDocument
    {

        protected ComposantDoc _outilDoc = new ComposantDoc();

        public string Contenu { set => _outilDoc.DocFixeContenu(value); }

        public void Dessine()
        {
            _outilDoc.DocPrepareAffichage();
            _outilDoc.DocRafraichit();
            _outilDoc.DocTermineAffichage();
        }

        public void Imprime()
        {
            _outilDoc.DocEnvoiImprimante();
        }

    }
}
