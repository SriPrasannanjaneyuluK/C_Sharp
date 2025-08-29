using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstProject;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello anand"); 
            Console.WriteLine();
            Integers integers = new Integers();

            // Call the integerDemo method to demonstrate integer operations
            Console.WriteLine("Demonstrating Integer Operations:");
            integers.integerDemo();

            // Create an instance of ConditionalStatements to demonstrate conditional statements
            Console.WriteLine("\nDemonstrating Conditional Statements:");
            ConditionalStatements conditionalStatements = new ConditionalStatements();

            // The constructor of ConditionalStatements contains the demonstration code

            conditionalStatements.ConditionChecking();

            // Create an instance of SwitchStatement to demonstrate switch-case statements
            Console.WriteLine("\nDemonstrating Switch Statement:");
            
            SwitchStatement switchStatement = new SwitchStatement();
            switchStatement.SwitchStatementcheck();

            // Create an instance of TernaryOperator to demonstrate the ternary operator

            Console.WriteLine("\nDemonstrating Ternary Operator:");
            TernaryOperator ternaryOperator = new TernaryOperator();
            ternaryOperator.TernaryOperatorExample();


            Console.ReadLine();
        }
    }
}
