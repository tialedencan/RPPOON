using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Proxy
{
    /*Napisati proxy za logiranje dohvaćanja podataka objekta klase Dataset. Za potrebe logiranja napisati
singleton ConsoleLogger i koristiti ga u proxy-iju. Bilježiti uz odgovarajuću poruku i vrijeme pristupa. Za
potrebe testiranja može se iskoristiti primjer CSV datoteke u nastavku.*/
    class LoggingProxyDataset : IDataset
    {
        private Dataset dataset;
        private string filepath;
        private int attemptsToAccessCounter;
        private DateTime accessTime;

        public LoggingProxyDataset(string message)
        {
            this.filepath= "sensitiveData.csv";
            
            this.attemptsToAccessCounter = 0;
            this.accessTime = DateTime.Now;
            
        }
        public ReadOnlyCollection<List<string>> GetData()
        { 
            ConsoleLogger.GetInstance();

            if (dataset == null)
            {
                dataset = new Dataset(this.filepath);
            }
            return dataset.GetData();
            
           
        }
       
    }
}
