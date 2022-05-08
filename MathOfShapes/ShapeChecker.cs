using System.Collections.Generic;

namespace MathOfShapes
{
    internal class ShapeChecker // This class used to determine type of shape
    {
        public Precision Precision { get; }
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        public double Radius { get; }
        internal ShapeChecker(Precision precision, Dictionary<ShapeParam, double> shapeParams) 
        {
            Precision = precision;
            SideA = shapeParams.ContainsKey(ShapeParam.SideA) ? shapeParams[ShapeParam.SideA] : 0;
            SideB = shapeParams.ContainsKey(ShapeParam.SideB) ? shapeParams[ShapeParam.SideB] : 0;
            SideC = shapeParams.ContainsKey(ShapeParam.SideC) ? shapeParams[ShapeParam.SideC] : 0;
            Radius = shapeParams.ContainsKey(ShapeParam.Radius) ? shapeParams[ShapeParam.Radius] : 0;
        }
        internal bool IsTriangle()
        {
            // If the sum of the two sides is greater than the third, then the triangle cannot exist
            return Radius == 0 && SideA + SideB > SideC && SideA + SideC > SideB && SideB + SideC > SideA;
        }

        internal bool IsCircle()
        {
            return Radius > 0 && SideA == 0 && SideB == 0 && SideC == 0;
        }
    }
}
