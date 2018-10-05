using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ClasseAbstraite.Models
{

    public class Commande
    {
        public Pays Pays { get; set; }
        public decimal MontantHt { get; set; }

        public decimal CalculeMontantTtc()
        {
            return this.MontantHt + this.Pays.CalculeTva(this.MontantHt);
        }
    }
}