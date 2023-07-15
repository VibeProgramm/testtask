using testtask.classes;

namespace Testtesttask;

[TestFixture]
public class ShapeTests
{
    [Test]
    public void CircleAreaTest()
    {
        var circle = new Circle(5);
        Assert.That(circle.CalculateArea(), Is.EqualTo(Math.PI * 25));
    }

    [Test]
    public void TriangleAreaTest()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.That(triangle.CalculateArea(), Is.EqualTo(6));
    }

    [Test]
    public void TriangleRightAngleTest()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.IsTrue(triangle.IsRightTriangle());
    }
}