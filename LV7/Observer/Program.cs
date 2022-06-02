using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleSystemDataProvider dataProvider = new SystemDataProvider();
            dataProvider.Attach(new ConsoleLogger());
            int counter = 0;
            while (true)
            {
                dataProvider.Notify();
                counter++;
                if (counter > 25) break;
                System.Threading.Thread.Sleep(1000);

            }
        }
    }
}
