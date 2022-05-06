using System;

namespace MathOfShapes.Shapes
{
    internal class Unknown : Shape
    {
        public Unknown(Precision precision) : base(precision) { }
        protected override double GetArea() => throw new NotImplementedException();
    }
}
