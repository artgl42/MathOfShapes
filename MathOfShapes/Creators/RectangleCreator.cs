using MathOfShapes.Shapes;
using System;

namespace MathOfShapes.Creators
{
    internal class RectangleCreator : ShapeCreator
    {
        internal double Length { get; set; }
        internal double Width { get; set; }

        internal override Shape CreateShape() 
        {
            if (Length > 0)
                return new Rectangle(RoundAccuracy, Length, Width);
            throw new Exception($"Incorrect parameters for {this.GetType().Name}: {Length}, {Width}");
        }
    }
}
