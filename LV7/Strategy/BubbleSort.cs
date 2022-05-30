using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class BubbleSort:SortStrategy
    {
        public override void Sort(double[] array)
        {
            int arraySize=array.Length;
            for (int i=0; i<arraySize; i++)
            {
                for(int j=0; j<arraySize-i-1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j],ref array[j + 1]);
                    }
                }
            }
        }
    }
}
