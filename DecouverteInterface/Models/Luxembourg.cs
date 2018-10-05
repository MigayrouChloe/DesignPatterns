using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecouverteInterface.Models
{
    public class Luxembourg : IPays
    {

        public decimal CalculeTva(decimal montantHt)
        {
            return montantHt * 0.15M;
        }
    }
}
