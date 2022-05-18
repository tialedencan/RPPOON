using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Z6
{
    class StringDigitChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            foreach (char c in stringToCheck) {

                if (c >= 48 && c <= 57)
                {
                    return true;
                }

            }
            return false;
           
        }
    }
}
