using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    interface IShipable
    {
        double Price { get; }
        double Weight { get; }
        string Description(int depth = 0);
    }
}
