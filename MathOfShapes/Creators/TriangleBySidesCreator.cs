using MathOfShapes.Shapes;
using System;

namespace MathOfShapes.Creators
{
    internal class TriangleBySidesCreator : ShapeCreator
    {
        internal double SideA { get; set; }
        internal double SideB { get; set; }
        internal double SideC { get; set; }

        internal override Shape CreateShape() 
        {
            // If the sum of the two sides is greater than the third, then the triangle can exist
            if (SideA + SideB > SideC && SideA + SideC > SideB && SideB + SideC > SideA)
                return new TriangleBySides(RoundAccuracy, SideA, SideB, SideC);
            throw new Exception($"Incorrect parameters for {this.GetType().Name}: {SideA}, {SideB}, {SideC}");
        }
    }
}
