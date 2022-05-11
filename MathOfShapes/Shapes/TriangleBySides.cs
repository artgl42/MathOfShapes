using System;

namespace MathOfShapes.Shapes
{
    public class TriangleBySides : Shape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        public bool IsSquareness => CheckIsSquareness();

        internal TriangleBySides(
            RoundAccuracy roundAccuracy, 
            double sideA, 
            double sideB, 
            double sideC) : base (roundAccuracy)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        protected override double GetArea()
        {
            // Heron's formula A = Sqrt(s * (s - a)(s - b)(s - c)), s - semiperimeter
            var _s = (SideA + SideB + SideC) / 2;
            return Math.Round(Math.Sqrt(_s * (_s - SideA) * (_s - SideB) * (_s - SideC)), (byte)RoundAccuracy);
        }

        bool CheckIsSquareness()
        {
            if (SideA > 0 && SideB > 0 && SideC > 0)
            {
                // Pythagorean theorem c^2 = a^2 + b^2
                return SideA == Math.Round(Math.Sqrt(Math.Pow(SideB, 2) + Math.Pow(SideC, 2)), (byte)RoundAccuracy)
                || SideB == Math.Round(Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideC, 2)), (byte)RoundAccuracy)
                || SideC == Math.Round(Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2)), (byte)RoundAccuracy);
            }
            return false;
        }
    }
}
