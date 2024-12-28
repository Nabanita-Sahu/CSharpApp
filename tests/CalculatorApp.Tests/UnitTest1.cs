using Xunit;
using CalculatorApp;

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            // Arrange
            var calculator = new Calculator();
            int a = 5;
            int b = 7;

            // Act
            var result = calculator.Add(a, b);

            // Assert
            Assert.Equal(12, result);
        }

        [Fact]
        public void Add_ReturnsCorrectSumForNegativeNumbers()
        {
            // Arrange
            var calculator = new Calculator();
            int a = -3;
            int b = -5;

            // Act
            var result = calculator.Add(a, b);

            // Assert
            Assert.Equal(-8, result);
        }
    }
}