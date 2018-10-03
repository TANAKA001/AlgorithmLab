using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrix
    {
        public int[,] mult(int[,] a, int[,] b)
        {
            /*Multiply MATRIX demands:
             * the first one's num of COLS 
             * be equal to 
             * the second num of ROWS*/
            int rows = a.GetLength(0);
            int size = b.GetLength(0);
            int cols = b.GetLength(1);
            int[,] res = new int[rows, cols];

            for (int a_row = 0; a_row < rows; a_row++)
            {
                for (int b_col = 0; b_col < cols; b_col++)
                {
                    int ret = 0;
                    for (int b_row = 0; b_row < size; b_row++)
                    {
                        ret += a[a_row, b_row] * b[b_row, b_col];
                    }
                    res[a_row, b_col] = ret;
                }
            }
            return res;
        }

        public int[,] transpose(int[,] a)
        {
            int[,] res = new int[a.GetLength(1), a.GetLength(0)];

            for (int a_row = 0; a_row < a.GetLength(0); a_row++)
            {
                for (int a_col = 0; a_col < a.GetLength(1); a_col++)
                {
                    res[a_col, a_row] = a[a_row, a_col];
                }
            }
            return res;
        }

        public int[,] sum(int[,] a, int[,] b)
        {
            int[,] res = new int[a.GetLength(0), a.GetLength(1)];

            for (int row = 0; row < a.GetLength(0); row++)
            {
                for (int col = 0; col < a.GetLength(1); col++)
                {
                    res[row, col] = a[row, col] + b[row, col];
                }
            }
            return res;
        }

        public int determinant(int[,] a)
        {
            int result = 0;

            if (a.GetLength(0) == a.GetLength(1))
            {

                int[,] auxMatrix = new int[a.GetLength(0), a.GetLength(1) + 2];
                Array.Copy(a, auxMatrix,a.Length);
                //navigate each row
                for (int a_row = 0; a_row < a.GetLength(0); a_row++)
                {
                    auxMatrix[a_row, a.GetLength(1) + 1] = a[a_row, 1];
                    auxMatrix[a_row, a.GetLength(1) + 2] = a[a_row, 2];
                }

                for (int aux_row = 0; aux_row < auxMatrix.GetLength(0); aux_row++)
                {
                    for (int aux_col = 0; aux_col < auxMatrix.GetLength(1); aux_col++)
                    {

                    }
                }

            }
            else
            {
                Console.WriteLine("Nao é quadratica");
            }
            return result;
        }
    }
}
