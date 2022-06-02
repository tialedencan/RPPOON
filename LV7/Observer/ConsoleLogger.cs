using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    internal class ConsoleLogger:Logger
    {
        public void Log(SimpleSystemDataProvider provider)
        {
            //implementation missing

            System.IO.StreamWriter writer =
            new System.IO.StreamWriter( true);
            writer.WriteLine(DateTime.Now + "-> CPU load: " +
            provider.CPULoad + " Available RAM: " + provider.AvailableRAM);
            writer.Close();
        }
    }
}
