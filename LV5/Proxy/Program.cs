using System;

namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = User.GenerateUser("John");
            ProtectionProxyDataset protectionProxy = new ProtectionProxyDataset(user);
            VirtualProxyDataset virtualProxy = new VirtualProxyDataset("sensitiveData.csv");

            DataConsolePrinter printer = new DataConsolePrinter();
            Console.WriteLine("Protection Proxy:");
            printer.PrintData(protectionProxy);
            Console.WriteLine("Virtual Proxy:");
            printer.PrintData(virtualProxy);
            LoggingProxyDataset loggingProxyDataset = new LoggingProxyDataset("message");
            Console.WriteLine("Logging Proxy");
            printer.PrintData(loggingProxyDataset);

        }
    }
}
