using System;
using System.Collections.Generic;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IRentable> rentableItems = new List<IRentable>() { new Book("Crime and Punishment"), new Video("Savage dad")};
            RentingConsolePrinter printer = new RentingConsolePrinter();
            Console.WriteLine("Items:");
            printer.DisplayItems(rentableItems);
            Console.WriteLine("Total price:");
            printer.PrintTotalPrice(rentableItems);
        }
    }
}
