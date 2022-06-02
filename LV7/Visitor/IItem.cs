using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    interface IItem
    {
        double Accept(IVisitor visitor);
    }
}
