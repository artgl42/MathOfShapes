# MathOfShapes (dll)
Add this dll to your project (don't forget to add reference) and you can use it.
## Example
```C#
var shapes = Shape.Builder()
                .SetPrecision(Precision.Low)
                .SetSideA(1.5)
                .SetSideB(1.6)
                .SetSideC(1.4)
                .SetRadius(5)
                .Build();

foreach (var shape in shapes)
    Console.WriteLine($"{shape.Area}");
```