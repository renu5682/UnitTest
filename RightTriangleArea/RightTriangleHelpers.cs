using System;

namespace RightTriangleArea
{
    public class RightTriangleHelpers
    {
        public RightTriangleHelpers(double tolerance = 1e-9)
        {
            Tolerance = tolerance;
        }

        public double Tolerance { get; }

        private bool IsTriangleRight(double a, double b, double c)
        {
            return (Math.Abs(a - Math.Sqrt(b * b + c * c)) < Tolerance) ||
                   (Math.Abs(b - Math.Sqrt(a * a + c * c)) < Tolerance) ||
                   (Math.Abs(c - Math.Sqrt(b * b + a * a)) < Tolerance);
        }

        private void ValidatePositive(double a)
        {
            if (a <= 0.0)
                throw new ArgumentOutOfRangeException(nameof(a), a,
                    "Side of the triangle must be greater then zero.");
        }

        public double CalculateArea(double a, double b, double c)
        {
            ValidatePositive(a);
            ValidatePositive(b);
            ValidatePositive(c);

            if (!IsTriangleRight(a, b, c))
                throw new NotSupportedException("Can't calculate area of not a right triangle.");

            if (a > b && a > c)
                return (b * c) / 2.0;
            if (b > a && b > c)
                return (a * c) / 2.0;
            return (a * b) / 2.0;
        }
    }
}