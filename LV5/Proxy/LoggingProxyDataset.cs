using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Proxy
{
    class LoggingProxyDataset : IDataset
    {
        public ReadOnlyCollection<List<string>> GetData()
        {
            throw new NotImplementedException();
        }
    }
}
