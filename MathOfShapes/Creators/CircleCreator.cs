using MathOfShapes.Shapes;
using System;

namespace MathOfShapes.Creators
{
    internal class CircleCreator : ShapeCreator
    {
        internal double Radius { get; set; }

        internal override Shape CreateShape() 
        {
            if (Radius > 0)
                return new Circle(RoundAccuracy, Radius);
            throw new Exception($"Incorrect parameters for {this.GetType().Name}: {Radius}");
        }
    }
}
