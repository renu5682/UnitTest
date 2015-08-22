using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RightTriangleArea
{
    [TestClass]
    public class RightTriangleAreaTests
    {
        private RightTriangleHelpers _rightTriangleHelpers;

        [TestInitialize]
        public void TestInitialize()
        {
            _rightTriangleHelpers = new RightTriangleHelpers();
        }

        [TestMethod]
        public void CanCalculateRightTriangleArea()
        {
            const double a = 4.0;
            const double b = 3.0;
            const double c = 5.0;

            Assert.AreEqual(6.0, _rightTriangleHelpers.CalculateArea(a, b, c),
                _rightTriangleHelpers.Tolerance);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void CantCalculateNotRightTriangleArea()
        {
            const double a = 2.0;
            const double b = 3.0;
            const double c = 4.0;

            _rightTriangleHelpers.CalculateArea(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CantCalculateInvalidSideLengthTriangleArea()
        {
            const double a = 2.0;
            const double b = -3.0;
            const double c = 4.0;

            _rightTriangleHelpers.CalculateArea(a, b, c);
        }
    }
}