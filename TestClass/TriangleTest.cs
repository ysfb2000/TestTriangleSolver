using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;

namespace TestClass
{
    [TestFixture]
    public class TriangleTest
    {
        [Test]
        public void TestEquilateralTriangle()
        {
            // Arrange
            int sideA = 5;
            int sideB = 5;
            int sideC = 5;

            // Act
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("Equilateral triangle", result);
        }

        [Test]
        public void TestIsoscelesTriangleAB() {
            // Arrange
            int sideA = 5;
            int sideB = 5;
            int sideC = 3;

            // Act
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("Isosceles triangle", result);
        }

        [Test]
        public void TestIsoscelesTriangleBC()
        {
            // Arrange
            int sideA = 3;
            int sideB = 5;
            int sideC = 5;

            // Act
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            
            // Assert
            Assert.AreEqual("Isosceles triangle", result);
        }

        [Test]
        public void TestIsoscelesTriangleCA()
        {
            // Arrange
            int sideA = 5;
            int sideB = 3;
            int sideC = 5;

            // Act
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("Isosceles triangle", result);
        }
    }
}
