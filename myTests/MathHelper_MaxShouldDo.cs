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
    }
}
