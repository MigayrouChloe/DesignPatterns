using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecouverteInterface.Models
{
    public interface IPays
    {
        decimal CalculeTva(decimal montantHt);
    }
}
