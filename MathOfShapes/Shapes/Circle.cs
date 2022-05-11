using System;

namespace MathOfShapes.Shapes
{
    internal class Circle : Shape
    {
        public double Radius { get; }

        internal Circle(
            RoundAccuracy roundAccuracy,
            double radius) : base(roundAccuracy) => Radius = radius;

        protected override double GetArea()
        {
            // Area of circle by radius A = PI * r^2
            return Math.Round(Math.PI * Math.Pow(Radius, 2), (byte)RoundAccuracy);
        }
    }
}
