using CalculatorLibrary;

namespace CIDemoTest
{
    public class CalculatorTests
    {
        private readonly ICalculator _calculator;

        // Constructor to initialize the Calculator object
        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        /// <summary>
        /// Tests the Add method of the Calculator class.
        /// </summary>
        [Fact]
        public void Add_ShouldReturnCorrectSum_WhenGivenTwoNumbers()
        {
            // Arrange
            int num1 = 5;
            int num2 = 3;

            // Act
            int result = _calculator.Add(num1, num2);

            // Assert
            Assert.Equal(8, result); // The expected sum of 5 + 3 is 8
        }

        /// <summary>
        /// Tests the Subtract method of the Calculator class.
        /// </summary>
        [Fact]
        public void Subtract_ShouldReturnCorrectDifference_WhenGivenTwoNumbers()
        {
            // Arrange
            int num1 = 5;
            int num2 = 3;

            // Act
            int result = _calculator.Subtract(num1, num2);

            // Assert
            Assert.Equal(2, result); // The expected difference of 5 - 3 is 2
        }

        /// <summary>
        /// Tests the Multiply method of the Calculator class.
        /// </summary>
        [Fact]
        public void Multiply_ShouldReturnCorrectProduct_WhenGivenTwoNumbers()
        {
            // Arrange
            int num1 = 5;
            int num2 = 3;

            // Act
            int result = _calculator.Multiply(num1, num2);

            // Assert
            Assert.Equal(15, result); // The expected product of 5 * 3 is 15
        }

        /// <summary>
        /// Tests the Divide method of the Calculator class.
        /// </summary>
        [Fact]
        public void Divide_ShouldReturnCorrectQuotient_WhenGivenTwoNumbers()
        {
            // Arrange
            int num1 = 6;
            int num2 = 3;

            // Act
            double result = _calculator.Divide(num1, num2);

            // Assert
            Assert.Equal(2.0, result, 1); // The expected quotient of 6 / 3 is 2.0
        }

        /// <summary>
        /// Tests the Divide method when dividing by zero, expecting an exception.
        /// </summary>
        [Fact]
        public void Divide_ShouldThrowDivideByZeroException_WhenDenominatorIsZero()
        {
            // Arrange
            int num1 = 5;
            int num2 = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(num1, num2));
        }

        /// <summary>
        /// Tests the Power method of the Calculator class with positive inputs.
        /// </summary>
        [Fact]
        public void Power_ShouldReturnCorrectResult_WhenGivenBaseAndExponent()
        {
            // Arrange
            double baseValue = 2;
            double exponent = 3;

            // Act
            double result = _calculator.Power(baseValue, exponent);

            // Assert
            Assert.Equal(8.0, result, 5); // 2^3 = 8, with precision tolerance
        }

        /// <summary>
        /// Tests the SquareRoot method of the Calculator class with negative input.
        /// </summary>
        [Fact]
        public void SquareRoot_NegativeInput_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => _calculator.SquareRoot(-4));
        }

        /// <summary>
        /// Tests the Sin method of the Calculator class.
        /// </summary>
        [Fact]
        public void Sin_ShouldReturnCorrectResult_WhenGivenRadians()
        {
            double radians = Math.PI / 2; // 90 degrees
            double result = _calculator.Sin(radians);
            Assert.Equal(1.0, result, 5); // Close to 1.0
        }

        /// <summary>
        /// Tests the Cos method of the Calculator class.
        /// </summary>
        [Fact]
        public void Cos_ShouldReturnCorrectResult_WhenGivenRadians()
        {
            double radians = Math.PI; // 180 degrees
            double result = _calculator.Cos(radians);
            Assert.Equal(-1.0, result, 5);
        }

        /// <summary>
        /// Tests the Tan method of the Calculator class.
        /// </summary>
        [Fact]
        public void Tan_ShouldReturnCorrectResult_WhenGivenRadians()
        {
            double radians = Math.PI / 4; // 45 degrees
            double result = _calculator.Tan(radians);
            Assert.Equal(1.0, result, 5);
        }

        /// <summary>
        /// Tests the Log method of the Calculator class.
        /// </summary>
        [Fact]
        public void Log_ShouldReturnCorrectResult_WhenGivenPositiveValue()
        {
            double value = Math.E;
            double result = _calculator.Log(value);
            Assert.Equal(1.0, result, 5); // ln(e) = 1
        }

        [Fact]
        public void Log_ShouldThrowException_WhenGivenZeroOrNegative()
        {
            Assert.Throws<ArgumentException>(() => _calculator.Log(0));
            Assert.Throws<ArgumentException>(() => _calculator.Log(-5));
        }

        /// <summary>
        /// Tests the Factorial method of the Calculator class.
        /// </summary>
        [Fact]
        public void Factorial_ShouldReturnCorrectResult_WhenGivenPositiveInteger()
        {
            int value = 5;
            double result = _calculator.Factorial(value);
            Assert.Equal(120, result);
        }

        [Fact]
        public void Factorial_ShouldReturn1_WhenGivenZeroOrOne()
        {
            Assert.Equal(1, _calculator.Factorial(0));
            Assert.Equal(1, _calculator.Factorial(1));
        }

        [Fact]
        public void Factorial_ShouldThrowException_WhenGivenNegative()
        {
            Assert.Throws<ArgumentException>(() => _calculator.Factorial(-1));
        }

        /// <summary>
        /// Tests radians and degree conversion.
        /// </summary>
        [Fact]
        public void DegreesToRadians_ShouldConvertCorrectly()
        {
            double degrees = 180;
            double result = _calculator.DegreesToRadians(degrees);
            Assert.Equal(Math.PI, result, 5);
        }

        [Fact]
        public void RadiansToDegrees_ShouldConvertCorrectly()
        {
            double radians = Math.PI;
            double result = _calculator.RadiansToDegrees(radians);
            Assert.Equal(180, result, 5);
        }


    }

}