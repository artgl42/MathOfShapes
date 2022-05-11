using System;

namespace MathOfShapes.Shapes
{
    public class TriangleByHeight : Shape
    {
        public double LengthBase { get; }
        public double Height { get; }

        internal TriangleByHeight(
            RoundAccuracy roundAccuracy,
            double lengthBase,
            double height) : base(roundAccuracy)
        {
            LengthBase = lengthBase;
            Height = height;
        }

        protected override double GetArea()
        {
            // Formula is: A = 1/2 * b * h, where b is the length of the base of the triangle, and h is the height or altitude of the triangle
            return Math.Round(0.5 * LengthBase * Height, (byte)RoundAccuracy);
        }
    }
}
