using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public class Vehicule : ObjetBase
    {
        private string description;

        protected override string Description { get => description;  }
        public Vehicule(string descriptionVehicule)
        {
            this.description = descriptionVehicule;
        }
    }
}
