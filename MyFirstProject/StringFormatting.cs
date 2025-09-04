using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class StringFormatting
    {
        public void StringFormattingDemo()
        {
            // Using the concatenation operator (+) to combine strings

            String firstName = "Anand";
            String lastName = "Kalvakolanu";

            String fullName = firstName + " " + lastName;
            Console.WriteLine("Using the concatenation operator (+)");
            Console.WriteLine("First name: " + firstName + "\nLast name: " + lastName + "\nFull name: " + fullName);

            Console.WriteLine("Enter you're first name: ");
            String userFirstName = Console.ReadLine();

            Console.WriteLine("Enter you're last name: ");
            String userLastName = Console.ReadLine();

            // Using the String format function (Old function)
            Console.WriteLine("\nUsing the string format function");

            String userFullName = String.Format("\nHere is you're full name using the string format function: {0} {1}",userFirstName, userLastName);

            Console.WriteLine(userFullName);

            // Using the string interpolation (New function, available from C# 6 and later versions)
            Console.WriteLine("\nUsing Interpolation");

            Console.WriteLine($"\nHere is the user full name using the string interpolation: {userFirstName} {userLastName}");


        }
    }
}
