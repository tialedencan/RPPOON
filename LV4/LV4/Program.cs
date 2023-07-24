using System;

namespace LV4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dataset dataset = new Dataset("D:/Faks/4.semestar/RPPOON/lv/fileLV4.csv");
            Analyzer3rdParty analyzer = new Analyzer3rdParty();
            Adapter adapter = new Adapter(analyzer);
            double[] averagePerRow = adapter.CalculateAveragePerRow(dataset);
            Console.WriteLine("Average per row:");
            foreach(double number in averagePerRow)
            {
                Console.WriteLine(number);
            }
            double[] averagePerColumn = adapter.CalculateAveragePerColumn(dataset);
            Console.WriteLine("Average per column:");
            foreach (double number in averagePerColumn)
            {
                Console.WriteLine(number);
            }
            //nastane problem pri citanju file-a, spremi brojeve kao kdouble, ali je vrijednost cijela 0.1->1 i sl.

        }
    }
}
