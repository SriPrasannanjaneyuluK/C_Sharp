using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class PasswordCheck
    {
        public void PasswordCheckDemo()
        {
            // Giving the user 3 attempts to set the password
            string password, confirmPassword;

            Console.WriteLine("Set your password (Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, one digit, and one special character): ");

            int attempts = 3;
            while (attempts > 0)
            {
                attempts--;

                // A simple password validation program

                Console.Write("Enter your password: ");

                password = Console.ReadLine();

                // Check if the password is not null or empty
                if (!String.IsNullOrEmpty(password))
                {
                    // Check if the password contains at least one uppercase letter, one lowercase letter, one digit, and one special character
                    if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit) && password.Any(ch => !char.IsLetterOrDigit(ch) && password.Length > 8))
                    {
                        int attemptsForConfirmation = 3;
                        while (attemptsForConfirmation > 0)
                        {
                            attemptsForConfirmation--;
                            // If the password meets the criteria, ask for confirmation
                            Console.WriteLine("Re-Enter confirmation password: ");

                            // Read the confirmation password from the console
                            confirmPassword = Console.ReadLine();

                            if (!String.IsNullOrEmpty(confirmPassword))
                            {
                                if (password.Equals(confirmPassword))
                                {
                                    Console.WriteLine("Password set correctly");
                                    break; // Exit the loop if password is set correctly
                                }
                                else
                                {
                                    Console.WriteLine("Password and confirmation password do not match");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Confirmation password cannot be empty");
                            }
                            Console.WriteLine($"\n\nYou have {attemptsForConfirmation} attempts left.\n");

                        }
                        if (attemptsForConfirmation == 0)
                        {
                            Console.WriteLine("You have exhausted all attempts to confirm the password.");
                        }
                        break; // Exit the loop if password is set correctly
                    }
                    else
                    {
                        Console.WriteLine("Password does not meet the criteria. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Password cannot be empty");
                }
                Console.WriteLine($"\n\nYou have {attempts} attempts left.\n");
            }
            if (attempts == 0)
            {
                Console.WriteLine("You have exhausted all attempts to set the password.");
            }
        }
    }
}
