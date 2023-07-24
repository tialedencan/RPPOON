using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Proxy
{
   
    class LoggingProxyDataset : IDataset
    {
        private Dataset dataset;
        private string filepath;
        private ConsoleLogger logger;
        private string message;

        public LoggingProxyDataset(string filepath, string message)
        {
            this.filepath= filepath;
            this.message = message;
            
            
        }
        public ReadOnlyCollection<List<string>> GetData()
        { 
            this.logger=ConsoleLogger.GetInstance();
            logger.Log(this.message);

            if (dataset == null)
            {
                dataset = new Dataset(this.filepath);
            }
            return dataset.GetData();
            
           
        }
       
    }
}
