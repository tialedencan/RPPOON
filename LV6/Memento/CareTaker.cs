using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    class CareTaker
    {
        private List<Memento> previousStates;
        
        public CareTaker()
        {
            previousStates = new List<Memento>();
        }
        public Memento GetMemento(int index)
        {
            if (previousStates[index] == null)
            {
                throw new ArgumentNullException("Index out of range");
            }
            return previousStates[index];
        }
        public void SetMemento(Memento memento)
        {
            previousStates.Add(memento);
        }
    }
}
