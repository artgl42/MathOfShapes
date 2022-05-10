using MathOfShapes.Shapes;
using System;

namespace MathOfShapes.MethodsForArea
{
    internal class TriangleAreaByHeron : IAreaComputable
    {
        public double GetArea(Shape shape)
        {
            var _triangle = shape as Triangle; 

            // Heron's formula A = Sqrt(s * (s - a)(s - b)(s - c)), s - semiperimeter
            var _s = (_triangle.SideA + _triangle.SideB + _triangle.SideC) / 2;
            return Math.Round(Math.Sqrt(_s * (_s - _triangle.SideA) * (_s - _triangle.SideB) * (_s - _triangle.SideC)), (byte)_triangle.Precision);
            
        }
    }
}
