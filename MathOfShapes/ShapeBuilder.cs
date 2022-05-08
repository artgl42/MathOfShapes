using MathOfShapes.Shapes;
using System.Collections.Generic;

namespace MathOfShapes
{
    // Precision - some values (max 15) for Math.Round. For exp: Precision.Low means return value from GetArea() will be Math.Round(value, 1)
    public enum Precision { None, Low, Medium, High }
    // ShapeParam - parameters available for setting for shapes
    public enum ShapeParam { SideA, SideB, SideC, Radius }


    public class ShapeBuilder // Using the "Fluent Builder" pattern to creating shape
    {
        internal Precision Precision { get; set; }

        internal Dictionary<ShapeParam, double> ShapeParams = new Dictionary<ShapeParam, double>();

        public ShapeBuilder SetRoundPrecision(Precision precision)
        {
            Precision = precision;
            return this;
        }

        public ShapeBuilder SetSideA(double sideA)
        {
            ShapeParams.Add(ShapeParam.SideA, sideA);
            return this;
        }

        public ShapeBuilder SetSideB(double sideB)
        {
            ShapeParams.Add(ShapeParam.SideB, sideB);
            return this;
        }

        public ShapeBuilder SetSideC(double sideC)
        {
            ShapeParams.Add(ShapeParam.SideC, sideC);
            return this;
        }

        public ShapeBuilder SetRadius(double radius)
        {
            ShapeParams.Add(ShapeParam.Radius, radius);
            return this;
        }

        public Shape Build()
        {
            var _shapeShecker = new ShapeChecker(Precision, ShapeParams);
            if (_shapeShecker.IsTriangle()) return new Triangle(Precision, ShapeParams, null);
            if (_shapeShecker.IsCircle()) return new Circle(Precision, ShapeParams, null);
            return new Unknown(Precision, ShapeParams, null);
        }
    }
}
