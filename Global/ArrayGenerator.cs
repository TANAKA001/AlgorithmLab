using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global
{
    public class ArrayGenerator
    {
        public static int[] array1D()
        {
            Random rnd = new Random();
            
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = rnd.Next(1, 99);
            }

            return arr;
        }

        public static int[,] array2D()
        {
            Random rnd = new Random();

            int[,] array2D = new int[6,6];

            for (int i = 0; i <= 6; i++)
            {
                for (int j = 0; j <= 6; i++)
                {
                    array2D[i, j] = rnd.Next(1, 10);
                }
            }

            return array2D;
        }
    }
}
