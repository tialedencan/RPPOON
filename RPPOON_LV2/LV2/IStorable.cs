using System;
using System.Collections.Generic;
using System.Text;

namespace LV2
{
    internal interface IStorable
    {
        void InsertDie(Die die);
        void RemoveAllDice();
    }
}
