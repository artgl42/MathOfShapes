using System;
using System.Collections.Generic;

namespace MathOfShapes.Shapes
{
    internal class Circle : Shape
    {
        internal Circle(
            Dictionary<ShapeParam, double> inShapeParams,
            Func<Dictionary<ShapeParam, double>, double> methodForArea) : base(inShapeParams, methodForArea) { }


        protected override double GetAreaDefault()
        {
            // Area of circle by radius A = PI * r^2
            return Math.Round(Math.PI * Math.Pow(InShapeParams[ShapeParam.Radius], 2), Precision); 
        }
    }
}
