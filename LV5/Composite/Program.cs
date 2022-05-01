using System;

namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box shoeBox = new Box("Adidas shoes");
            Box ultraBoostShoes = new Box("Adidas Ultra Boost shoes");

            ultraBoostShoes.Add(new Product("UltraBOOSt 21", 160, 170));
            ultraBoostShoes.Add(new Product("UltraBOOST 20", 150, 180));

            shoeBox.Add(new Product("Ozelia", 110, 190));
            shoeBox.Add(ultraBoostShoes);

            Console.WriteLine(shoeBox.Description());
            Console.WriteLine($"Price: {shoeBox.Price}");
            Console.WriteLine($"Weight: {shoeBox.Weight}");

            ShippingService deliveryExpress = new ShippingService(0.01);
            Console.WriteLine($"Shipping cost: {deliveryExpress.CalculateShippingCost(shoeBox.Weight)}");
        }
    }
}
