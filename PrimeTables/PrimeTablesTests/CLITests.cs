using PrimeTables;
using System;
using Xunit;

namespace PrimeTablesTests
{
    public class CLITests
    {
        [Theory]
        [InlineData("@")]
        [InlineData("foo")]
        [InlineData("a")]
        [InlineData("/a123")]
        public void Non_Numeric_Argument_Returns_False(string argument)
        {
            var foo = CLI.ValidateNumberArgument(argument, out int nPrime);
            Assert.False(foo);
            Assert.Equal(0, nPrime);
        }

        [Fact]
        public void Assign_Numeric_Argument_Returns_True()
        {
            var foo = CLI.ValidateNumberArgument("5", out int nPrime);
            Assert.True(foo);
            Assert.Equal(5, nPrime);
        }

        [Fact]
        public void Assign_Negative_Numeric_Argument_Returns_False()
        {
            var foo = CLI.ValidateNumberArgument("-1", out int nPrime);
            Assert.False(foo);
            Assert.Equal(nPrime, -1);
        }

        [Fact]
        public void Assign_Edge_Case_Numeric_Argument_Returns_True()
        {
            var foo = CLI.ValidateNumberArgument("2", out int nPrime);
            Assert.True(foo);
            Assert.Equal(2, nPrime);
        }

        [Theory]
        [InlineData("1.23")]
        [InlineData("5.5")]
        [InlineData("1.5111")]
        public void Assign_Non_Whole_Argument_Returns_False(string argument)
        {
            var foo = CLI.ValidateNumberArgument(argument, out int nPrime);
            Assert.False(foo);
            Assert.Equal(0, nPrime);
        }

    }
}
