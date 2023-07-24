using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Proxy
{
    interface IDataset
    {
        ReadOnlyCollection<List<string>> GetData();
    }
}
