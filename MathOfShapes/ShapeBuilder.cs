using MathOfShapes.Shapes;
using System;
using System.Collections.Generic;

namespace MathOfShapes
{
    // Precision - some values (max 15) for Math.Round. For exp: Precision.Low means return value Area will be Math.Round(value, 1)
    public enum Precision { None, Low, Medium, High }

    public class ShapeBuilder // Using the "Fluent Builder" pattern to creating shape
    {
        internal Dictionary<ShapeParam, double> InShapeParams = new Dictionary<ShapeParam, double>();
        internal Func<Dictionary<ShapeParam, double>, double> AreaFunc { get; set; } 

        public ShapeBuilder SetAreaFunc(Func<Dictionary<ShapeParam, double>, double> areaFunc)
        {
            AreaFunc = areaFunc;
            return this;
        }

        public ShapeBuilder SetPrecision(Precision precision)
        {
            InShapeParams.Add(ShapeParam.Precision, (byte)precision);
            return this;
        }

        public ShapeBuilder SetSideA(double sideA)
        {
            InShapeParams.Add(ShapeParam.SideA, sideA);
            return this;
        }

        public ShapeBuilder SetSideB(double sideB)
        {
            InShapeParams.Add(ShapeParam.SideB, sideB);
            return this;
        }

        public ShapeBuilder SetSideC(double sideC)
        {
            InShapeParams.Add(ShapeParam.SideC, sideC);
            return this;
        }

        public ShapeBuilder SetRadius(double radius)
        {
            InShapeParams.Add(ShapeParam.Radius, radius);
            return this;
        }

        public ShapeBuilder SetHeight(double height)
        {
            InShapeParams.Add(ShapeParam.Height, height);
            return this;
        }

        public Shape Build()
        {
            if (!InShapeParams.ContainsKey(ShapeParam.Precision)) InShapeParams.Add(ShapeParam.Precision, 1);
            var _sideA = InShapeParams.ContainsKey(ShapeParam.SideA) ? InShapeParams[ShapeParam.SideA] : 0;
            var _sideB = InShapeParams.ContainsKey(ShapeParam.SideB) ? InShapeParams[ShapeParam.SideB] : 0;
            var _sideC = InShapeParams.ContainsKey(ShapeParam.SideC) ? InShapeParams[ShapeParam.SideC] : 0;
            var _radius = InShapeParams.ContainsKey(ShapeParam.Radius) ? InShapeParams[ShapeParam.Radius] : 0;
            var _height = InShapeParams.ContainsKey(ShapeParam.Height) ? InShapeParams[ShapeParam.Height] : 0;

            // If the sum of the two sides is greater than the third, then the triangle cannot exist
            if (_radius == 0 && _sideA + _sideB > _sideC && _sideA + _sideC > _sideB && _sideB + _sideC > _sideA)
            {
                return new Triangle(InShapeParams, AreaFunc);
            }

            if (_radius > 0 && _sideA == 0 && _sideB == 0 && _sideC == 0)
            {
                return new Circle(InShapeParams, AreaFunc);
            }

            return new Unknown(InShapeParams, AreaFunc);
        }
    }
}
