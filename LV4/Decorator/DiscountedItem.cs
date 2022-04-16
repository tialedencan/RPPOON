using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{ //Klasa ima atribut za postotak popusta, koji se rabi u metodama propisanim sučeljem tako da se cijena umanjuje za dani postotak,
  //a u opis se uključuje „now at [XY]% off!“ nakon ispisivanja osnovnog opisa.
    class DiscountedItem : RentableDecorator
    {
        private int discountPercentage;
        public DiscountedItem(IRentable rentable, int discountPercentage) : base(rentable)
        {
            this.discountPercentage = discountPercentage;
        }
        public override double CalculatePrice()
        {
            return base.CalculatePrice()-(base.CalculatePrice()*(discountPercentage/100));
        }
        public override string Description
        {
            get
            {
                return  base.Description + $" now at {discountPercentage}% off!";
            }
        }
    }
}
