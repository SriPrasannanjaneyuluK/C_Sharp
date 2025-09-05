
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class ArrayFunctions
    {
        public void ArrayFunctionsDemo()
        {
            // Array sorting function 

            int[] arr = { 5, 6, 8, 1, 2 };

            Array.Sort(arr); // Sort the array in ascending order

            Console.WriteLine("Sorted array in ascending order: ");
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();


            /*
             * Now we will create the sorting function in our own way without using the Array.Sort() 
             */

            int[] arr1 = { 55,0,4,10,21,56};

            for (int i = 0; i < arr1.Length-1; i++) // Outer loop for each element
            {
                for (int j = i + 1; j < arr1.Length; j++) // Inner loop for comparing with other elements
                {
                    if (arr1[i] > arr1[j]) // If the current element is greater than the next element
                    {
                        // Swap the elements
                        int temp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted array in ascending order: ");
            foreach (int i in arr1)
            {
                Console.Write($"{i} ");
            }


            // Array reverse function

            Array.Reverse(arr); // Reverse the array
            Console.WriteLine("\nSorted array in descending order: ");
            foreach (int i in arr) 
            {
                Console.Write($"{i} ");            
            }

            // Reverse the array without using Array.Reverse() function
            Console.WriteLine();
            int lastValue = arr1.Length - 1; // Get the last index of the array

            for (int i = 0; i < lastValue; i++, lastValue--)
            {
                int temp = arr1[i];
                arr1[i] = arr1[lastValue];
                arr1[lastValue] = temp;
            }
            Console.WriteLine();
            Console.WriteLine("Sorted array in descending order: ");

            foreach (int i in arr1)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
