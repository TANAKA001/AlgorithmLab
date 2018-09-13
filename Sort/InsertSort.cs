using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    /*
     * Insertion sort is a simple sorting algorithm that works
     * the way we sort playing cards in our hands.
     * The array is searched sequentially and unsorted items are moved
     * and inserted into the sorted sub-list (in the same array). 
     * This algorithm is not suitable for large data sets as its average and 
     * worst case complexity are of Ο(n2), where n is the number of items.
     */

    /*Step 1 − If it is the first element, it is already sorted. return 1;
    Step 2 − Pick next element
    Step 3 − Compare with all elements in the sorted sub-list
    Step 4 − Shift all the elements in the sorted sub-list that is greater than the 
            value to be sorted
    Step 5 − Insert the value
    Step 6 − Repeat until list is sorted
     */
    public class InsertSort
    {
        public int[] insertSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                Console.WriteLine("Next loop");

                var element = arr[i];
                var aux = i - 1;

                Console.WriteLine("key: "+element.ToString());
                
                while (aux >= 0 && arr[aux] > element)
                {
                    Console.WriteLine("index -1: "+aux);

                    arr[aux + 1] = arr[aux];
                    aux -= 1;
                }
                arr[aux + 1] = element;
            }

            return arr;
        }

        public int[] insertSort_rec(int[] arr, int n) {
            
            if (n <= 1)
                return arr;
            
            insertSort_rec(arr, n - 1);
            Console.WriteLine("Next call");

            int element = arr[n - 1];
            int aux = n - 2;
            Console.WriteLine("key: " + element.ToString());

            while (aux >= 0 && arr[aux] > element)
            {
                Console.WriteLine("index -1: " + aux);
                arr[aux + 1] = arr[aux];
                aux--;
            }
            arr[aux + 1] = element;

            return arr;
        }
    }
}
