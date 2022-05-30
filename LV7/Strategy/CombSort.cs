﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class CombSort:SortStrategy
    {
        public override void Sort(double[] array)
        {
            int arraySize = array.Length;
            int gap = arraySize;
            const double shrink = 1.3;
            bool sorted;
            do
            {
                sorted = true;
                gap = (int)(gap / shrink);
                if (gap > 1)
                {
                    sorted = false;
                }
                for (int i = 0; i + gap < arraySize; i++)
                {
                    if (array[i] > array[i + gap])
                    {
                        Swap(ref array[i], ref array[i + gap]);
                        sorted = false;
                    }
                }
            } while (!sorted);
        }
    }
}
