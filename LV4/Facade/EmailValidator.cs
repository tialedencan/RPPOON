using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class EmailValidator : IEmailValidatorService
    {
        public bool IsValidAddress(string candidate)
        {   
            bool isValid = false;
            int length = candidate.Length;
            StringBuilder domainHR=new StringBuilder();
            domainHR.Append(".");
            domainHR.Append(candidate[length - 2]);
            domainHR.Append(candidate[length - 1]);

            StringBuilder domainCOM = new StringBuilder();
            domainCOM.Append(".");
            for(int i = 3; i > 0; i--)
            {
                domainCOM.Append(candidate[length - i]);
            }
           
            if (candidate.Contains("@") && (domainHR.ToString().Equals(".hr") || domainCOM.ToString().Equals(".com")))
            {
                isValid = true;
            }
            return isValid;
        }
    }
}
