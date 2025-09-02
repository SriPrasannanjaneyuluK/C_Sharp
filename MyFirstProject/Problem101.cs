using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Problem101
    {
        public void Problem101Demo() 
        {
            // Write a program to find the factorial of a number.
            Console.Write("Enter the number to get its factorial: ");

            int number = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for (int i = number; i > 0; i--)
            {
                factorial *= i;
            }

            Console.WriteLine($"The factorial of {number} is: {factorial}");

        }
    }
}
