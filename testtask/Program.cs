using testtask.classes;
using testtask.interfaces;

IShape circle = new Circle(5);
Console.WriteLine($"Area of the circle: {circle.CalculateArea()}");

IShape triangle = new Triangle(3, 4, 5);
Console.WriteLine($"Area of the triangle: {triangle.CalculateArea()}");

if (((triangle as Triangle)!).IsRightTriangle())
{
    Console.WriteLine("The triangle is right-angled.");
}
Console.ReadKey();