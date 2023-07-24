using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    interface IPasswordValidatorService
    {
        bool IsValidPassword(String candidate);
    }
}
