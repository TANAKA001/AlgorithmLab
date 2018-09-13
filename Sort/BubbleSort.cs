using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    /*
     * Bubble Sort is the simplest sorting algorithm that 
     * works by repeatedly swapping the adjacent elements if they are in wrong order.
     */
    public class BubbleSort
    {
        public int[] bubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
            return arr;
        }
        public int[] bubbleSort_rec(int[] arr, int n)
        {
            if (n == 1)
                return arr;

            for (int i = 0; i < n - 1; i++)
                if (arr[i] > arr[i + 1])
                {
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }

            bubbleSort_rec(arr, n - 1);

            return arr;
        }
    }
}
