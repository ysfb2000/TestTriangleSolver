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
    }
}
