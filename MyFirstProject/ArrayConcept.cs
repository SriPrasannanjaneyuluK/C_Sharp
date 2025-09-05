using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class ArrayConcept
    {
        public void ArrayConceptDemo()
        {
            //int[] ints = new int[5]; // Declare an array of integers with a size of 5
            //ints[0] = 1;
            //ints[1] = 2;
            //ints[3] = 3;
            //ints[4] = 4;
            ////ints[5] = 5; // This will throw an IndexOutOfRange exception because the index is out of range of the array

            //for (int i = 0; i < ints.Length; i++)
            //{
            //    Console.Write($"{ints[i]}");
            //}
            //Console.WriteLine("\n\nIt is printing the 0 at the index 2 because we haven't assign the value so it print the default value 0");


            // Declare and initialize an array of strings

            string[] strings = new string[] { "Anand", "Venky", "Praveen" };

            foreach (string name in strings)
            {
                Console.WriteLine(name);
            }

            int[] numbers = { 1, 2, 3, 4, 5 }; // Implicitly typed array initialization

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Get the length of the array
            // We can also create and initialize an array without specifying the size this is called as implicit array initialization

            int[] numbersArray = new int[] { 10, 20, 30, 40, 50 };  // Declare and initialize an array of integers without specifying the size
            Console.WriteLine($"Length of numbersArray: {numbersArray.Length}");

            foreach (int num in numbersArray)
            {
                Console.WriteLine(num);
            }

            // Multidimensional array

            int[,] multiArray = new int[2, 3]
            {
                {1,2, 3},
                {5,6,7}
            };  // 2 rows and 3 columns

            for (int i = 0; i < multiArray.GetLength(0); i++) // getLength(0) gives number of rows
            {
                for (int j = 0; j < multiArray.GetLength(1); j++) // getLength(1) gives number of columns
                {
                    Console.Write($"{multiArray[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();    
            // Jagged array

            int[][] jaggedArray = new int[3][]; // Declare a jagged array with 3 rows
            jaggedArray[0] = new int[] { 1, 2 }; // First row has 2 columns
            jaggedArray[1] = new int[] { 3, 4, 5 }; // Second row has 3 columns
            jaggedArray[2] = new int[] { 6, 7, 8, 9 }; // Third row has 4 columns

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"{jaggedArray[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
