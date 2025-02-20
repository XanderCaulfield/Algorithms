using System;
using System.Security.Cryptography;

namespace BinarySearch{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = [1,2,3,4,5,31,46];
            System.Console.WriteLine(BinarySearch(inputArray, 31));
        }

        // method declaration
        static int BinarySearch(int[] arr, int target) {

            // defining our indices
            int low = 0;
            int high = arr.Length - 1;


            while (low <= high)
            {
                int mid = (low + high) / 2;
                int guess = arr[mid];
                if (guess == target) { return mid; }
                else if (guess > target) { high = mid - 1; }
                else { low = mid + 1; }
            }

            // if not found, return -1.
            return -1;
        }

    }
}