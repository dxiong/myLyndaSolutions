using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Testing123 Git.
namespace LyndadotcomCsharpChallenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            Console.WriteLine("*** Welcome to the Simple Calculator! ***");

            // Ask and validate the first number.
            Console.Write("Please enter the first number: ");
            num1 = GetNum();

            // Ask and validate the second number.
            Console.Write("Please enter the second number: ");
            num2 = GetNum();

            // Ask for, validate, and perform the requested Math Operator.
            while (true)
            {
                Console.Write("OPTIONS: " +
                              "\n (A)ddition " +
                              "\n (S)ubtraction " +
                              "\n (M)ultiplication " +
                              "\n (D)ivision " +
                              "\n (R)e-enter Numbers " +
                              "\n (Q)uit " +
                              "\nPlease enter the desired math operator: ");
                string input = Console.ReadLine();

                // Switch, for user input.
                switch (input.ToLower())
                {
                    case "a":
                        Console.WriteLine(" The sum of " +
                                          num1 +
                                          " and " +
                                          num2 +
                                          " is: " +
                                          Addition(num1, num2));
                        continue;
                    case "s":
                        Console.WriteLine(" The difference of " +
                                          num1 +
                                          " and " +
                                          num2 +
                                          " is: " +
                                          Subtraction(num1, num2));
                        continue;
                    case "m":
                        Console.WriteLine(" The product of " +
                                          num1 +
                                          " and " +
                                          num2 +
                                          " is: " +
                                          Multiplication(num1, num2));
                        continue;
                    case "d":
                        Console.WriteLine(" The quotient of " +
                                          num1 +
                                          " and " +
                                          num2 +
                                          " is: " +
                                          Division(num1, num2));
                        continue;
                    case "r":
                        Console.Write("Please enter the first number: ");
                        num1 = GetNum();
                        Console.Write("Please enter the second number: ");
                        num2 = GetNum();
                        continue;
                    case "q":
                        Console.WriteLine("Thank You for using the Simple Calculator! Press any key to continue!");
                        break;
                    default:
                        Console.WriteLine(" An invalid value was entered.");
                        continue;
                }

                break;
            }

            Console.ReadKey();
        }

        static double GetNum()
        {
            double num;

            // While loop, to receive and validate User input.
            while (true)
            {
                string input = Console.ReadLine();
                if (double.TryParse(input, out num))
                {
                    return num;
                }
                else
                {
                    Console.Write(" Invalid value! Enter in a valid value: ");
                }
            }
        }

        static double Addition(double value1, double value2)
        {
            return (value1 + value2);
        }

        static double Subtraction(double value1, double value2)
        {
            return (value1 - value2);
        }

        static double Multiplication(double value1, double value2)
        {
            return (value1 * value2);
        }

        static double Division(double value1, double value2)
        {
            // Validate Divide by Zero.
            if (value2 == 0)
            {
                Console.WriteLine(" Unable to divide by Zero.");
                return 0;
            }
            else
            {
                return (value1 / value2);
            }
        }
    }
}