namespace FigureArea;

public class Circle : IAreaFigure
{
    public double Radius { get; set; }
    public double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}
