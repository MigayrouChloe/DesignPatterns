
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ClasseAbstraite.Models
{
    public class France : Pays
    {
        public override decimal CalculeTva(decimal montantHT)
        {
            return montantHT * 0.196M;
        }
    }
}