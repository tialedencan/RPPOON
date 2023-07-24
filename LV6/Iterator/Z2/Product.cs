using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.Z2
{
    internal class Product
    {
        public string Description { get; private set; }
        public double Price { get; private set; }
        public Product(string description, double price)
        {
            this.Description = description;
            this.Price = price;
        }
        public override string ToString()
        {
            return this.Description + ":\n" + this.Price;
        }
        public void Show()
        {
            Console.WriteLine(this.Description);
            Console.WriteLine(this.Price);
            
        }
    }
}
