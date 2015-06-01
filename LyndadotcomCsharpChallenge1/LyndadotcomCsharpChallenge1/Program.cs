using System;

namespace LyndadotcomCsharpChallenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Welcome to the Simple Calculator! ***");

            // Initialize and validate the first number.
            double inputNum1;
            Console.Write("Please enter the first number: ");
            inputNum1 = GetNumber();

            // Initialize and validate the second number.
            double inputNum2;
            Console.Write("Please enter the second number: ");
            inputNum2 = GetNumber();

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
                string decision= Console.ReadLine();

                // Switch, for user input.
                switch (decision.ToLower())
                {
                    case "a":
                        Console.WriteLine(" The sum of " +
                                          inputNum1 +
                                          " and " +
                                          inputNum2 +
                                          " is: " +
                                          Addition(inputNum1, inputNum2));
                        continue;
                    case "s":
                        Console.WriteLine(" The difference of " +
                                          inputNum1 +
                                          " and " +
                                          inputNum2 +
                                          " is: " +
                                          Subtraction(inputNum1, inputNum2));
                        continue;
                    case "m":
                        Console.WriteLine(" The product of " +
                                          inputNum1 +
                                          " and " +
                                          inputNum2 +
                                          " is: " +
                                          Multiplication(inputNum1, inputNum2));
                        continue;
                    case "d":
                        Console.WriteLine(" The quotient of " +
                                          inputNum1 +
                                          " and " +
                                          inputNum2 +
                                          " is: " +
                                          Division(inputNum1, inputNum2));
                        continue;
                    // Re-initialize the numbers.
                    case "r":
                        Console.Write("Please enter the first number: ");
                        inputNum1 = GetNumber();
                        Console.Write("Please enter the second number: ");
                        inputNum2 = GetNumber();
                        continue;
                    case "q":
                        Console.WriteLine("Thank You for using the Simple Calculator! Press any key to continue!");
                        // Exit app.
                        break;
                    default:
                        Console.WriteLine(" An invalid value was entered.");
                        continue;
                }

                break;
            }

            Console.ReadKey();
        }

        private static double GetNumber()
        {
            double num;

            while (true)
            {
                string input = Console.ReadLine();
                // Validate and convert User input.
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

        private static double Addition(double value1, double value2)
        {
            return (value1 + value2);
        }

        private static double Subtraction(double value1, double value2)
        {
            return (value1 - value2);
        }

        private static double Multiplication(double value1, double value2)
        {
            return (value1 * value2);
        }

        private static double Division(double value1, double value2)
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