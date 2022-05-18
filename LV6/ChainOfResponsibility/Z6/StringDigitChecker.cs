using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Z6
{
    class StringDigitChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            if (stringToCheck.Contains("1") || stringToCheck.Contains("2") || stringToCheck.Contains("3") ||
                stringToCheck.Contains("4") || stringToCheck.Contains("5") || stringToCheck.Contains("6") ||
                stringToCheck.Contains("7") || stringToCheck.Contains("8") || stringToCheck.Contains("9") ||
                stringToCheck.Contains("0"))
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
