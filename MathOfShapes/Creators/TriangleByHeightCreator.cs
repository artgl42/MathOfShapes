using MathOfShapes.Shapes;
using System;

namespace MathOfShapes.Creators
{
    internal class TriangleByHeightCreator : ShapeCreator
    {
        internal double LengthBase { get; set; }
        internal double Height { get; set; }

        internal override Shape CreateShape()
        {
            if (LengthBase > 0 && Height > 0)
                return new TriangleByHeight(RoundAccuracy, LengthBase, Height);
            throw new Exception($"Incorrect parameters for {this.GetType().Name}: {LengthBase}, {Height}");
        }
    }
}
