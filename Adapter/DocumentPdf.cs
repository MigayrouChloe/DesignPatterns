using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class DocumentPdf : IDocument
    {
        protected ComposantPdf _outilPdf = new ComposantPdf();
        public string Contenu { set => _outilPdf.PdfFixeContenu(value); }


        public void Dessine()
        {
            _outilPdf.PdfPrepareAffichage();
            _outilPdf.PdfRafraichit();
            _outilPdf.PdfTermineAffichage();
        }

        public void Imprime()
        {
            _outilPdf.PdfEnvoieImprimante();
        }
    }
}
