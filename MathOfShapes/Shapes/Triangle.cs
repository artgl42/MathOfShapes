using System;
using System.Collections.Generic;

namespace MathOfShapes.Shapes
{
    internal class Triangle : Shape
    {
        public bool IsSquareness
        {
            get
            {
                var _sideA = ShapeParams[ShapeParam.SideA];
                var _sideB = ShapeParams[ShapeParam.SideB];
                var _sideC = ShapeParams[ShapeParam.SideC];

                // Pythagorean theorem c^2 = a^2 + b^2
                return _sideA == Math.Round(Math.Sqrt(Math.Pow(_sideB, 2) + Math.Pow(_sideC, 2)), (byte)Precision)
                || _sideB == Math.Round(Math.Sqrt(Math.Pow(_sideA, 2) + Math.Pow(_sideC, 2)), (byte)Precision)
                || _sideC == Math.Round(Math.Sqrt(Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2)), (byte)Precision);
            }
        }

        internal Triangle(
            Precision precision,
            Dictionary<ShapeParam, double> shapeParams,
            Func<Dictionary<ShapeParam, double>, double> methodForArea) : base(precision, shapeParams, methodForArea) { }

        protected override double GetAreaDefault()
        {
            // Heron's formula A = Sqrt(s * (s - a)(s - b)(s - c)), s - semiperimeter
            var _sideA = ShapeParams[ShapeParam.SideA];
            var _sideB = ShapeParams[ShapeParam.SideB];
            var _sideC = ShapeParams[ShapeParam.SideC];
            var _s = (_sideA + _sideB + _sideC) / 2;
            return Math.Round(Math.Sqrt(_s * (_s - _sideA) * (_s - _sideB) * (_s - _sideC)), (byte)Precision);
        }
    }
}
