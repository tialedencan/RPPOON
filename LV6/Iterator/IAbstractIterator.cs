using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    interface IAbstractIterator
    {
        Note First();
        Note Next();
        bool IsDone { get; }
        Note Current { get; }
    }
}
