// int[] array = { 4, -12, 3, 31, 0, 7, 4, 14, 90, 5 };
// int[] sortedArray
// array = QuickSort(array, 0, array.Length - 1);
// for (int i = 0; i < array.Length; i++)
// {
//     System.Console.WriteLine(array[i]);
// }
// int FindPivot(int[] array, int minIndex, int maxIndex)
// {
//     int pivot = -1;
//     int temp = 0;
//     for (int i = minIndex; i < maxIndex; i++)
//     {
//         if (array[i] < array[maxIndex])
//         {
//             pivot++;
//             temp = array[pivot];
//             array[pivot] = array[i];
//             array[i] = temp;
//         }
//     }
//     pivot++;
//     temp = array[pivot];
//     array[pivot] = array[maxIndex];
//     array[maxIndex] = temp;

//     return pivot;
// }

// int[] QuickSort(int[] array, int minIndex, int maxIndex)
// {
//     if(minIndex >= maxIndex)
//     {
//         return array;
//     }   
//     int pivot = FindPivot(array, minIndex, maxIndex);
//     QuickSort(array, minIndex, pivot -1);
//     QuickSort(array, pivot + 1, maxIndex);
//     return array;
// }


//System.Console.WriteLine($"[{string.Join(", ", array)}]");

using System;

namespace QuickSortAlgorithm
{
    class Program
    {
        static void Main()
        {
            int[] inputArray = { 9, 12, 9, 2, 17, 1, 6 };

            int[] sortedArray = QuickSort(inputArray, 0, inputArray.Length - 1);

            Console.WriteLine($"Sorted array: {string.Join(", ", sortedArray)}");

            Console.ReadLine();
        }

        private static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);

            QuickSort(array, minIndex, pivotIndex - 1);

            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        private static int GetPivotIndex(int[] array, int minIndex, int maxIndex)
        {
            int pivot = minIndex - 1;

            for (int i = minIndex; i <= maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);

            return pivot;
        }

        private static void Swap(ref int leftItem, ref int rightItem)
        {
            int temp = leftItem;

            leftItem = rightItem;

            rightItem = temp;
        }
    }
}