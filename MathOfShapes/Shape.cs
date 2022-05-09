using System;
using System.Collections.Generic;

namespace MathOfShapes
{
    // ShapeParam - parameters available for setting for shapes
    public enum ShapeParam { Precision, SideA, SideB, SideC, Radius, Height }

    public abstract class Shape
    {
        protected byte Precision { get; }
        internal Dictionary<ShapeParam, double> InShapeParams { get; } // Set of available (enum ShapeParam) parameters for future shape
        internal Func<Dictionary<ShapeParam, double>, double> AreaFunc { get; } // User can set his own method for calculating area of shape
        public double Area => AreaFunc?.Invoke(InShapeParams) ?? GetAreaDefault();

        internal Shape(
            Dictionary<ShapeParam, double> inShapeParams,
            Func<Dictionary<ShapeParam, double>, double> areaFunc)
        {
            
            InShapeParams = inShapeParams;
            Precision = (byte)InShapeParams[ShapeParam.Precision];
            AreaFunc = areaFunc;
        }

        public static ShapeBuilder Builder() => new ShapeBuilder(); // Using the "Fluent Builder" pattern to creating shape
        protected abstract double GetAreaDefault(); // Will be use if AreaFunc don't set by user
    }
}
