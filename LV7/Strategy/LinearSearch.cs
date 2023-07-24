using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class LinearSearch:ISearchStrategy
    {
        public int Find(double[] array, double requestedNumber)
        {
            int arraySize=array.Length;
            for(int i=0; i<arraySize; i++)
            {
                if (array[i] == requestedNumber)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
