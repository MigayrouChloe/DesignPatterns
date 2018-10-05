using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class LiasseDoc : Liasse
    {
        public override void AjouteDocument(string document)
        {
            if(document.StartsWith("<DOC>"))
            contenu.Add(document);
        }

        public override void Imprime()
        {
            Console.WriteLine("Liasse DOC");
            foreach (string s in contenu)
            {
                Console.WriteLine(s);
            }
        }
    }
}
