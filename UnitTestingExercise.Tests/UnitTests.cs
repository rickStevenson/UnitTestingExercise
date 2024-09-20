using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(1, 4, 6, 11)]
        [InlineData(4, 8, 9, 21)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:
            // Step 3: Navigate to the UnitTests.cs file and complete the AddTest unit test method 

            //Arrange
            // create a Calculator object
            var addCalculator = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = addCalculator.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,2,3)]
        [InlineData(10,1,9)]
        [InlineData(11,2,9)]
        [InlineData(-12,3,-15)]
        [InlineData(-1,-1,0)]
        [InlineData(0,-1,1)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var subtractCalculator = new Calculator();
            //Act
            var actual = subtractCalculator.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2,3,6)]//Add test data <-------
        [InlineData(6,6,36)]
        [InlineData(12,12,144)]
        [InlineData(-12,-12,144)]
        [InlineData(-5,3,-15)]
        [InlineData(0,0,0)]
        [InlineData(5,1,5)]
        [InlineData(3,0,0)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var multiplyCalc = new Calculator();
            //Act
            var actual = multiplyCalc.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6,2,3)]
        [InlineData(0,2,0)]
        [InlineData(-10, 2, -5)]
        [InlineData(-10, -5, 2)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var divideCalc = new Calculator();
            //Act
            var actual = divideCalc.Divide(num1, num2);
            //Assert
            Assert.Equal(actual, expected);
        }

    }
}
