﻿using System;
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
            SystemDataProvider dataProvider = new SystemDataProvider();
            dataProvider.Attach(new ConsoleLogger());
            
            while (true)
            {
                dataProvider.GetAvailableRAM();
                dataProvider.GetCPULoad();
                System.Threading.Thread.Sleep(1000);

            }
        }
    }
}
