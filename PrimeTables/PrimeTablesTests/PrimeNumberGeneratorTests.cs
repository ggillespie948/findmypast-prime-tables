﻿using PrimeTables;
using System;
using System.Collections.Generic;
using Xunit;

namespace PrimeTablesTests
{
    public class PrimeNumberGeneratorTests
    {

        [Fact]
        public void GeneratePrimeNumbers_Not_Empty_Or_Null()
        {
            var primes = PrimeNumberGenerator.GeneratePrimeNumbers(5);
            Assert.NotEmpty(primes);
            Assert.NotNull(primes);
        }

        [Theory]
        [InlineData(5, new int[5] { 2, 3, 5, 7, 11 })]
        [InlineData(15, new int[15] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47 })]
        [InlineData(50, new int[50] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211, 223, 227, 229 })]
        public void GeneratePrimeNumbers_Expected_Output(int nPrimes, int[] expectedPrimes)
        {
            var primes = PrimeNumberGenerator.GeneratePrimeNumbers(nPrimes);
            Assert.Equal(expectedPrimes, primes);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(1000)]
        [InlineData(10000)]
        [InlineData(50000)]
        [InlineData(1000000)]
        [InlineData(10000000)]
        [InlineData(50000000)]
        [InlineData(100000000)]
        public void GeneratePrimeNumbers_Expected_Length_Stress_Test(int expectedPrimeCount)
        {
            var generatedResults = PrimeNumberGenerator.GeneratePrimeNumbers(expectedPrimeCount);
            Assert.Equal(expectedPrimeCount, generatedResults.Length);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(1000)]
        [InlineData(10000)]
        [InlineData(50000)]
        public void GeneratePrimeNumbers_Always_Returns_Primes(int nPrimes)
        {
            var results = PrimeNumberGenerator.GeneratePrimeNumbers(nPrimes);
            foreach(int i in results)
            {
                Assert.True(isPrime(i));
            }
        }

        private bool isPrime(int num)
        {
            for (int i = 2; i < num; i++)
                if (num % i == 0)
                    return false;
            return num == 1 ? false : true;
        }

    }
}
