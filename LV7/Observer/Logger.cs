using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    interface Logger
    {
        void Log(SimpleSystemDataProvider provider);
    }
}
