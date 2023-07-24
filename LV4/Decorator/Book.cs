using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
     class Book:IRentable
    {
        private string title;
        private double baseBookPrice = 3.99;

        public Book(string title) { this.title = title; }
        public string Description { get { return this.title; } }

        public double CalculatePrice()
        {
            return baseBookPrice;
        }
    }
}
