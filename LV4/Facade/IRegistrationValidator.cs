using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    interface IRegistrationValidator
    {
        bool IsUserEntryValid(UserEntry entry);
    }
}
