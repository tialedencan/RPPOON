using System;
using System.Collections.Generic;

namespace LV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dataset dataset = new Dataset("D:/Faks/4.semestar/RPPOON/lv/csvFile.csv");

            IList<List<string>> dataFromCSVFile = dataset.GetData();
            for(int i=0; i<dataFromCSVFile.Count; i++)
            {
                for(int j=0; j < dataFromCSVFile[i].Count; j++)
                {
                    Console.WriteLine(dataFromCSVFile[i][j]);
                }
                
            }
                
        }
    }
}
