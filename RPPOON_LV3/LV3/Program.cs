using System;
using System.Collections.Generic;

namespace LV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dataset dataset = new Dataset("D:/Faks/4.semestar/RPPOON/lv/csvFile.csv");
            Dataset datasetClone = (Dataset)dataset.Clone();

            IList<List<string>> dataFromCSVFile = dataset.GetData();
            IList<List<string>> dataCopy = datasetClone.GetData();

            for (int i = 0; i < dataFromCSVFile.Count; i++)
            {
                for (int j = 0; j < dataFromCSVFile[i].Count; j++)
                {
                    Console.WriteLine(dataFromCSVFile[i][j]);
                }
            }

            for (int i = 0; i < dataCopy.Count; i++)
            {
                for (int j = 0; j < dataCopy[i].Count; j++)
                {
                    Console.WriteLine(dataCopy[i][j]);
                }
            }

            Console.WriteLine("\nMatrix:");

            MatrixGenerator matrix = MatrixGenerator.GetInstance();

            for (int i = 0; i < matrix.GetMatrix(2, 3).Length; i++)
            {
                for (int j = 0; j < matrix.GetMatrix(2, 3)[i].Length; j++)
                {
                    Console.Write(matrix.GetMatrix(2, 3)[i][j]+" ");

                }
                Console.Write("\n");
            }

            FileLogger logger = FileLogger.GetInstance();
            logger.Log("Hello!");
            logger.Log("Nice to meet you."); //prebrisat ce prethodnu 

            logger.SetFilePath("D:/Faks/4.semestar/RPPOON/lv/file.txt");
            logger.Log("Hello!");
           
        }
    }
}
