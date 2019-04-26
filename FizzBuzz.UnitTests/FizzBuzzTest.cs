using System;
//using Library = FizzBuzz.Library.FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.UnitTests
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestClass]
        public class Determine : FizzBuzzTest
        {
            [TestMethod]
            public void DivisibleOnlyBy3_Fizz()
            {
                // Arrange
                var i = 3;

                // Act
                var actual = Library.FizzBuzz.Determine(i);

                // Assert
                Assert.AreEqual(Library.Answer.Fizz, actual);
            }

            [TestMethod]
            public void DivisibleOnlyBy5_Buzz()
            {
                // Arrange
                var i = 5;

                // Act
                var actual = Library.FizzBuzz.Determine(i);

                // Assert
                Assert.AreEqual(Library.Answer.Buzz, actual);
            }

            [TestMethod]
            public void DivisibleBy3And5_FizzBuzz()
            {
                // Arrange
                var i = 30;

                // Act
                var actual = Library.FizzBuzz.Determine(i);

                // Assert
                Assert.AreEqual(Library.Answer.FizzBuzz, actual);
            }

            [TestMethod]
            public void NotDivisibleBy3Or5_Skipped()
            {
                // Arrange
                var i = 4;

                // Act
                var actual = Library.FizzBuzz.Determine(i);

                // Assert
                Assert.AreEqual(Library.Answer.None, actual);
            }

            [ExpectedException(typeof(ArgumentException))]
            [TestMethod]
            public void LessThan1_Exception()
            {
                // Arrange
                var i = 0;

                // Act
                var actual = Library.FizzBuzz.Determine(i);

                // Assert
            }

            [ExpectedException(typeof(ArgumentException))]
            [TestMethod]
            public void GreaterThan100_Exception()
            {
                // Arrange
                var i = 101;

                // Act
                var actual = Library.FizzBuzz.Determine(i);

                // Assert
            }
        }
    }
}
