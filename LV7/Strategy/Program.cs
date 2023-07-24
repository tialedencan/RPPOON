using System;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator=new Random();
            double[] numbers=new double[10];
            for (int i=0; i<numbers.Length; i++)
            {
                numbers[i]=generator.NextDouble()*10;
            }
            NumberSequence sequence = new NumberSequence(numbers, new BubbleSort(),new LinearSearch());
            Console.WriteLine(sequence);
            sequence.Sort();
            Console.WriteLine(sequence);
            sequence.InsertAt(2, 2.3);
            sequence.InsertAt(5, 1.3);
            Console.WriteLine(sequence);
            sequence.SetSortStrategy(new SequentialSort());
            sequence.Sort();
            Console.WriteLine(sequence);
            sequence.InsertAt(2, 5.2);
            sequence.InsertAt(4, 1.2);
            Console.WriteLine(sequence);
            sequence.SetSortStrategy(new CombSort());
            sequence.Sort();
            Console.WriteLine(sequence);
            Console.WriteLine("Number is at index:"+sequence.Find(2.6));
            
            
            
            
            Console.WriteLine("Number is at index:" + sequence.Find(2));

        }
    }
}
