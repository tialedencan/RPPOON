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
            logger.Log("Warning", MessageType.ERROR);

            //Z6
            StringChecker checker = new StringDigitChecker();
            checker.SetNext(new StringLengthChecker());
            checker.SetNext(new StringUpperCaseChecker());
            checker.SetNext(new StringLowerCaseChecker());
            Console.WriteLine(checker.Check("Ola Maria4"));
            StringChecker upperCaseChecker=new StringUpperCaseChecker();
            Console.WriteLine(upperCaseChecker.Check("olamaria"));
            StringChecker stringLongerThan15Caracters=new StringLengthChecker();
            Console.WriteLine(stringLongerThan15Caracters.Check("ferit"));

            //Z7
            PasswordValidator passwordValidator = new PasswordValidator(upperCaseChecker);
            StringChecker digitChecker=new StringDigitChecker();
            passwordValidator.AddStringChecker(digitChecker);
            Console.WriteLine(passwordValidator.IsValidPassword("Eduard123"));

        }
    }
}
