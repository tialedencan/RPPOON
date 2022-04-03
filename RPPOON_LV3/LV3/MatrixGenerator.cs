using System;
using System.Collections.Generic;
using System.Text;

namespace LV3
{
    class MatrixGenerator
    {
        private static MatrixGenerator instance;
        private double[][] matrix;
      
        private MatrixGenerator(int numberOfRows, int numberOfColumns)
        {
            Random generator = new Random();

            this.matrix = new double[numberOfRows][];

            for(int i = 0; i < numberOfRows; i++)
            {
                matrix[i] = new double[numberOfColumns];

                for(int j=0; j < numberOfColumns; j++)
                {
                    matrix[i][j] = generator.NextDouble();
                }
            }
        }  
        public static MatrixGenerator GetInstance(int numberOfRows, int numberOfColumns)
        {
            if (instance == null)
            {
                instance = new MatrixGenerator(numberOfRows,numberOfColumns);
            }
            return instance;
            
        }

        public double[][] GetMatrix()
        {
            return matrix;
        }
    }
}
