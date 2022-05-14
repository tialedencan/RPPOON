using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Z4
{
    class BankAccount
    {
        private string ownerName;
        private string ownerAddress;
        private decimal balance;
        public BankAccount(string ownerName, string ownerAddress, decimal balance)
        {
            this.ownerName = ownerName;
            this.ownerAddress = ownerAddress;
            this.balance = balance;
        }
        public void ChangeOwnerAddress(string address)
        {
            this.ownerAddress = address;
        }
        public void UpdateBalance(decimal amount) { this.balance += amount; }
        public string OwnerName { get { return this.ownerName; } }
        public string OwnerAddress { get { return this.ownerAddress; } }
        public decimal Balance { get { return this.balance; } }

        public override string ToString()
        {
            return $"Name:{ownerName}, address:{ownerAddress}, balance:{balance}";
        }
        public MementoBankAccount SetState()
        {
            return new MementoBankAccount(this.ownerName, this.ownerAddress, this.balance);
        }
        public void RestoreState(MementoBankAccount memento)
        {
            this.ownerName = memento.OwnerName;
            this.ownerAddress = memento.OwnerAddress;
            this.balance = memento.Balance;
        }
    }
}
