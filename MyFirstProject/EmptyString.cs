using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class EmptyString
    {
        public void EmptyStringDemo()
        {
            // Using the "" to represent an empty string
            string emptyString = "";

            Console.WriteLine(emptyString == ""); //True 


            // Using the String.Empty to represent an empty string
            Console.WriteLine("Using the String.Empty to find whether it is empty or not");
            string anotherEmptyString = Console.ReadLine();

            if (anotherEmptyString == String.Empty)
            {
                Console.WriteLine("The string is empty");
            }
            else
            {
                Console.WriteLine("The string is not empty");
            }

            // Using the String.IsNullOrEmpty() method to check for empty or null strings
            string notNullString = "Anand";
            string nullString = null; //This is null string which is different from empty string it has no value at all
            Console.Write(string.IsNullOrEmpty(nullString)); //True
            Console.WriteLine(" <- This is null string representing null value");
            Console.Write(string.IsNullOrEmpty(notNullString)); //False
            Console.WriteLine($" <- This is not null string representing a value -> {notNullString}");

            // Using the string.Length property to check for empty strings
            string lengthCheckString = "";
            if (lengthCheckString.Length == 0)
            {
                Console.WriteLine("This is an empty string because the length of the string is 0");
            }

            // Using the string.equals() method to compare strings
            string string1 = "";
            string string2 = String.Empty;
            string string3 = String.Empty;

            if (string1.Equals(string2))
            {
                Console.WriteLine("string1 and string2 are same.");
            }
            if (string2.Equals(string3)) 
            {
                Console.WriteLine("string2 and string3 are same");
            }

        }
    }
}
