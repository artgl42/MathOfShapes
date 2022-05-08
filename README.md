# MathOfShapes (dll)
Need to add this dll to the project (don't forget to add references) and you can use it.
## Example
```C#
var _triangle = Shape.Builder()
                .SetRoundPrecision(Precision.Medium)
                .SetSideA(1)
                .SetSideB(1.8)
                .SetSideC(1.5)
                .Build();
Console.WriteLine($"Area of shape = {_triangle.Area}");
```