using System;

namespace MathOfShapes.Shapes
{
    public class Circle : IShape
    {
        public byte Precision { get; }
        public double Radius { get; }
        public Circle(double radius, Precision precision)
        {
            Precision = (byte)precision;
            Radius = radius;
        }

        double IShape.GetArea()
        {
            //Area of circle by radius A = PI * r^2
            return Math.Round(Math.PI * Math.Pow(Radius, 2), Precision);
        }
    }
}
