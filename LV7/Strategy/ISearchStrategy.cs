using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    interface ISearchStrategy
    {
        int Find(double[] array, double requestedNumber);
    }
}
