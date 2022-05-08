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
                var _shapeChecker = new ShapeChecker(Precision, ShapeParams);
                return _shapeChecker.IsSquareness();
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
