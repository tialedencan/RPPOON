using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace LV3
{
    class FileLogger
    {
        private static FileLogger instance;
        private string filePath;
        
        private FileLogger()
        {
            this.filePath = "D:/Faks/4.semestar/RPPOON/lv/testFile.txt";
        }
       
        public static FileLogger GetInstance()
        {
            if (instance == null)
            {
                instance = new FileLogger();
            }
            return instance;
        }
        public void SetFilePath(string filePath)
        {
            this.filePath = filePath;
                        
        }
        public void Log(string text)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(text);
            }   
            
        }
       
    }
}
