using MathOfShapes.MethodsForArea;

namespace MathOfShapes.Shapes
{
    internal class Circle : Shape
    {
        public double Radius { get; }

        internal Circle(
            IAreaComputable areaMethod, 
            Precision precision, 
            double radius) : base(areaMethod)
        {
            Precision = precision;
            Radius = radius;
        }
    }
}
