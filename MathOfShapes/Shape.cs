namespace MathOfShapes
{
    public abstract class Shape
    {
        public RoundAccuracy RoundAccuracy { get; protected set; }
        public double Area => GetArea();
        public static ShapeBuilder Builder() => new ShapeBuilder();
        public Shape(RoundAccuracy roundAccuracy) => RoundAccuracy = roundAccuracy; 
        protected abstract double GetArea();
    }
}
