using System;
using System.Collections.Generic;
using System.Text;

namespace LV3
{
    class MatrixGenerator
    {
        private static MatrixGenerator instance;
        private Random generator;
        private MatrixGenerator()
        {
            this.generator = new Random();
        }  
        public static MatrixGenerator GetInstance()
        {
            if (instance == null)
            {
                instance = new MatrixGenerator();
            }
            return instance;
            
        }

        public double[][] GetMatrix(int numberOfRows, int numberOfColumns)
        {
            double[][] matrix = new double[numberOfRows][];
            
            for (int i = 0; i < numberOfRows; i++)
            {
                matrix[i] = new double[numberOfColumns];

                for (int j = 0; j < numberOfColumns; j++)
                {
                    matrix[i][j] = generator.NextDouble();
                }
            }
            return matrix;
        }
    }
}
