using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public interface IDocument
    {
        #region Deux facons de declarer le setter
        //void SetContenu(string contenu);
        string Contenu { set; }
        #endregion

        void Dessine();
        void Imprime();
    }
}
