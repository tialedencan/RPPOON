using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class RegistrationValidator : IRegistrationValidator
    {
        private EmailValidator emailValidator;
        private PasswordValidator passwordValidator;
        public RegistrationValidator()
        {
            this.emailValidator = new EmailValidator();
            this.passwordValidator = new PasswordValidator(5);

        }
        public bool IsUserEntryValid(UserEntry entry)
        {
            if (emailValidator.IsValidAddress(entry.Email) && passwordValidator.IsValidPassword(entry.Password))
            {
                return true;
            }
            return false;
        }

    }
}
