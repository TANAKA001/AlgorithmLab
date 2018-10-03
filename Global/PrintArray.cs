using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global
{
    public class PrintArray
    {
        public static void printArray(int[] arr)
        {
            Console.WriteLine(@"{");
            for (int i = 0; i < arr.Length; ++i)
                Console.Write(arr[i] + ",");
            Console.WriteLine(@"}");
        }

        public static void printMatrix(int[,] arr)
        {
            Console.WriteLine(@"{");
            for (int i = 0; i < arr.GetLength(0); ++i)
            {
                Console.Write(@"{");
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]);
                    if (j != arr.GetLength(1)-1)
                    {
                        Console.Write(@",");
                    }
                    else
                    {
                        Console.WriteLine(@"},");
                    }
                }
            }
            Console.WriteLine(@"};");

        }
    }
}
