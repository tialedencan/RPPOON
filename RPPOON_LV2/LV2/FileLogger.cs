using System;
using System.Collections.Generic;
using System.Text;

namespace LV2
{
    internal class FileLogger:ILogger
    {      
        private string filePath;
          
        public FileLogger(string filePath)
        {
            this.filePath = filePath;
        } 
        public void Log(string message)
        {
            using (System.IO.StreamWriter writer =
            new System.IO.StreamWriter(this.filePath))
            {
                writer.WriteLine(message);
            }
        }
    }
}
