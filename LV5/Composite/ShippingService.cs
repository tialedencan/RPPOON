using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class ShippingService
    {
        private double unitPricePerMass;
        public ShippingService(double unitPricePerMass)
        {
            this.unitPricePerMass = unitPricePerMass;
        }
        public double CalculateShippingCost(IShipable item)
        {
            return item.Weight * unitPricePerMass;
        }

    }
}
