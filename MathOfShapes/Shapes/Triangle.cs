using System;
using System.Collections.Generic;

namespace MathOfShapes.Shapes
{
    internal class Triangle : Shape
    {
        double SideA { get; }
        double SideB { get; }
        double SideC { get; }

        public bool IsSquareness
        {
            get
            {
                // Pythagorean theorem c^2 = a^2 + b^2
                return SideA == Math.Round(Math.Sqrt(Math.Pow(SideB, 2) + Math.Pow(SideC, 2)), Precision)
                || SideB == Math.Round(Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideC, 2)), Precision)
                || SideC == Math.Round(Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2)), Precision);
            }
        }

        internal Triangle(
            Dictionary<ShapeParam, double> inShapeParams,
            Func<Dictionary<ShapeParam, double>, double> methodForArea) : base(inShapeParams, methodForArea) 
        {            
            SideA = InShapeParams[ShapeParam.SideA];
            SideB = InShapeParams[ShapeParam.SideB];
            SideC = InShapeParams[ShapeParam.SideC];
        }

        protected override double GetAreaDefault()
        {
            // Heron's formula A = Sqrt(s * (s - a)(s - b)(s - c)), s - semiperimeter
            var _s = (SideA + SideB + SideC) / 2;
            return Math.Round(Math.Sqrt(_s * (_s - SideA) * (_s - SideB) * (_s - SideC)), Precision);
        }
    }
}
