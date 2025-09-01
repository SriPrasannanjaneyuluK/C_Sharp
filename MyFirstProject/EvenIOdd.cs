using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class EvenIOdd
    {
        public void EvenOddExample()
        {
            //// Demontrating the even and odd number using if - else 
            //Console.Write("Enter the value: ");

            //int value1 = Convert.ToInt32(Console.ReadLine());

            //if (value1 % 2 == 0)
            //{
            //    Console.WriteLine($"{value1} is an even number");
            //}
            //else
            //{
            //    Console.WriteLine($"{value1} is an odd number");
            //}

            // Demontrating the even and odd number using ternary operator

            Console.WriteLine("Using Ternary Operator");
            Console.Write("Enter the value: ");
            int value;
            try
            {
                value = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Input was not in a correct format. Please enter a valid integer.");
                return; // Exit the method if input is invalid
            }


            String result = value % 2 == 0? $"{value} is an even number" : $"{value} is an odd number";
            Console.WriteLine(result);
             
            Console.ReadLine();


        }
    }
}
