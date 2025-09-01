using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class MultiplicationTable
    {
        public void MultiplicationTableDemo()
        {
            Console.WriteLine("Enter a number to display its multiplication table:");

            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the range up to which you want the multiplication table:");
            int range = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Multiplication Table for {number}:");

            for (int i =1; i <= range; i++)
            {
                Console.WriteLine(i + " x " + number + " = " + (i * number));
            }

        }
    }
}
