using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task2;

namespace UnitTestLab1_Task2
{
    [TestClass]
    public class RectangleTest
    {
        [DataTestMethod]
        [DataRow(2, 5, 10)]
        [DataRow(4, 1, 4)]
        [DataRow(7, 8, 56)]
        public void CalculateAreaTest(double x, double y, double expected)
        {
            Rectangle rec = new Rectangle(x, y);
            double actual = rec.CalculateArea();
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(4, 6, 20)]
        [DataRow(7, 2, 18)]
        [DataRow(3, 3, 12)]
        public void CalculatePerimeterTest(double x, double y, double expected)
        {
            Rectangle rec = new Rectangle(x, y);
            double actual = rec.CalculatePerimeter();
            Assert.AreEqual(expected, actual);
        }
    }
}
