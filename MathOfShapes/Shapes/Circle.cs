using System;

namespace MathOfShapes.Shapes
{
    internal class Circle : Shape
    {
        internal double Radius { get; }
        internal Circle(double radius, Precision precision) : base(precision)
        {
            Radius = radius;
            Area = GetArea();
        }

        protected override double GetArea()
        {
            //Area of circle by radius A = PI * r^2
            return Math.Round(Math.PI * Math.Pow(Radius, 2), (byte)Precision);
        }
    }
}
