using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecouverteInterface.Models
{
    public class Commande
    {
        public IPays PaysEnCours { get; set; }
        public decimal MontantHt{get;set;}

        public decimal CalculeMontantTtc()
        {
            return this.MontantHt + this.PaysEnCours.CalculeTva(this.MontantHt);
        }
    }
}
