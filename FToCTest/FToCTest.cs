using System;

namespace FToCTest
{
    public class FToCTest
    {
        [Theory]
        [InlineData(212, 'F')]
        [InlineData(428, 'F')]
        public void FahrenheitToCelsius_WithConvertToC_ShouldReturnC(double number, char simwol)
        {
            double result;
            result = Converter.FahrenheitToCelsius(number, simwol);
            Assert.Equal(number, result);
        }

    }
}