using System;
using System.Collections.Generic;
using System.Text;
using ChainOfResponsibility.Z6;

namespace ChainOfResponsibility
{
    class PasswordValidator
    {
       private StringChecker passwordChecker;

        public PasswordValidator(StringChecker firstChecker)
        {
            this.passwordChecker = firstChecker;
        }

        public void AddStringChecker(StringChecker checker)
        {
            while (passwordChecker.Next != null)
            {
                passwordChecker=passwordChecker.Next;
            }
            passwordChecker.SetNext(checker);
        }

        public bool IsValidPassword(string password)
        {
            if (passwordChecker.Check(password))
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
