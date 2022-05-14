using System;

namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToDoItem toDoItem = new ToDoItem("Hello", "Hello World!", new DateTime(2022, 06, 09));
            Console.WriteLine(toDoItem);
            Memento memento = toDoItem.StoreState();
            CareTaker careTaker= new CareTaker();
            careTaker.PreviousState = memento;

            toDoItem.Rename("Happy birthday");
            toDoItem.ChangeTask("Throw a party");
            Console.WriteLine(toDoItem);
            toDoItem.RestoreState(memento);
            Console.WriteLine(toDoItem);

        }
    }
}
