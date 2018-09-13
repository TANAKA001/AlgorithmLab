using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class SelectionSort
    {
        /*
         * The smallest element is selected from the unsorted array and
         * swapped with the leftmost element, and that element becomes a part of
         * the sorted array. This process continues moving unsorted array boundary by 
         * one element to the right.
         */

        /*
         * Step 1 − Set MIN to location 0
            Step 2 − Search the minimum element in the list
            Step 3 − Swap with value at location MIN
            Step 4 − Increment MIN to point to next element
            Step 5 − Repeat until list is sorted         
         */
         public int[] selectionSort(int[] arr)
        {
            int n = arr.Length;

            // One by one move boundary of unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("Next loop");
                // Find the minimum element in unsorted array
                int min_idx = i;
                Console.WriteLine("Index min");
                for (int j = i + 1; j < n; j++)
                {
                    Console.WriteLine("compare {0} and {1}", arr[j], arr[min_idx]);
                    if (arr[j] < arr[min_idx])
                        min_idx = j;
                }
                // Swap the found minimum element with the first
                // element
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }

            return arr;
        }

    }
}
