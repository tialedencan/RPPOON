using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Z6
{
    class StringLowerCaseChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            for (int i=0; i<stringToCheck.Length; i++)
            {
                if (stringToCheck.ToLower()[i].Equals(stringToCheck[i]))
                {
                    return true;
                }

            }
            return false;
        }
    }
}
