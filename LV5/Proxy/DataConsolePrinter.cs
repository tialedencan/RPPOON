using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Proxy
{
    class DataConsolePrinter
    {
        public void PrintData(IDataset dataset)
        {
            ReadOnlyCollection<List<string>> data = dataset.GetData();
            foreach(var item in data)
            {
                foreach(string value in item)
                {
                    Console.Write(value + " ");
                }
               Console.WriteLine();
            }
                
        }
        
    }
}
