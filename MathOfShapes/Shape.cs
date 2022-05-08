using System;
using System.Collections.Generic;

namespace MathOfShapes
{
    public abstract class Shape
    {
        public Precision Precision { get; } // Precision - value for Math.Round (max 15)
        public Dictionary<ShapeParam, double> ShapeParams { get; }
        public Func<Dictionary<ShapeParam, double>, double> MethodForArea { get; }
        public double Area => GetArea();
        public Shape(
            Precision precision,
            Dictionary<ShapeParam, double> shapeParams,
            Func<Dictionary<ShapeParam, double>, double> methodForArea)
        {
            Precision = precision;
            ShapeParams = shapeParams;
            MethodForArea = methodForArea;
        }
        public static ShapeBuilder Builder() => new ShapeBuilder();
        protected virtual double GetArea() => MethodForArea?.Invoke(ShapeParams) ?? GetAreaDefault();
        protected abstract double GetAreaDefault();
    }
}
