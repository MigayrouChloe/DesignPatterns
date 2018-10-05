using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class LiasseClient : Liasse
    {

        public LiasseClient(string informations)
        {
            this.ListeDocument = new List<Document>();
            LiasseVierge liasseBase = LiasseVierge.Instance();
            IList<Document> documentsVierge = liasseBase.ListeDocument;
            foreach (var item in documentsVierge)
            {
                Document copieDocument = item.Dupliquer();
                copieDocument.SetContenu(informations);
                this.ListeDocument.Add(copieDocument);
            }
        }

        public void Afficher()
        {
            foreach (var item in this.ListeDocument)
                item.Afficher();
        }

        public void Imprimer()
        {
            foreach (var item in this.ListeDocument)
                item.Afficher();
        }

    }
}
