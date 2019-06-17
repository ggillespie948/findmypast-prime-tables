using PrimeTables;
using System;
using Xunit;
using Xunit.Abstractions;

namespace PrimeTablesTests
{
    public class MultiplicationTableOutputTests
    {
        [Theory]
        [InlineData(new int[3] { 2, 3, 5 })]
        [InlineData(new int[5] { 2, 3, 5, 7, 11 })]
        [InlineData(new int[7] { 2, 3, 5, 7, 11, 13, 17 })]
        public void GenerateMultiplicationTable_Returns_ExpectedOutput(int[] nPrimes)
        {
            var foo = MultiplicationTableOutput.GenerateMultiplicationTable(nPrimes);
            Assert.Equal(foo, GetExpectedMultiplicationTable(nPrimes.Length));
        }

        private int[,] GetExpectedMultiplicationTable(int nPrimes)
        {
            switch(nPrimes)
            {
                case 3:
                    return new int[4, 4] { 
                        { 0,  2,  3,  5},
                        { 2,  4,  6,  10}, 
                        { 3,  6,  9,  15}, 
                        { 5,  10, 15, 25}
                    };

                case 5:
                    return new int[6, 6] {
                        { 0,  2,  3,  5,  7,  11},
                        { 2,  4,  6,  10, 14, 22},
                        { 3,  6,  9,  15, 21, 33},
                        { 5,  10, 15, 25, 35, 55},
                        { 7,  14, 21, 35, 49, 77},
                        { 11, 22, 33, 55, 77, 121}
                    };

                case 7:
                    return new int[8, 8] {
                        { 0,  2,  3,  5,  7,  11,  13,  17},
                        { 2,  4,  6,  10, 14, 22,  26,  34},
                        { 3,  6,  9,  15, 21, 33,  39,  51},
                        { 5,  10, 15, 25, 35, 55,  65,  85},
                        { 7,  14, 21, 35, 49, 77,  91,  119},
                        { 11, 22, 33, 55, 77, 121, 143, 187},
                        { 13, 26, 39, 65, 91, 143, 169, 221},
                        { 17, 34, 51, 85, 119, 187, 221, 289}
                    };

            }

            return null;

        }
    }
}
