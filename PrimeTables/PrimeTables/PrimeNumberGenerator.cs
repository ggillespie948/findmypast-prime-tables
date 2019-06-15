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
        public static int[] GeneratePrimeNumbers(int nPrimes)
        {
            if (nPrimes == 1) return new int[1] { 2 }; //nth prime estimation only works when asking for 2 or more primes

            // Make an estimation of the Nth prime number
            // https://stackoverflow.com/a/51851085/9355141
            // this answer helped me with the calculation
            var maxCount = 1 + nPrimes * (Math.Log(nPrimes) + Math.Log(Math.Log(nPrimes)));

            bool[] sieveFlags = new bool[Convert.ToInt32(maxCount) + 1];
            sieveFlags = InitSieveFlags(sieveFlags);

            //starting at the first prime number
            int prime = 2;
            
            while (prime <= Math.Sqrt(maxCount))
            {
                //eliminate remaining multiples of prime
                Eliminate(sieveFlags, prime);

                //find the next value which hasn't been eliminated
                prime = GetNextPrime(sieveFlags, prime);
            }

            return GenerateListOfPrimes(sieveFlags, nPrimes);
        }


        /// <summary>
        /// Iterate through the list of sieve flags and 
        /// </summary>
        /// <param name="sieveFlags"></param>
        /// <param name="prime"></param>
        /// <returns></returns>
        private static int GetNextPrime(bool[] sieveFlags, int prime)
        {
            int next = prime + 1;
            while (next < sieveFlags.Length && !sieveFlags[next])
            {
                next++;
            }
            return next;
        }


        /// <summary>
        /// Eliminates remaining multiples of prime, starting from (prime*prime), because anything
        /// prior to this would have already been eliminated in a previous iteration
        /// </summary>
        /// <param name="primeFlags"></param>
        /// <param name="prime"></param>
        private static void Eliminate(bool[] primeFlags, int prime)
        {
            for (int i = prime * prime; i < primeFlags.Length; i += prime)
            {
                primeFlags[i] = false;
            }
        }


        /// <summary>
        /// Initalise the sieve flags to all be true, setting 0 + 1 to be false due to 2 being 
        /// the first prime number
        /// </summary>
        /// <param name="sieveFlags"></param>
        /// <returns></returns>
        private static bool[] InitSieveFlags(bool[] sieveFlags)
        {
            //init sieve flags from 2 to maxCount
            for (int i = 2; i < sieveFlags.Length; i++)
            {
                sieveFlags[i] = true;
            }
            sieveFlags[0] = false;
            sieveFlags[1] = false;
            return sieveFlags;
        }


        /// <summary>
        /// Method takes the array of sieve flags and iterates through them adding each 
        /// index flagged as a prime number to a list.
        /// </summary>
        /// <param name="sieveFlags"></param>
        /// <param name="maxCount"></param>
        /// <returns></returns>
        private static int[] GenerateListOfPrimes(bool[] sieveFlags, int maxCount)
        {
            //List<int> primeNumbers = new List<int>();
            int[] primeNumbers = new int[maxCount];

            int primeCount = 0;
            for (int i = 0; i < sieveFlags.Length; i++)
            {
                if (sieveFlags[i])
                {
                    primeNumbers[primeCount] = i;
                    primeCount++;
                    if (primeCount == maxCount) return primeNumbers;
                }
            }
            return primeNumbers;
        }

    }
}
