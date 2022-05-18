using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Z6
{
    class StringLowerCaseChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            foreach (char c in stringToCheck)
            {
                if (c >= 97 && c <= 122)
                {
                    return true;
                }

            }
            return false;
        }
    }
}
