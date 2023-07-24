using System;

namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
             DataConsolePrinter printer = new DataConsolePrinter();
            VirtualProxyDataset virtualProxy = new VirtualProxyDataset("sensitiveData.csv");

            User user = User.GenerateUser("John");
            User secondUser = User.GenerateUser("Mark");
            Console.WriteLine("Protection Proxy:");
            ProtectionProxyDataset protectionProxy = new ProtectionProxyDataset(user);
            ProtectionProxyDataset protectionProxyForSecundUser = new ProtectionProxyDataset(secondUser);
            printer.PrintData(protectionProxy);
            printer.PrintData(protectionProxyForSecundUser);
           
            Console.WriteLine("Virtual Proxy:");
            printer.PrintData(virtualProxy);

            LoggingProxyDataset loggingProxyDataset = new LoggingProxyDataset("sensitiveData.csv","message");
            Console.WriteLine("Logging Proxy");
            printer.PrintData(loggingProxyDataset);

        }
    }
}
