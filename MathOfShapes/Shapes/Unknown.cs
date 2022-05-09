using System;
using System.Collections.Generic;

namespace MathOfShapes.Shapes
{
    // Just stub class to exclude null returns for ShapeBuilder.Build()
    internal class Unknown : Shape
    {
        internal Unknown(
            Dictionary<ShapeParam, double> inShapeParams,
            Func<Dictionary<ShapeParam, double>, double> methodForArea) : base(inShapeParams, methodForArea) { }

        protected override double GetAreaDefault() => 0;
    }
}
