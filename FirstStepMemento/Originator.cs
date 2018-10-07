using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStepMemento
{
    public class Originator
    {
        private string _state { get; set; }

        public String State
        {
            get { return _state; }
            set { this._state = value;
                Console.WriteLine($"Etat : {this._state}");
            }
        }

        public void RestoreMemento (Memento memento)
        {
            Console.WriteLine("\n Restoring state -- \n");
            this._state = memento.State;
        }
        public Memento SaveMemento()
        {
            return new Memento(_state);
        }

        public Originator()
        {
            this._state = "";
        }
    }
}
