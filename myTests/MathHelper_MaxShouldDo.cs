using System;
using Xunit;
using myLib;

namespace myTests
{
    public class MathHelper_MaxShouldDo
    {
        //Arrange
        private readonly MathHelper _mathHelper;

        public MathHelper_MaxShouldDo()
        {
            _mathHelper = new MathHelper();
        }

        [Theory]
        /// <summary>
        /// Tests if two numbers enered are same then the   
        /// number returned is same as the numbers entered.
        /// </summary>
        [InlineData(89,89,89)]
        [InlineData(-999, -999, -999)]
        [InlineData(270, 270, 270)]
        [InlineData(1002, 1002, 1002)]
        public void ReturnValueWhenOperandsValuesAreSame(int value1, int value2, int expectedResult)
        {
            //Act
            var result = _mathHelper.Max(value1, value2);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        /// <summary>
        /// Tests if the max value of the two given number   
        /// is returned.
        /// </summary>
        [InlineData(89, 88, 89)]
        [InlineData(-999, 999, 999)]
        [InlineData(299, 270, 299)]
        [InlineData(3, 1002, 1002)]
        [InlineData(-3453, -1002, -1002)]
        public void ReturnMaxValueOfTheTwoGivenNumbers(int value1, int value2, int expectedResult)
        {
            //Act
            var result = _mathHelper.Max(value1, value2);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        /// <summary>
        /// Test the fact that Max is commutative - returns the same 
        /// result independent of the order of the operands.
        /// </summary>
        public void ReturnSameResultIndependentOfOrder()
        {
            //Arrange
            var one = 19;
            var two = 89;

            //Act
            var result1 = _mathHelper.Max(one, two);
            var result2 = _mathHelper.Max(two,one);

            //Assert
            Assert.Equal(result1, result2);

        }
    }
}
