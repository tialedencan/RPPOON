using System;

namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string email = "world@gmail.com";
            string password = "Wor1D";
            EmailValidator emailValidator = new EmailValidator();
            PasswordValidator passwordValidator = new PasswordValidator(5);
            if (emailValidator.IsValidAddress(email))
            {
                Console.WriteLine("Email address is valid.");
            }
            else { Console.WriteLine("Email address is not valid."); }
            if (passwordValidator.IsValidPassword(password))
            {
                Console.WriteLine("Password address is valid.");
            }
            else { Console.WriteLine("Password is not valid."); }
        }
    }
}
