using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class ConsoleLogger
    {
        private static ConsoleLogger instance;
        
        private ConsoleLogger()
        {
                       
        }
        public static ConsoleLogger GetInstance()
        {
            if (instance == null)
            {
                instance = new ConsoleLogger();
            }
            return instance;
        }
          
        public void Log(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine(DateTime.Now);
        }
    }
}
