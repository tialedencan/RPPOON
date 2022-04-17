using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    interface IEmailValidatorService
    {
        bool IsValidAddress(String candidate);
    }
}
