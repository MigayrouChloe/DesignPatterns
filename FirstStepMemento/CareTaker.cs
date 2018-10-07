using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStepMemento
{
    public class CareTaker
    {
        private Memento _memento;

        public Memento Memento
        {
            set { _memento = value;  }
            get { return _memento; }
        }
    }
}
