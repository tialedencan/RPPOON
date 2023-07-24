using System;

namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Hamlet",235.6);
            Console.WriteLine(book);
            VHS vhs = new VHS("Green Book", 350);
            Console.WriteLine(vhs);
            DVD dvd = new DVD("My movie", DVDType.MOVIE, 125.4);
            Console.WriteLine(dvd);
            DVD software = new DVD("Some", DVDType.SOFTWARE, 550);
            BuyVisitor visitor = new BuyVisitor();
            Console.WriteLine(visitor.Visit(book));
            Console.WriteLine(visitor.Visit(vhs));
            Console.WriteLine(dvd.Accept(visitor));

            RentVisitor visitorForRentingItems = new RentVisitor();
            Console.WriteLine(visitorForRentingItems.Visit(software));
            Console.WriteLine(book.Accept(visitorForRentingItems));

            Cart cart = new Cart(visitorForRentingItems);
            cart.AddItem(book);
            cart.AddItem(vhs);
            cart.AddItem(software);
            cart.AddItem(dvd);
            Console.WriteLine(cart.Accept());
        
        }
    }
}
