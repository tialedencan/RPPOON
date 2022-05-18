using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Z6
{
    class StringUpperCaseChecker: StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            //string upperCaseStringToCheck=stringToCheck.ToUpper();

            for(int i = 0; i < stringToCheck.Length; i++)
            {
                if ( stringToCheck[i] >= 65 && stringToCheck[i] <= 90) //upperCaseStringToCheck[i].Equals(stringToCheck[i]) nisam u obzir uzimala brojke i druge simbole koji bi dali true
                {
                        return true;
                }
                    
            }
            return false;
        }
    }
}
