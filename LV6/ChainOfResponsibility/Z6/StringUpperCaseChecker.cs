using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Z6
{
    class StringUpperCaseChecker: StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            string upperCaseStringToCheck=stringToCheck.ToUpper();

            for(int i = 0; i < stringToCheck.Length; i++)
            {
                if (upperCaseStringToCheck[i].Equals(stringToCheck[i]))
                {
                        return true;
                }
                    
            }
            return false;
        }
    }
}
