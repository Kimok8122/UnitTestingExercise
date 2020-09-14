using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]
        [InlineData (5,5,5,15)]
        [InlineData(10,20,30,60)]

        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var addTest = new UnitTestMethods();
            //Act
            var addActual = addTest.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, addActual);
        }

        [Theory]
        [InlineData(4,2,2)]
        [InlineData(7,4,3)]
        [InlineData(30,20,10)]

        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var subTest = new UnitTestMethods();
            //Act
            var subActual = subTest.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, subActual);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData (2,2,4)]
        [InlineData (10,20,200)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var multTest = new UnitTestMethods();
            //Act
            var multActual = multTest.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, multActual);
        }

        [Theory]
        [InlineData(2,4,0.5)]
        [InlineData(6,2,3)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var divTest = new UnitTestMethods();
            //Act
            var divActual = divTest.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, divActual);
        }

//        [Fact]
//        public void YourMethodName()
//        {
//            //Arrange
//            var expected = "h";
//            //Act

//            //Assert
//            Assert.Equal(expected, actual);
//        }

//        [Fact]
//        public void YourMethodName2()
//        {
//            //Arrange

//            //Act

//            //Assert
//        }
//    }
//}
