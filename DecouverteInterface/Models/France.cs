using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecouverteInterface.Models
{
    public class France : IPays
    {
        public decimal CalculeTva(decimal montantHT)
        {
            return montantHT * 0.196M;
        }

    }
}
