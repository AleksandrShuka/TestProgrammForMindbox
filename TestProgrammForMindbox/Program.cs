using TestProgrammForMindbox;
using TestProgrammForMindbox.data;

Console.WriteLine("Demostration");
Console.WriteLine("Square of circle (radius 1) = " + Calculate.CalculateCircleSquare(1));
Console.WriteLine("Square of triangle (sides: 3, 4, 5) = " + Calculate.CalculateTriangleSquare(3, 4, 5));
Console.WriteLine("Is right triangle? (sides: 3, 4, 5) = " + Calculate.IsRightTriangle(3, 4, 5));

Console.WriteLine("Calculate square of unknown object (circle radius 1)");
Circle circle = new Circle(1);
ICalculateSquare entity = circle;
Console.WriteLine("result = " + entity.CalculateSquare());

