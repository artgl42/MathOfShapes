using System;

namespace MathOfShapes.Shapes
{
    public class Triangle : IShape
    {
        public byte Precision { get; }
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        public bool IsSquareness => CheckSquareness();

        public Triangle(double sideA, double sideB, double sideC, Precision precision)
        {
            Precision = (byte)precision;
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        bool CheckSquareness()
        {
            //Pythagorean theorem c^2 = a^2 + b^2 
            return SideA == Math.Round(Math.Sqrt(Math.Pow(SideB, 2) + Math.Pow(SideC, 2)), Precision)
                || SideB == Math.Round(Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideC, 2)), Precision)
                || SideC == Math.Round(Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2)), Precision);
        }

        double IShape.GetArea()
        {
            //Heron's formula A = Sqrt(s * (s - a)(s - b)(s - c)), s - semiperimeter
            var _semiperimeter = (SideA + SideB + SideC) / 2;
            return Math.Round(Math.Sqrt(_semiperimeter * (_semiperimeter - SideA) * (_semiperimeter - SideB) * (_semiperimeter - SideC)), Precision);
        }
    }
}
