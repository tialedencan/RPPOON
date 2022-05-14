using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.Z2
{
    interface IAbstractCollection
    {
        IAbstractIterator GetIterator();
    }
}
