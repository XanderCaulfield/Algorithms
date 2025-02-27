using System;

namespace SelectionSort{

    class Program {

        static void Main(string[] args){

            int[] arr = {1,17,2,16,25,678,86,127,3,4,18};
            SelectionSort(arr);

            // Print sorted array
            Console.WriteLine("The Sorted Array is:");
            foreach (int num in arr) {
                Console.Write(num + ", ");
            }
        }

        static int[] SelectionSort(int[] input) {
            for (int i = 0; i < input.Length - 1; i++)
            {
                // Track the index of the min element (assuming starting index to begin with)
                int min = i;

                // Find the index of the min element in the rest of the array
                for(int j = i+1; j < input.Length; j++){

                    // If smaller element found, it's index is tracked
                    if(input[j] < input[min]){
                        min = j;
                    }
                }

                // Swap positions with smaller number.
                if (min != i){
                    int temp = input[i];
                    input[i] = input[min];
                    input[min] = temp;
                }

            }
            return input;
        }
    }
}