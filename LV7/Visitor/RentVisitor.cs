using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    internal class RentVisitor : IVisitor
    {
        public double Visit(DVD DVDItem)
        {
            if (DVDItem.Type == DVDType.SOFTWARE)
            {
                return DVDItem.Price;
            }
            return DVDItem.Price * 0.1;
        }

        public double Visit(VHS VHSItem)
        {
            return VHSItem.Price * 0.1;
        }

        public double Visit(Book book)
        {
            return book.Price * 0.1;
        }
    }
}
