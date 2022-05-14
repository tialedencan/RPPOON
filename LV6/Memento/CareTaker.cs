using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    class CareTaker
    {
        public List<Memento> previousStates { get; set; }

        public CareTaker()
        {
            previousStates = new List<Memento>();
        }
    }
}
