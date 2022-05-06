using System;

namespace MathOfShapes.Shapes
{
    internal class Triangle : Shape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        public bool IsSquareness { get; }

        internal Triangle(double sideA, double sideB, double sideC, Precision precision) : base (precision)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            IsSquareness = CheckSquareness();
            Area = GetArea();
        }

        protected override double GetArea()
        {
            //Heron's formula A = Sqrt(s * (s - a)(s - b)(s - c)), s - semiperimeter
            var _semiperimeter = (SideA + SideB + SideC) / 2;
            return Math.Round(Math.Sqrt(_semiperimeter * (_semiperimeter - SideA) * (_semiperimeter - SideB) * (_semiperimeter - SideC)), (byte)Precision);
        }

        protected bool CheckSquareness()
        {
            //Pythagorean theorem c^2 = a^2 + b^2 
            return SideA == Math.Round(Math.Sqrt(Math.Pow(SideB, 2) + Math.Pow(SideC, 2)), (byte)Precision)
                || SideB == Math.Round(Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideC, 2)), (byte)Precision)
                || SideC == Math.Round(Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2)), (byte)Precision);
        }
    }
}
