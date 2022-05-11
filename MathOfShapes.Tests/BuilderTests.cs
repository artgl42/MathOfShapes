using MathOfShapes.Shapes;
using Xunit;

namespace MathOfShapes.Tests
{
    public class BuilderTests
    {
        [Fact]
        public void SetTriangle_GetTriangle()
        {
            // Act
            var _actual = Shape.Builder()
                .SetTriangle(RoundAccuracy.High, 1, 2, 1.5)
                .Build();

            // Assert
            Assert.IsType<TriangleBySides>(_actual[0]);
        }

        [Fact]
        public void SetCircle_GetCircle()
        {
            // Act
            var _actual = Shape.Builder()
                .SetCircle(RoundAccuracy.High, 5.5)
                .Build();

            // Assert
            Assert.IsType<Circle>(_actual[0]);
        }
    }
}
