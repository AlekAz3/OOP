using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class Matrix
    {
        private int n;
        private int m;
        private int[,] matrix;

        public int N { get { return n; } }
        public int M { get { return m; } }

        public int[,] Matrixx { get { return matrix; } }

        public Matrix(int n, int m)
        {
            if (n < 0 || m < 0)
                throw new ArgumentException("Значение меньше 0");
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
                    matrix[i, j] = random.Next(0, 10);
        }

        public void FillMatrixRandom(int Seed)
        {
            Random random = new Random(Seed);
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    matrix[i, j] = random.Next(0, 10);
        }

        public void SetValueInMatrix(int n, int m, int value) 
        {
            if (n < 0 || m < 0)
                throw new ArgumentException("Значение меньше нуля");
            matrix[n, m] = value;
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

        public Matrix MultiplicationMatrix(Matrix matrixx)
        {
            if (this.N != matrixx.M)
                throw new ArgumentException("Низя");

            Matrix temp = new Matrix(N, matrixx.M);

            
            for (int i = 0; i < n; i++)
                for (int j = 0; j < matrixx.M; j++)
                    for (int k = 0; k < matrixx.N; k++)
                        temp.matrix[i, j] += this.matrix[i, k] * matrixx.Matrixx[k, j];
            
            return temp;
        }


        public Matrix Additionmatrix(Matrix matrixx)
        {
            if (this.N != matrixx.N && this.M != matrixx.M)
                throw new ArgumentException("Низя");
            Matrix temp_matrix = new Matrix(n, m);

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    temp_matrix.matrix[i, j] = this.matrix[i, j] + matrixx.Matrixx[i, j];

            return temp_matrix;

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
