using System;
using System.Collections.Generic;
using LV3.Zad4;
using LV3.Zad5;

namespace LV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Z1
            Dataset dataset = new Dataset("D:/Faks/4.semestar/RPPOON/lv/csvFile.csv");
            Dataset datasetClone = (Dataset)dataset.Clone();

            IList<List<string>> dataFromCSVFile = dataset.GetData();

            for (int i = 0; i < dataFromCSVFile.Count; i++)
            {
                for (int j = 0; j < dataFromCSVFile[i].Count; j++)
                {
                    Console.Write(dataFromCSVFile[i][j]);
                }
                Console.Write("\n");
            }

            Console.WriteLine(datasetClone);
            #endregion

            #region Z2
            Console.WriteLine("Matrix:");

            MatrixGenerator matrix = MatrixGenerator.GetInstance();

            for (int i = 0; i < matrix.GetMatrix(2, 3).Length; i++)
            {
                for (int j = 0; j < matrix.GetMatrix(2, 3)[i].Length; j++)
                {
                    Console.Write(matrix.GetMatrix(2, 3)[i][j]+" ");

                }
                Console.Write("\n");
            }
            Console.Write("\n");
            #endregion

            #region Z3
            FileLogger logger = FileLogger.GetInstance();
            logger.Log("Hello!");
            logger.Log("Nice to meet you.");  
            
            logger.SetFilePath("D:/Faks/4.semestar/RPPOON/lv/file.txt");
            logger.Log("Hello!");
            #endregion

            #region Z4
            ConsoleNotification notification = new ConsoleNotification("Tia", "Wednesday", "Today is wednesday.", 
                                                   new DateTime(2022, 4, 6), Category.INFO,ConsoleColor.Magenta);
            NotificationManager notificationManager = new NotificationManager();
            notificationManager.Display(notification);
            #endregion

            #region Z5,6,7
            NotificationBuilder builder = new NotificationBuilder();
            builder.SetText("Hello world :)");
            builder.SetColor(ConsoleColor.DarkBlue);
            ConsoleNotification note = builder.Build();
            
            ConsoleNotification noteCopy= (ConsoleNotification)note.Clone();
            notificationManager.Display(note);
            notificationManager.Display(noteCopy);
            #endregion
        }
    }
}
