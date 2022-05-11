using MathOfShapes.Creators;
using System.Collections.Generic;

namespace MathOfShapes
{
    public class ShapeBuilder // Using the "Fluent Builder" pattern to creating shapes
    {
        readonly List<ShapeCreator> shapeCreators = new List<ShapeCreator>();
        public ShapeBuilder SetTriangle(RoundAccuracy roundAccuracy, double sideA, double sideB, double sideC)
        {
            var _triangleBySidesCreator = new TriangleBySidesCreator
            {
                RoundAccuracy = roundAccuracy,
                SideA = sideA,
                SideB = sideB,
                SideC = sideC
            };
            shapeCreators.Add(_triangleBySidesCreator);
            return this;
        }

        public ShapeBuilder SetTriangle(RoundAccuracy roundAccuracy, double lengthBase, double height)
        {
            var _triangleByHeightCreator = new TriangleByHeightCreator
            {
                RoundAccuracy = roundAccuracy,
                LengthBase = lengthBase,
                Height = height
            };
            shapeCreators.Add(_triangleByHeightCreator);
            return this;
        }

        public ShapeBuilder SetCircle(RoundAccuracy roundAccuracy, double radius)
        {
            var _circleCreator = new CircleCreator
            {
                RoundAccuracy = roundAccuracy,
                Radius = radius
            };
            shapeCreators.Add(_circleCreator);
            return this;
        }

        public ShapeBuilder SetRectangle(RoundAccuracy roundAccuracy, double length, double width = 0)
        {
            var _rectangleCreator = new RectangleCreator
            {
                RoundAccuracy = roundAccuracy,
                Length = length,
                Width = width
            };
            shapeCreators.Add(_rectangleCreator);
            return this;
        }

        public ShapeBuilder SetParallelogram(RoundAccuracy roundAccuracy, double lengthBase, double height)
        {
            var _parallelogramCreator = new ParallelogramCreator
            {
                LengthBase = lengthBase,
                Height = height
            };
            shapeCreators.Add(_parallelogramCreator);
            return this;
        }

        public List<Shape> Build()
        {
            var _shapes = new List<Shape>();

            foreach (var shapeCreator in shapeCreators)
                _shapes.Add(shapeCreator.CreateShape());

            return _shapes;
        }
    }
}
