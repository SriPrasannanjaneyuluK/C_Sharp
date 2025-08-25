using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Integers
    { 
        public void integerDemo()
        { 
            int age; //declaration
            age = 25; //initialization
            Console.WriteLine("My age is: " + age);
            int a = 10;
            int b = 30;
            int sum;
            sum = a + b;

            Console.WriteLine("Sum of two values: " + sum);
            Console.WriteLine("Enter the first value: ");
            
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second value: ");
            int value2 = Convert.ToInt32(Console.ReadLine());
            int sum1 = value1 + value2;
            Console.WriteLine("Sum of two values: " + sum1);
        }
    }
}
