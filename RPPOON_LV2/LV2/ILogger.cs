using System;
using System.Collections.Generic;
using System.Text;

namespace LV2
{
    internal interface ILogger
    {
        void Log(ILogable data);
    }
}
