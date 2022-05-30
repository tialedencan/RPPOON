using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    interface ISearchStrategy
    {
        int Search(double[] array, double requestedNumber);
    }
}
