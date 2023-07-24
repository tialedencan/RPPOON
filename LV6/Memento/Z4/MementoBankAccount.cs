using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Z4
{
    class MementoBankAccount
    {
        public string OwnerName { get; private set; }
        public string OwnerAddress { get; private set; }
        public decimal Balance { get; private set; }
        public MementoBankAccount(string ownerName, string ownerAddress, decimal balance)
        {
            this.OwnerName = ownerName;
            this.OwnerAddress = ownerAddress;
            this.Balance = balance;
        }
    }
}
