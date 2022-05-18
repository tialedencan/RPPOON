using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Z6
{
    class StringLengthChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            if (stringToCheck.Length > 15)
            {
                return true;
            }
            else 
            { 
                return false;
            }
        }
    }
}
