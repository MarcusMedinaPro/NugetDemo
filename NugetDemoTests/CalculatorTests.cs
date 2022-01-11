using Microsoft.VisualStudio.TestTools.UnitTesting;
using NugetDemo;

namespace NugetDemo.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest ()
        {
            // Arrange
            var sut = new Calculator();
            var expected = 5;

            // Act
            var actual = sut.Add(3, 2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(2, true)]
        [DataRow(3, false)]
        public void IsEvenTest (int data, bool expected)
        {
            // Arrange
            var sut = new Calculator();

            //Act
            var actual = sut.IsEven(data);

            // Assert
            Assert.AreEqual(expected,actual);
        }
    }
}