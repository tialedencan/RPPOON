using System;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers=new double[] {1,4,2,3};
            NumberSequence sequence = new NumberSequence(numbers);
            Console.WriteLine(sequence.ToString());
            
            sequence.SetSearchStrategy(new LinearSearch());
            Console.WriteLine("Number is at index:"+sequence.Search(2));
            sequence.SetSortStrategy(new BubbleSort());
            sequence.Sort();
            Console.WriteLine(sequence);
            Console.WriteLine("Number is at index:" + sequence.Search(2));

        }
    }
}
