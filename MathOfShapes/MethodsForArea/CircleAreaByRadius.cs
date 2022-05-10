using MathOfShapes.Shapes;
using System;

namespace MathOfShapes.MethodsForArea
{
    internal class CircleAreaByRadius : IAreaComputable
    {
        public double GetArea(Shape shape)
        {
            var _circle = shape as Circle;

            // Area of circle by radius A = PI * r^2
            return Math.Round(Math.PI * Math.Pow(_circle.Radius, 2), (byte)_circle.Precision);
        }
    }
}
