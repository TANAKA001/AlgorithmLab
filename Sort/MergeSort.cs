using Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class MergeSort
    {
        /*Merge sort is a sorting technique based on divide and conquer technique.
         * With worst-case time complexity being Ο(n log n), it is one of the most respected algorithms.
         * Merge sort first divides the array into equal halves and then combines them in a sorted manner.
         */

        /*Step 1 − if it is only one element in the list it is already sorted, return.
        Step 2 − divide the list recursively into two halves until it can no more be divided.
        Step 3 − merge the smaller lists into new list in sorted order.
         */

        private static int[] DoMerge(int[] arr, int left, int mid, int right)
        {
            PrintArray.printArray(arr);
            Console.WriteLine("left: {0} - mid: {1} - rigth: {2}", left, mid, right);
            int[] temp = new int[25];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (arr[left] <= arr[mid])
                    temp[tmp_pos++] = arr[left++];
                else
                    temp[tmp_pos++] = arr[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = arr[left++];

            while (mid <= right)
                temp[tmp_pos++] = arr[mid++];

            for (i = 0; i < num_elements; i++)
            {
                arr[right] = temp[right];
                right--;
            }
            return arr;
        }

        public int[] MergeSort_Recursive(int[] arr, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;

                MergeSort_Recursive(arr, left, mid);
                Console.WriteLine("Right: " + right.ToString());
                Console.WriteLine("Left: " + left.ToString());
                PrintArray.printArray(arr);
                Console.WriteLine("Next Call");

                MergeSort_Recursive(arr, (mid + 1), right);
                Console.WriteLine("Right: " + right.ToString());
                Console.WriteLine("Left: " + left.ToString());
                PrintArray.printArray(arr);
                Console.WriteLine("Next Call");

                return DoMerge(arr, left, (mid + 1), right);
            }
            else
            {
                return arr;
            }
        }
    }
}
