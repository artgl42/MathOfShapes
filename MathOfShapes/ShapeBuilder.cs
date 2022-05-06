using MathOfShapes.Shapes;

namespace MathOfShapes
{
    //Some values (max 15) for Math.Round. For exp: Precision.Low means return value from GetArea() will be Math.Round(value, 1)
    public enum Precision { None, Low, Medium, High }

    //Using the "Fluent Builder" pattern to creating shape
    public class ShapeBuilder
    {
        internal Precision Precision { get; set; }
        internal double SideA { get; set; }
        internal double SideB { get; set; }
        internal double SideC { get; set; }
        internal double Radius { get; set; }

        public ShapeBuilder SetRoundPrecision(Precision precision)
        {
            Precision = precision;
            return this;
        }

        public ShapeBuilder SetTriangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            return this;
        }

        public ShapeBuilder SetCircle(double radius)
        {
            Radius = radius;
            return this;
        }

        public Shape Build()
        {
            if (CheckIsTriangle()) return new Triangle(SideA, SideB, SideC, Precision);
            if (CheckIsCircle()) return new Circle(Radius, Precision);
            return new Unknown(Precision.None);
        }

        bool CheckIsTriangle()
        {
            if (Radius == 0 && SideA > 0 && SideB > 0 && SideC > 0)
            {
                if (SideA + SideB > SideC
                 && SideA + SideC > SideB
                 && SideB + SideC > SideA)
                {
                    return true;
                }
            }
            return false;
        }

        bool CheckIsCircle()
        {
            if (Radius > 0 && SideA == 0 && SideB == 0 && SideC == 0)
            {
                return true;
            }
            return false;
        }
    }
}
