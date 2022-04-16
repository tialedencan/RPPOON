using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    interface IRentable
    {
        String Description { get; }
        double CalculatePrice();
    }
}
