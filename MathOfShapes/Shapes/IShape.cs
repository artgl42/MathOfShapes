namespace MathOfShapes.Shapes
{
    public interface IShape
    {
        //Precision - value for Math.Round (max 15)
        byte Precision { get; }
        double GetArea();
    }
}
