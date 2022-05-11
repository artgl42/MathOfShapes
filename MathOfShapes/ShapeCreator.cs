namespace MathOfShapes
{
    // RoundAccuracy - some values (max 15) for Math.Round. For exp: RoundAccuracy.Low means return value Area will be Math.Round(value, 1)
    public enum RoundAccuracy { None, Low, Medium, High }

    internal abstract class ShapeCreator
    {
        internal RoundAccuracy RoundAccuracy { get; set; }
        internal abstract Shape CreateShape();
    }
}
