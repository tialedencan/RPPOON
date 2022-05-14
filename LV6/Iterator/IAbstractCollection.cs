using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    interface IAbstractCollection
    {
        IAbstractIterator GetIterator();
    }
}
