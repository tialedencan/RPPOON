using System;
using Memento.Z4;

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
            careTaker.previousStates.Add(memento);
            ToDoItem vet = new ToDoItem("Veterinarian", "Bring a pet", new DateTime(2007, 10, 2)); 
            memento=vet.StoreState();
            Console.WriteLine(vet);
            careTaker.previousStates.Add(memento);

            toDoItem.Rename("Happy birthday");
            toDoItem.ChangeTask("Throw a party");
            Console.WriteLine(toDoItem);

            toDoItem.RestoreState(memento);
            Console.WriteLine(toDoItem);

            vet.Rename("Groomer");
            vet.ChangeTask("Appointment for Lex.");
            memento=vet.StoreState();

            //Z4
            BankAccount account = new BankAccount("Mark", "Park Street 10", 1500.2m);
            MementoBankAccount mementoBank=account.SetState();
            CareTakerForBankAccount care= new CareTakerForBankAccount();
            care.PreviousState = mementoBank;
            Console.WriteLine(account);
            account.ChangeOwnerAddress("Olive Street 4");
            Console.WriteLine(account);

            account.RestoreState(mementoBank);
            Console.WriteLine(account);
            account.RestoreState(care.PreviousState);
            Console.WriteLine(account);
        }
    }
}
