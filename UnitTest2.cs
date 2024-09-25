using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32;
using System;
using Task3;

namespace UnitTestLab1_Task3
{
    [TestClass]
    public class FigureTest
    {
        [DataTestMethod]
        [DataRow(2, 1, 3, 5, 17)]
        [DataRow(3, 4, 2, 1, 10)]
        [DataRow(7, 1, 8, 3, 5)]
        public void LengthSideTest(int a, int b, int c, int d, int exp)
        {
            Point p1 = new Point(a, b);
            Point p2 = new Point(c, d);
            double expected = Math.Sqrt(exp);
            double actual = Figure.LengthSide(p1, p2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PerimeterCalculatorTest()
        {
            Point p1 = new Point(2, 1);
            Point p2 = new Point(3, 5);
            Point p3 = new Point(5, 4);
            Point p4 = new Point(4, 2);
            double expected = Math.Sqrt(17) + Math.Sqrt(5)*3;
            Figure f = new Figure(p1, p2, p3, p4);
            double actual = f.PerimeterCalculator(p1, p2, p3, p4);
            Assert.AreEqual(expected, actual);
        }
    }
}
