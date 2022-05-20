using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Z4
{
    class CareTakerForBankAccount
    {
        private List<MementoBankAccount> previousState;
        public CareTakerForBankAccount()
        {
            previousState = new List<MementoBankAccount>();
        }
        public void StoreMemento(MementoBankAccount memento)
        {
            previousState.Add(memento);
        }
        public MementoBankAccount GetMemento(int index)
        {
            if (previousState[index] == null)
            {
                throw new ArgumentNullException("Index out of range");
            }
            return previousState[index];
        }


    }
}
