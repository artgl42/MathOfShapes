using System;

namespace MathOfShapes.Shapes
{
    public class Parallelogram : Shape
    {
        public double LengthBase { get; }
        public double Height { get; }

        internal Parallelogram(
            RoundAccuracy roundAccuracy,
            double lengthBase,
            double height) : base(roundAccuracy)
        {
            LengthBase = lengthBase;
            Height = height;
        }

        protected override double GetArea()
        {
            // Area = LengthBase * Height
            return Math.Round(LengthBase * Height, (byte)RoundAccuracy);
        }
    }
}
