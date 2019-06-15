using PrimeTables;
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

        [Fact]
        public void GeneratePrimeNumbers_Expected_Output()
        {
            var expectedPrimes = new List<int>() { 2,3,5,7,11 };
            var primes = PrimeNumberGenerator.GeneratePrimeNumbers(5);
            Assert.Equal(expectedPrimes, primes);
        }
       
    }
}
