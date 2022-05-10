using MathOfShapes.MethodsForArea;
using MathOfShapes.Shapes;
using System.Collections.Generic;

namespace MathOfShapes
{
    // Precision - some values (max 15) for Math.Round. For exp: Precision.Low means return value Area will be Math.Round(value, 1)
    public enum Precision { None, Low, Medium, High }

    public class ShapeBuilder // Using the "Fluent Builder" pattern to creating shape
    {
        public Precision Precision { get; set; } = Precision.Low;
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double Radius { get; set; }

        public ShapeBuilder SetPrecision(Precision precision)
        {
            Precision = precision;
            return this;
        }

        public ShapeBuilder SetSideA(double sideA)
        {
            SideA = sideA;
            return this;
        }

        public ShapeBuilder SetSideB(double sideB)
        {
            SideB = sideB;
            return this;
        }

        public ShapeBuilder SetSideC(double sideC)
        {
            SideC = sideC;
            return this;
        }

        public ShapeBuilder SetRadius(double radius)
        {
            Radius = radius;
            return this;
        }

        public List<Shape> Build()
        {
            var _listShapes = new List<Shape>();

            // If the sum of the two sides is greater than the third, then the triangle cannot exist
            if (SideA + SideB > SideC && SideA + SideC > SideB && SideB + SideC > SideA)
            {
                _listShapes.Add(new Triangle(new TriangleAreaByHeron(), Precision, SideA, SideB, SideC));
            }

            if (Radius > 0)
            {
                _listShapes.Add(new Circle(new CircleAreaByRadius(), Precision, Radius));
            }

            return _listShapes;
        }
    }
}
