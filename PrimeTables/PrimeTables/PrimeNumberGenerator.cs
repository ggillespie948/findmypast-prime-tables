using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeTables
{
    public static class PrimeNumberGenerator
    {
        /// <summary>
        /// Method which takes an integer nPrimes and returns a list containing that given
        /// number of primes using Sieve of Eratosthenes implementation.
        /// </summary>
        /// <param name="nPrimes"></param>
        /// <returns></returns>
        public static List<int> GeneratePrimeNumbers(int nPrimes)
        {
            //to do: calculate the what the highest nPrime value is and set that as maxCount
            var maxCount = 12; //hardcode the max prime number +1 for now

            bool[] sieveFlags = new bool[maxCount];

            //init sieve flags from 2 to maxCount
            for (int i = 2; i < sieveFlags.Length; i++)
            {
                sieveFlags[i] = true;
            }
            sieveFlags[0] = false;
            sieveFlags[1] = false;

            //starting at the first prime number
            int prime = 2;
            
            while (prime <= 25)
            {
                //eliminate remaining multiples of prime
                for (int i = prime * prime; i < sieveFlags.Length; i += prime)
                {
                    sieveFlags[i] = false;
                }

                //find the next value which hasn't been eliminated
                int next = prime + 1;
                while (next < sieveFlags.Length && !sieveFlags[next])
                {
                    next++;
                }
                prime = next;
            }

            return GenerateListOfPrimes(sieveFlags, maxCount);
        }


        /// <summary>
        /// Method takes the array of sieve flags and iterates through them adding each 
        /// index flagged as a prime number to a list.
        /// </summary>
        /// <param name="sieveFlags"></param>
        /// <param name="maxCount"></param>
        /// <returns></returns>
        private static List<int> GenerateListOfPrimes(bool[] sieveFlags, int maxCount)
        {
            List<int> primeNumbers = new List<int>();
            for (int i = 0; i < sieveFlags.Length; i++)
            {
                if (sieveFlags[i])
                {
                    primeNumbers.Add(i);
                }
            }
            return primeNumbers;
        }

    }
}
