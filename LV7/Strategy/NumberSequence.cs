using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class NumberSequence
    {
        private double[] sequence;
        private int sequenceSize;
        private SortStrategy sortStrategy;
        private ISearchStrategy searchStrategy;
        
        public NumberSequence(int sequenceSize,SortStrategy sortStrategy,ISearchStrategy searchStrategy)
        {
            this.sequenceSize = sequenceSize;
            this.sequence = new double[sequenceSize];
            this.sortStrategy = sortStrategy;
            this.searchStrategy = searchStrategy;
        }
        
        public NumberSequence(double[] array, SortStrategy sortStrategy, ISearchStrategy searchStrategy) : this(array.Length, sortStrategy, searchStrategy)
        {
            array.CopyTo(this.sequence, 0);
        }
        public void InsertAt(int index, double value)
        {
            this.sequence[index] = value;
        }
        public void SetSortStrategy(SortStrategy strategy)
        {
            this.sortStrategy = strategy;
        }
        public void Sort() { this.sortStrategy.Sort(this.sequence); }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (double element in this.sequence)
            {
                builder.Append(element).Append(Environment.NewLine);
            }
            return builder.ToString();
        }
        public void SetSearchStrategy(ISearchStrategy strategy)
        {
            this.searchStrategy = strategy;
        }
      
        public int Find(double numberToSearchFor)
        {
            return this.searchStrategy.Find(this.sequence,numberToSearchFor);
        }
       
    }
}
