using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStepMemento
{
    public class Memento
    {
        private string _state;
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        public Memento(string state)
        {
            this._state = state ;
        }
    }
}
