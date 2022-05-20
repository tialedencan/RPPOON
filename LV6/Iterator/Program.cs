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
            IAbstractIterator<Note> iterator = notebook.GetIterator();
         
            for (Note n = iterator.First(); iterator.IsDone != true; n = iterator.Next())
            {
                n.Show();
            }

            //Z2

            Box box = new Box();
            box.AddProduct(new Product("Shoes", 215.5));
            box.AddProduct(new Product("Apples", 4.2));
            box.AddProduct(new Product("Juice", 1.5));

            IAbstractIterator<Product> boxIterator = box.GetIterator();
            do
            {
                boxIterator.GetCurrent.Show();

            }while(boxIterator.Next() != null);


        }
    }
}
