using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class Book:IItem
    {
        public string Title { get; private set; }
        public double Price { get; private set; }

        public double Accept(IVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
