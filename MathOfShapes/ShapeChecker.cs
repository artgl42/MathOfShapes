using System;
using System.Collections.Generic;

namespace MathOfShapes
{
    internal class ShapeChecker
    {
        public Precision Precision { get; }
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        public double Radius { get; }
        internal ShapeChecker(Precision precision, Dictionary<ShapeParam, double> shapeParams) 
        {
            Precision = precision;
            SideA = shapeParams.ContainsKey(ShapeParam.SideA) ? shapeParams[ShapeParam.SideA] : 0;
            SideB = shapeParams.ContainsKey(ShapeParam.SideB) ? shapeParams[ShapeParam.SideB] : 0;
            SideC = shapeParams.ContainsKey(ShapeParam.SideC) ? shapeParams[ShapeParam.SideC] : 0;
            Radius = shapeParams.ContainsKey(ShapeParam.Radius) ? shapeParams[ShapeParam.Radius] : 0;
        }
        internal bool IsTriangle()
        {
            // If the sum of the two sides is greater than the third, then the triangle cannot exist
            return Radius == 0 && SideA + SideB > SideC && SideA + SideC > SideB && SideB + SideC > SideA;
        }

        internal bool IsCircle()
        {
            return SideA == 0 && SideB == 0 && SideC == 0 && Radius > 0;
        }

        internal bool IsSquareness()
        {
            // Pythagorean theorem c^2 = a^2 + b^2 
            return SideA == Math.Round(Math.Sqrt(Math.Pow(SideB, 2) + Math.Pow(SideC, 2)), (byte)Precision)
                || SideB == Math.Round(Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideC, 2)), (byte)Precision)
                || SideC == Math.Round(Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2)), (byte)Precision);
        }
    }
}
