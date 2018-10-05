using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class WebServer
    {
        public void LoadAdapter()
        {
            IDocument documentPdf, documentHtml, documentDoc;
            documentPdf = new DocumentPdf();
            documentPdf.Contenu = "Mon document PDF";
            documentPdf.Dessine();

            documentHtml = new DocumentHtml();
            documentHtml.Contenu = "Mon document HTML";
            documentHtml.Dessine();

            documentDoc = new DocumentDoc();
            documentDoc.Contenu = "Mon document DOC";
            documentDoc.Dessine();
        }

    }
}
