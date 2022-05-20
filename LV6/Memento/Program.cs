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
            careTaker.SetMemento(memento);
            ToDoItem vet = new ToDoItem("Veterinarian", "Bring a pet", new DateTime(2007, 10, 2)); 
            memento=vet.StoreState();
            Console.WriteLine(vet);
            careTaker.SetMemento(memento);

            toDoItem.Rename("Happy birthday");
            toDoItem.ChangeTask("Throw a party");
            Console.WriteLine(toDoItem);

            toDoItem.RestoreState(memento);
            Console.WriteLine(toDoItem);

            vet.Rename("Groomer");
            vet.ChangeTask("Appointment for Lex.");
            memento=vet.StoreState();

            //LV
            ToDoItem item = new ToDoItem("Solve", "Solve the problem", new DateTime(2022, 6, 9));
            CareTaker cTaker = new CareTaker();
            Console.WriteLine(item);
            Memento mementoForSecundItemToDo = item.StoreState();
            cTaker.SetMemento(mementoForSecundItemToDo);
            item.ChangeTimeDue(new DateTime(2033, 12, 12));
            item.Rename("#####");
            Console.WriteLine(item);
            item.RestoreState(cTaker.GetMemento(0));
            Console.WriteLine(item);

            //Z4
            BankAccount account = new BankAccount("Mark", "Park Street 10", 1500.2m);
            MementoBankAccount mementoBank=account.StoreState();
            CareTakerForBankAccount care= new CareTakerForBankAccount();
            care.StoreMemento(mementoBank);
            Console.WriteLine(account);
            account.ChangeOwnerAddress("Olive Street 4");
            Console.WriteLine(account);

            account.RestoreState(mementoBank);
            Console.WriteLine(account);
            account.RestoreState(care.GetMemento(0));
            Console.WriteLine(account);

         
            //LV
            BankAccount accountB = new BankAccount("Tia", "Park Street 4", 120.5m);
            CareTakerForBankAccount careTakerForBankAccount = new CareTakerForBankAccount();
            Console.WriteLine(accountB);
            MementoBankAccount mementoAccount = accountB.StoreState();
            careTakerForBankAccount.StoreMemento(mementoAccount);
            account.UpdateBalance(1250.7m);
            account.ChangeOwnerAddress("Happy Street 5");
            Console.WriteLine(account);
            account.RestoreState(careTakerForBankAccount.GetMemento(0));
            Console.WriteLine(account);
        }
    }
}
