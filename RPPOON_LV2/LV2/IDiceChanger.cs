using System;
using System.Collections.Generic;
using System.Text;

namespace LV2
{
    internal interface IDiceChanger
    {
        void InsertDie(Die die);
        void RemoveAllDice();
    }
}
