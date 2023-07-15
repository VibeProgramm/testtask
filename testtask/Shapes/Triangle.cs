using testtask.Interfaces;

namespace testtask.Shapes;

public class Triangle : IShape
{
    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public double CalculateArea()
    {
        // Using Heron's formula
        var semiPerimeter = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(semiPerimeter *
                         (semiPerimeter - SideA) *
                         (semiPerimeter - SideB) *
                         (semiPerimeter - SideC));
    }

    public bool IsRightTriangle()
    {
        var sides = new[] { SideA, SideB, SideC };
        Array.Sort(sides);

        return Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) < 0.0001;
    }
}