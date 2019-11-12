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

        [Fact]
        public void Return0GivenValuesof0()
        {
            //Act
            var result = _mathHelper.Max(0, 0);

            //Assert
            Assert.Equal(0, result);
        }
    }
}
