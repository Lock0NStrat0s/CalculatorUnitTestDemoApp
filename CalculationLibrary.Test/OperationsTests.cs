using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationLibrary.Test
{
    public class OperationsTests
    {
        [Theory]
        [InlineData(2,3,5)]
        [InlineData(12,33,45)]
        [InlineData(1,0,1)]
        [InlineData(-4,4,0)]
        public void OperationShouldReturnAddition(double uno, double dos, double expected)
        {
            // Arrange
            Operations operations = new Operations();

            // Act
            double actual = operations.Add(uno, dos);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, -1)]
        [InlineData(33, 33, 0)]
        [InlineData(1, 0, 1)]
        [InlineData(56, 4, 52)]
        public void OperationShouldReturnSubtraction(double uno, double dos, double expected)
        {
            // Arrange
            Operations operations = new Operations();

            // Act
            double actual = operations.Subtract(uno, dos);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(12, 3, 36)]
        [InlineData(1, 0, 0)]
        [InlineData(-4, 4, -16)]
        public void OperationShouldReturnMultiplication(double uno, double dos, double expected)
        {
            // Arrange
            Operations operations = new Operations();

            // Act
            double actual = operations.Multiply(uno, dos);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6, 3, 2)]
        [InlineData(12, 3, 4)]
        [InlineData(0, 1, 0)]
        [InlineData(-4, 4, -1)]
        [InlineData(-4, 0, 0)]
        public void OperationShouldReturnDivision(double uno, double dos, double expected)
        {
            // Arrange
            Operations operations = new Operations();

            // Act
            double actual = operations.Divide(uno, dos);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
