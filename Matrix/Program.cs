using System;
using Global;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrixA = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            int[,] matrixB = new int[2, 2] { { 5, 6 }, { 7, 8 } };
            int[,] matrixC = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            int[,] matrixD = new int[2, 3] { { 1, 2, 4 }, { 3, 4, 5 } };

            Matrix _matrix = new Matrix();

            Console.WriteLine("Multiplication:");
            PrintArray.printMatrix(_matrix.mult(matrixA, matrixB));

            Console.WriteLine("Transpose:");
            PrintArray.printMatrix(_matrix.transpose(matrixC));

            Console.WriteLine("Sum:");
            PrintArray.printMatrix(_matrix.sum(matrixA, matrixB));

            Console.WriteLine("Determinant:");
            Console.WriteLine(_matrix.determinant(matrixA));

            Console.ReadLine();

        }
    }
}
