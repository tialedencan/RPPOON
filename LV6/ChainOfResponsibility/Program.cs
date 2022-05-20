using System;
using ChainOfResponsibility.Z6;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractLogger logger = new ConsoleLogger(MessageType.ALL);
            FileLogger fileLogger =
            new FileLogger(MessageType.ERROR | MessageType.WARNING, "logFile.txt");

            logger.SetNextLogger(fileLogger);
            logger.Log("It is shiny outside!", MessageType.INFO);
            logger.Log("Error", MessageType.ERROR);
            logger.Log("Warning", MessageType.WARNING);

            //Z6
            StringChecker checker = new StringDigitChecker();
            StringChecker lengthChecker = new StringLengthChecker();
            StringChecker upperCaseChecker = new StringUpperCaseChecker();
            StringChecker lowerCaseChecker = new StringLowerCaseChecker();

            checker.SetNext(lengthChecker);
            lengthChecker.SetNext(upperCaseChecker);
            upperCaseChecker.SetNext(lowerCaseChecker);

            Console.WriteLine(checker.Check("AbCd14#"));
            Console.WriteLine(checker.Check("AbC1"));
            Console.WriteLine(checker.Check("sdfebd14#"));
            Console.WriteLine(checker.Check("AC14##"));
            Console.WriteLine(checker.Check("AbCduif#"));


            //Z7
            StringChecker digitChecker=new StringDigitChecker();
            StringChecker lengthChecker2 = new StringLengthChecker();
            StringChecker upperCaseChecker2 = new StringUpperCaseChecker();
            StringChecker lowerCaseChecker2 = new StringLowerCaseChecker();

            PasswordValidator passwordValidator = new PasswordValidator(digitChecker);
            passwordValidator.AddStringChecker(lengthChecker2);
            passwordValidator.AddStringChecker(upperCaseChecker2);
            passwordValidator.AddStringChecker(lowerCaseChecker2);
            Console.WriteLine("Passsword valid: " + passwordValidator.IsValidPassword("Eduard123"));


        }
    }
}
