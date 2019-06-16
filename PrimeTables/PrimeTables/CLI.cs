using System;

namespace PrimeTables
{
    public class CLI
    {
        private static readonly int[] PRIME_NUMBERS;

        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Welcome to prime number tables.");
                Console.WriteLine("Please enter the number of prime multiple you would like to generate (1 or greater) :");
                args = new string[2];
                args[0] = "-n";
                args[1] = Console.ReadLine();
            } 

            switch (args[0])
            {
                case "-n":
                    if (args.Length >= 2)
                    {
                        if (ValidateNumberArgument(args[1], out int nPrime))
                        {
                            var primeNumbers = PrimeNumberGenerator.GeneratePrimeNumbers(nPrime);
                            MultiplicationTableOutput.GenerateMultiplicationTable(primeNumbers);
                        }
                        else
                        {
                            Console.WriteLine("Error: N primes argument provided. Please provide a whole number great than 1");
                            return;
                        }
                    }
                    break;

                case "-help":
                    PrintHelpInstructions();
                    break;

                default:
                    PrintHelpInstructions();
                    break;

            }
        }

        /// <summary>
        /// Method which parses the N argument from the CLI, validates the result
        /// and returns it as an integer using an out variable
        /// </summary>
        /// <param name="Nstr"></param>
        /// <param name="nPrime"></param>
        /// <returns></returns>
        public static bool ValidateNumberArgument(string Nstr, out int nPrime)
        {
            if (int.TryParse(Nstr, out nPrime))
            {
                if (!(nPrime % 1 == 0))
                {
                    Console.Write("Error: please provide a whole number");
                    return false;
                }
                else if (nPrime < 1)
                {
                    Console.WriteLine("Error: please provide a whole number that is 1 or larger");
                    return false;
                }
                return true;
            }
            else
            {
                Console.WriteLine("Error: could not parse number argument");
            }
            return false;
        }

        public static void PrintHelpInstructions()
        {
            Console.WriteLine(" ");
        }
    }
}
