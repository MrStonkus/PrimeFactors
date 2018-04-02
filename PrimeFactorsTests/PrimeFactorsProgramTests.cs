using PrimeFactors;
using System.Collections.Generic;
using Xunit;

namespace PrimeFactorsTests
{
    public class PrimeFactorsProgramTests
    {
        [Fact]
        public void TestGetPrimeFactorsOf40()
        {
            // Arrange
            int number = 40;
            List<int> expectedFactorList = new List<int>() { 2, 2, 2, 5 };

            // Act
            List<int> factorLIst = Program.GetPrimeFactorList(number);

            // Assert
            Assert.Equal(expectedFactorList, factorLIst);
        }

        [Fact]
        public void TestGetPrimeFactorsOf30()
        {
            // Arrange
            int number = 30;
            List<int> expectedFactorList = new List<int>() { 2, 3, 5 };

            // Act
            List<int> factorLIst = Program.GetPrimeFactorList(number);

            // Assert
            Assert.Equal(expectedFactorList, factorLIst);
        }

    }

}
