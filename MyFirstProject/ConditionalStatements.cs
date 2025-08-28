using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class ConditionalStatements
    {
        public void ConditionChecking() 
        {
            int a = 10, b = 20;
            if (a > b)
            {
                Console.WriteLine("A is greater than the B");
            }
            else 
            {
                Console.WriteLine("B is greater than the A");
            }

            Console.Write("Enter your first value1: ");
            int value1  = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your first value2: ");
            int value2 = Convert.ToInt32(Console.ReadLine());

            if (value1 > value2)
            {
                Console.WriteLine("Value 1 is greater than the Value 2");
            }
            else if (value1 < value2)
            {
                Console.WriteLine("value 1 smaller than the value 2");
            }
            else
            { 
                Console.WriteLine("Both values are equal");
            }
        }

    }
}
