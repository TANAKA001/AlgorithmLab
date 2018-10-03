using Global;
using Global.Generator;
using System;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/*-----------------------*/");
            
            Console.WriteLine("Chose one:");
            Console.WriteLine("1  - bubble sort");
            Console.WriteLine("2  - insert sort");
            Console.WriteLine("3  - select sort");
            Console.WriteLine("4  - merge sort");
            Console.WriteLine("5  -  sort");
            var opt = Console.ReadLine();

            switch (opt)
            {
                case "1":
                    BubbleSort _bs = new BubbleSort();

                    int[] arr1 = ArrayGenerator.array1D();
                    int[] arr2 = ArrayGenerator.array1D();

                    //bs.bubbleSort_rec(arrrec, arrrec.Length)
                    Console.WriteLine(@"BUBBLE SORT");
                    Console.WriteLine(@"Sorted array by for loop");
                    PrintArray.printArray(arr1);
                    PrintArray.printArray(_bs.bubbleSort(arr1));
                    Console.WriteLine(@"/*-----------------------*/");
                    Console.WriteLine(@"Sorted array by recursive method");
                    PrintArray.printArray(arr2);
                    PrintArray.printArray(_bs.bubbleSort_rec(arr2, arr2.Length));
                    Console.WriteLine(@"/*-----------------------*/");
                    break;

                case "2":
                    InsertSort _is = new InsertSort();

                    Console.WriteLine(@"INSERT SORT");
                    int[] arr3 = ArrayGenerator.array1D();
                    int[] arr4 = ArrayGenerator.array1D();

                    Console.WriteLine(@"Sorted array by for\while loop");
                    PrintArray.printArray(arr3);
                    PrintArray.printArray(_is.insertSort(arr3));
                    Console.WriteLine(@"/*-----------------------*/");
                    Console.WriteLine(@"Sorted array by recursive method");
                    PrintArray.printArray(arr4);
                    PrintArray.printArray(_is.insertSort_rec(arr4, arr4.Length));
                    Console.WriteLine(@"/*-----------------------*/");
                    break;

                case "3":
                    SelectionSort _ss = new SelectionSort();
                    Console.WriteLine(@"SELECTION SORT");
                    int[] arr5 = ArrayGenerator.array1D();

                    Console.WriteLine(@"Sorted array by for loop");
                    PrintArray.printArray(arr5);
                    PrintArray.printArray(_ss.selectionSort(arr5));
                    Console.WriteLine(@"/*-----------------------*/");
                    break;

                case "4":
                    MergeSort _ms = new MergeSort();
                    Console.WriteLine(@"SELECTION SORT");
                    int[] arr6 = ArrayGenerator.array1D();

                    Console.WriteLine(@"Sorted array by for loop");
                    PrintArray.printArray(arr6);
                    PrintArray.printArray(_ms.MergeSort_Recursive(arr6, 0, arr6.Length-1));
                    Console.WriteLine(@"/*-----------------------*/");
                    break;

            }
            
            Console.ReadKey();

        }

    }
}
