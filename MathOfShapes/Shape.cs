using MathOfShapes.MethodsForArea;

namespace MathOfShapes
{
    public abstract class Shape
    {
        readonly IAreaComputable areaMethod;
        public Shape(IAreaComputable areaMethod) => this.areaMethod = areaMethod;

        public static ShapeBuilder Builder() => new ShapeBuilder();
        public Precision Precision { get; protected set; }
        public double Area => GetArea();
        public double GetArea() => areaMethod.GetArea(this);
    }
}
