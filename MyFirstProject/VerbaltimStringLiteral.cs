using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class VerbatimStringLiteral
    {
        public void VerbatimStringLiteralDemo()
        {
            // Using verbatim string literal to define a file path
           string filePath = @"C:\Users\anand\Documents\MyFirstProject\file.txt";
            Console.WriteLine("File Path: " + filePath);
            // Using verbatim string literal to define a multi-line string
            string multiLineString = @"This is a multi-line string.
So you dont need to use the escape sequences.
It preserves the formatting as is."; // Don't leave the tab spces at the beginning of the line as it will be considered part of the string

            Console.WriteLine(multiLineString);
        }
    }
}
