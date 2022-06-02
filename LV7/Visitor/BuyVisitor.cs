using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class BuyVisitor:IVisitor
    {
        private const double DVDTax = 0.18;
        private const double VHSTax = 0.10;
        public double Visit(DVD DVDItem)
        {
            return DVDItem.Price * (1 + DVDTax);
        }
        public double Visit(VHS VHSItem)
        {
            return VHSItem.Price * (1 + DVDTax);
        }
    }
}
