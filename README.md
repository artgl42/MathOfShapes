# MathOfShapes (dll)
Nothing serious, just playing OOP with shapes. Factory Method wrapped in Strategy O,O
## Example
```C#
try
    {
        var shapes = Shape.ShapeBuilder
            .SetTriangle(RoundAccuracy.High, 2, 2.4, 3)
            .SetTriangle(RoundAccuracy.High, 1, 1.5)
            .SetRectangle(RoundAccuracy.High, 5, 4)
            .SetParallelogram(RoundAccuracy.High, 1, 1.5)
            .SetCircle(RoundAccuracy.High, 5.5)
            .Build();
        foreach (var shape in shapes)
            Console.WriteLine($"{shape.Area}");                
    }
    catch (Exception ex)
    {
        Console.WriteLine($"{ex.Message}");
    }
    Console.ReadKey();
```