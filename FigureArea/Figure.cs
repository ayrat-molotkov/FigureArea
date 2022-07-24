namespace FigureArea;

public class Figure
{
    public Figure(IAreaFigure areaFigure)
    {
        _areaFigure = areaFigure;
    }


    public double CalculateArea()
    {
        return _areaFigure.GetArea();
    }


    private readonly IAreaFigure _areaFigure;
}
