using System;
using Tasks;

namespace Consolem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix(3, 4);
            Matrix matrix1 = new Matrix(4, 3);

            matrix.FillMatrixRandom();
            matrix1.FillMatrixRandom();

            matrix.WriteMatrixToConsole();
            Console.WriteLine("");
            matrix1.WriteMatrixToConsole();
            Console.WriteLine("");
            Matrix.WriteMatrixToConsole(matrix.MultiplicationMatrix(matrix1));
        }
    }
}
