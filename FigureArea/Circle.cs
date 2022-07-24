using FigureArea.Infrastructure;

namespace FigureArea;

public class Circle : IAreaFigure
{
    public Circle(double radius)
    {
        Radius = radius;
    }
    public double Radius { get; set; }
    public double GetArea()
    {
        return (Math.PI * Math.Pow(Radius, 2)).ToAreaFormat();
    }
}
