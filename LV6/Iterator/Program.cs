using System;
using Iterator.Z2;

namespace Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Note note = new Note("Welcome", "Hello");
            //note.Show();
            Notebook notebook = new Notebook();
            notebook.AddNote(note);
            notebook.AddNote(new Note("Secret message", "#####"));
            notebook.AddNote(new Note("Nice day", "Sun is shining!"));
            Iterator iterator = new Iterator(notebook);
            do
            {
                iterator.Current.Show();

            } while (iterator.Next() != null);

            //Z2

            Box box = new Box();
            box.AddProduct(new Product("Shoes", 215.5));
            box.AddProduct(new Product("Apples", 4.2));
            box.AddProduct(new Product("Juice", 1.5));

            BoxIterator boxIterator = new BoxIterator(box);
            do
            {
                boxIterator.GetCurrent.Show();

            }while(boxIterator.Next() != null);

        }
    }
}
