using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace MyFirstProject 
{
    internal class TernaryOperator
    {
        public void TernaryOperatorExample()
        {
            //Demonistrating the ternary operator

            int a = 10, b = 25;

            String result = a > b ? "a is greater than the b" :b > a? "b is greater than the a" :"a and b are equal";

            Console.WriteLine(result);

            //Ternary operator using the user given input value

            Console.Write("Enter the first value: ");
            int value1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second value: ");
            int value2 = Convert.ToInt32(Console.ReadLine());

            // Ternary operator with multiple conditions (Nested Ternary operator)
            String Solution = value1 > value2 ? $"{value1} is greater than the {value2}" : value2 > value1 ? $"{value1} is smaller than the {value2}": $"{value1} and {value2} are equal";
            Console.WriteLine(Solution);
        }
    }
}
