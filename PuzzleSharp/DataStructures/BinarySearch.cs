using System;
namespace PuzzleSharp.DataStructures
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 10, 40 };
            int arraylength = arr.Length;
            int searchNo = 10;

            int result = binarySearch(arr, 0, arraylength - 1, searchNo);

            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at index "
                                                 + result);
        }
        static int binarySearch(int[] arr, int startIndex,
                                  int lastIndex, int searchNo)
        {
            if (lastIndex >= startIndex)
            {
                int mid = startIndex + (lastIndex - startIndex) / 2;

                // If the element is present at the 
                // middle itself
                if (arr[mid] == searchNo)
                    return mid;

                // If element is smaller than mid, then 
                // it can only be present in left subarray
                if (arr[mid] > searchNo)
                    return binarySearch(arr, startIndex, mid - 1, searchNo);

                // Else the element can only be present
                // in right subarray
                return binarySearch(arr, mid + 1, lastIndex, searchNo);
            }

            // We reach here when element is not present
            // in array
            return -1;
        }
    }


}
