using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class Liasse
    {
        #region Version condensée
        public IList<Document> ListeDocument { get; protected set; }
        #endregion

        #region Version détaillée 
        //protected IList<Document> ListeDocument;
        //protected void SetDocuments(Document document)
        //{
        //    this.ListeDocument.Add(document);
        //}

        //public IList<Document> GetDocuments()
        //{
        //    return this.ListeDocument;
        //}
        #endregion

    }
}
