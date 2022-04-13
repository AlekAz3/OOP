using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Matrix
    {
        private int n;
        private int m;
        private int[,] matrix;

        public Matrix(int n, int m)
        {
            if (n < 0 || m < 0)
                throw new ArgumentException();
            else
            {
                this.n = n;
                this.m = m;
                matrix = new int[n, m];
            }
        }

        public void FillMatrixRandom()
        {
            Random random = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    matrix[i, j] = random.Next(10, 99);
        }

        public int[,] TranspositionMatrix()
        {
            int[,] TransMat = new int[m, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    TransMat[j, i] = matrix[i, j];
            return TransMat;
        }

        public void WriteMatrixToConsole()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write($"{matrix[i,j]} ");
                Console.WriteLine();
            }
        }

        public static void WriteMatrixToConsole(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($"{matrix[i, j]} ");
                Console.WriteLine();
            }
        }
    }
}
