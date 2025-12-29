using System;
using System.Net;
using System.Threading;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        public int Subtract(int minuend, int subtrhend)
        {
            //throw  new NotImplementedException();
            return minuend - subtrhend;
        }

        public int Multiply(int multiplicand, int multiplier)
        {
            //throw new NotImplementedException();
            return multiplicand * multiplier;
        }

        public int Divide(int dividend, int divisor)
        {
            //throw new NotImplementedException();
            return dividend / divisor;
        }
        
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(1, 2, 3, 6)] //Add test data <-------
        [InlineData( 0, -1, -1, -2)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            // Arrange
            // create a Calculator object
            var c = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = c.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData( 5, 5, 0)]//Add test data <-------
        [InlineData( 5, 8, -3)]//Add test data <-------
        [InlineData( -1, -1, 0)]//Add test data <-------
        [InlineData( 0, -3, 3)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var c = new Calculator();

            //Act
            var actual = c.Subtract( minuend, subtrhend );

            //Assert
            Assert.Equal( expected, actual );
        }

        [Theory]
        [InlineData( 2, 2, 4)]//Add test data <-------
        [InlineData( 5, 3, 15)]//Add test data <-------
        [InlineData( 0, 1, 0)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var c = new Calculator();

            //Act
            var actual = c.Multiply(num1, num2);

            //Assert
            Assert.Equal( expected, actual );

        }

        [Theory]
        [InlineData( 10, 5, 2)]//Add test data <-------
        [InlineData( 14, 2, 7)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var c = new Calculator();

            //Act
            var actual = c.Divide(num1, num2);

            //Assert
            Assert.Equal( expected, actual );
            
        }

    }
}
