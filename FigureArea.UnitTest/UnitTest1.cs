using System.Collections.Generic;
using Xunit;

namespace FigureArea.UnitTest;
public class UnitTest1
{
    [Fact]
    public void TestCircle()
    {
        var circle = new Circle(10);

        double area = circle.GetArea();

        Assert.Equal(314.16, area);
    }

    [Fact]
    public void TestTriangl()
    {
        var triangle = new Triangle(new List<double>() { 4, 6, 8 });

        double area = triangle.GetArea();

        Assert.Equal(11.62, area);
    }
}