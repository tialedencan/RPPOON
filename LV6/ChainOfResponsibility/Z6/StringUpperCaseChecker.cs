using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Z6
{
    class StringUpperCaseChecker: StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            
            for(int i = 0; i < stringToCheck.Length; i++)
            {
                if ( stringToCheck[i] >= 65 && stringToCheck[i] <= 90) 
                {
                        return true;
                }
                    
            }
            return false;
        }
    }
}
