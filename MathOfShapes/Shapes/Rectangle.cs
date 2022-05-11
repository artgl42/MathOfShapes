using System;

namespace MathOfShapes.Shapes
{
    public class Rectangle : Shape
    {
        public double Length { get; }
        public double Width { get; }
        public bool IsSquare => CheckIsSquare();

        internal Rectangle(
            RoundAccuracy roundAccuracy,
            double length,
            double width) : base(roundAccuracy)
        {
            Length = length;
            Width = width > 0 ? width : length;
        }

        protected override double GetArea()
        {
            // Area = Length * Width
            return Math.Round(Length * Width, (byte)RoundAccuracy);
        }

        bool CheckIsSquare() => Length == Width;
    }
}
