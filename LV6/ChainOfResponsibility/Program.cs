using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractLogger logger = new ConsoleLogger(MessageType.ALL);
            FileLogger fileLogger =
            new FileLogger(MessageType.ERROR | MessageType.WARNING, "logFile.txt");

            ConsoleLogger consoleLogger = new ConsoleLogger(MessageType.INFO);
            logger.SetNextLogger(fileLogger);
            logger.SetNextLogger(consoleLogger);
            logger.Log("It is shiny outside!", MessageType.INFO);
            logger.Log("Warning", MessageType.ERROR);
        }
    }
}
