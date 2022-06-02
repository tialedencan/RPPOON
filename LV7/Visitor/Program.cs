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

            BuyVisitor visitor = new BuyVisitor();
            Console.WriteLine(visitor.Visit(book));
            Console.WriteLine(visitor.Visit(vhs));
            Console.WriteLine(dvd.Accept(visitor));

        }
    }
}
