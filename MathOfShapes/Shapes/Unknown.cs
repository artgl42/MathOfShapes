using System;
using System.Collections.Generic;

namespace MathOfShapes.Shapes
{
    internal class Unknown : Shape
    {
        internal Unknown(
            Precision precision,
            Dictionary<ShapeParam, double> shapeParams,
            Func<Dictionary<ShapeParam, double>, double> methodForArea) : base(precision, shapeParams, methodForArea) { }

        protected override double GetAreaDefault()
        {
            return 0;
        }
    }
}
