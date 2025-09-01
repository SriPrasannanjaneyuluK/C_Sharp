using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Calculator
    {
        public void CalculatorDemo()
        {
            // Demonstrating a simple calculator using switch-case statements

            Console.Write("Enter the first value: ");
            double num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second value: ");
            double num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select the operation");
            Console.WriteLine("1. Addition (+)\n2. Substraction (-) \n3. Multiplication (*) \n4. Division (/) \n5. Modlulus (%)");
            char operation;
            try
            {
                operation = Convert.ToChar(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Input was not in a correct format. Please enter a valid operation.");
                return; // Exit the method if input is invalid  
            }
            

            switch (operation)
            {
                case '+':
                    Console.WriteLine($"Addition of {num1} and {num2} is {num1 + num2}");
                    break;

                case '-':
                    Console.WriteLine($"Subtraction of the {num1} and {num2} is {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"Multiplication of the {num1} and {num2} is {num1 * num2}");
                    break;

                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine(operation + " operation is not possible as divisor cannot be zero");
                    }
                    else 
                    {
                        Console.WriteLine($"Division of the {num1} and {num2} is {num1 / num2}");
                    }
                        break;
                case '%':
                    Console.WriteLine($"Modulus of the {num1} and {num2} is {num1 % num2}");
                    break; 
                    
                default:
                    Console.WriteLine("Invalid operation selected. Please choose a valid operation.");
                    break;

            }

        }
    }
}
