using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ClasseAbstraite.Models
{
    public abstract class Pays
    {
        public abstract decimal CalculeTva(decimal montantHt);
    }
}