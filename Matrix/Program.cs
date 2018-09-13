using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrixA = new int[2, 2] {{ 1, 2 }, { 3, 4 }};
            int[,] matrixB = new int[2, 2] {{ 5, 6 }, { 7, 8 }};
            int[,] matrixC = new int[4, 2] { { 1, 2 }, { 3, 4 },{ 5, 6 }, { 7, 8 } };

            Matrix _matrix = new Matrix();
            int[,] mult = _matrix.mult(matrixA, matrixB);
            int[,] transpose = _matrix.transpose(matrixC);
            int[,] sum = _matrix.sum(matrixA, matrixB);
            
            Console.WriteLine(/*printar a matriz*/);

            Console.ReadLine();

        }
    }
}
