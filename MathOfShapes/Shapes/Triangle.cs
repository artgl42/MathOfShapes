using MathOfShapes.MethodsForArea;
using System;

namespace MathOfShapes.Shapes
{
    public class Triangle : Shape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        public bool IsSquareness => CheckIsSquareness();

        internal Triangle(
            IAreaComputable areaMethod, 
            Precision precision, 
            double sideA, 
            double sideB, 
            double sideC) : base (areaMethod)
        {
            Precision = precision;
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        private bool CheckIsSquareness()
        {
            // Pythagorean theorem c^2 = a^2 + b^2
            return SideA == Math.Round(Math.Sqrt(Math.Pow(SideB, 2) + Math.Pow(SideC, 2)), (byte)Precision)
            || SideB == Math.Round(Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideC, 2)), (byte)Precision)
            || SideC == Math.Round(Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2)), (byte)Precision);
        }
    }
}
