using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.Z2
{
    interface IAbstractIterator
    {
        bool IsDone { get; }
        Product GetCurrent { get; }
        Product First();
        Product Next();
    }
}
