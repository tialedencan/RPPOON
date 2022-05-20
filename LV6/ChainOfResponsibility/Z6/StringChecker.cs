using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Z6
{
    abstract class StringChecker
    {
        public StringChecker Next { get; private set; }
        public void SetNext(StringChecker next)
        {
            this.Next = next;
        }
        public bool Check(string stringToCheck)
        {
            bool result = this.PerformCheck(stringToCheck);
            if (this.Next != null && result == true)
            {
                return this.Next.Check(stringToCheck);
            }
            return result;
        }
        protected abstract bool PerformCheck(string stringToCheck);
    }
}
