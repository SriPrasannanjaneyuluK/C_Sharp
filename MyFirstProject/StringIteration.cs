using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class StringIteration
    {
        public void StringIterationDemo()
        {
            string name = "Anand Kalvakolanu";

            // Using a for loop to iterate through each character in the string 
            Console.WriteLine("This is the reversed string");
            for (int i = (name.Length - 1); i >= 0; i--)
            {
                Console.Write(name[i]);
            }

            // Using a foreach loop to iterate through each character in the string
            Console.WriteLine("\n\nThis is the reversed string using the foreach loop");

            foreach (char letter in name)
            {
                Console.Write(letter);
            }

            // Converting the string to a character

            Console.WriteLine("\n\nThis is the string converted to a character array");
            char[] charArray = name.ToCharArray();

            foreach (char letter in charArray)
            {
                Console.Write(letter);
            }
        }
    }
}
