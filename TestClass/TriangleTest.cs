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
        public void TestIsoscelesTriangleAB()
        {
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

        [Test]
        public void TestScaleneTriangle1()
        {
            // Arrange
            int sideA = 5;
            int sideB = 4;
            int sideC = 8;

            // Act
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("Scalene triangle", result);
        }

        [Test]
        public void TestScaleneTriangle2()
        {
            int sideA = 1;
            int sideB = 1;
            int sideC = 3;

            // Act
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreNotEqual("Scalene triangle", result);
        }

        [Test]
        public void TestScaleneTriangle3()
        {
            int sideA = 5;
            int sideB = 5;
            int sideC = 5;

            // Act
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreNotEqual("Scalene triangle", result);
        }

        [Test]
        public void TestScaleneTriangle4()
        {
            int sideA = 7;
            int sideB = 2;
            int sideC = 6;

            // Act
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("Scalene triangle", result);
        }

        [Test]
        public void TestScaleneTriangle5()
        {
            int sideA = 4;
            int sideB = 6;
            int sideC = 3;

            // Act
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("Scalene triangle", result);
        }


        [Test]
        public void TestTriangleIfHasSidesZeroLength1()
        {
            // Arrange
            int sideA = 0;
            int sideB = 2;
            int sideC = 3;

            // Act
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("Invalid Triangle - a zero has been detected", result);
        }

        [Test]
        public void TestTriangleIfHasSidesZeroLength2()
        {
            // Arrange
            int sideA = 1;
            int sideB = 0;
            int sideC = 3;

            // Act
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("Invalid Triangle - a zero has been detected", result);
        }

        [Test]
        public void TestTriangleIfHasSidesZeroLength3()
        {
            // Arrange
            int sideA = 1;
            int sideB = 2;
            int sideC = 0;

            // Act
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("Invalid Triangle - a zero has been detected", result);
        }

    }
}
