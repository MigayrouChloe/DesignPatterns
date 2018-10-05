using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class LiasseVierge : Liasse
    {

        private static LiasseVierge _instance = null;

        private LiasseVierge()
        {
            this.ListeDocument = new List<Document>();
        }

        public static LiasseVierge Instance()
        {
            if (_instance == null)
                _instance = new LiasseVierge();
            return _instance;
        }

        public void Ajouter(Document document)
        {
            this.ListeDocument.Add(document);
        }

        public void Retirer(Document document)
        {
            this.ListeDocument.Remove(document);
        }
    }
}
