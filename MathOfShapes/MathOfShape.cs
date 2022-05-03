using MathOfShapes.Shapes;

namespace MathOfShapes
{
    //Some values for Math.Round to get precision (max 15)
    public enum Precision : byte
    {
        None = 1,
        Low = 2,
        Medium = 3,
        High = 4
    }

    public static class MathOfShape
    {
        public static double GetArea(IShape shape) => shape.GetArea();
    }
}
