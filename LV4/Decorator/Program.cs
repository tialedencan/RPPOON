using System;
using System.Collections.Generic;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IRentable> rentableItems = new List<IRentable>() { new Book("Crime and Punishment"), new Video("Savage dad"), 
                                                            new HotItem(new Book("Camao")), new HotItem(new Video("Funny cat"))};
            RentingConsolePrinter printer = new RentingConsolePrinter();
            Console.WriteLine("Items:");
            printer.DisplayItems(rentableItems);
            Console.WriteLine("Total price:");
            printer.PrintTotalPrice(rentableItems);

            List<IRentable> flashSale = new List<IRentable>() { new DiscountedItem(rentableItems[0],20), new DiscountedItem(rentableItems[1], 10),
                                                    new DiscountedItem(rentableItems[2],10),new DiscountedItem(rentableItems[3],15)};
            Console.WriteLine("Items:");
            printer.DisplayItems(flashSale);
            printer.PrintTotalPrice(flashSale); 

        }
    }
}
