using System;

namespace MathOfShapes
{
    public abstract class Shape
    {        
        public Precision Precision { get; } //Precision - value for Math.Round (max 15)
        public double Area { get; protected set; }
        public static ShapeBuilder Builder() => new ShapeBuilder(); //Precision - value for Math.Round (max 15)
        public Shape(Precision precision) => Precision = precision;
        protected abstract double GetArea();
    }
}
