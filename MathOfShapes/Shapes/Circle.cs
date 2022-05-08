using System;
using System.Collections.Generic;

namespace MathOfShapes.Shapes
{
    internal class Circle : Shape
    {
        internal Circle(
            Precision precision,
            Dictionary<ShapeParam, double> shapeParams,
            Func<Dictionary<ShapeParam, double>, double> methodForArea) : base(precision, shapeParams, methodForArea) { }

        protected override double GetAreaDefault()
        {
            // Area of circle by radius A = PI * r^2
            return Math.Round(Math.PI * Math.Pow(ShapeParams[ShapeParam.Radius], 2), (byte)Precision); 
        }
    }
}
