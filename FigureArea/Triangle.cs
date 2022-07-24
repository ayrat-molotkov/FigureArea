namespace FigureArea;

public class Triangle : IAreaFigure
{
    public Triangle(List<double> sides)
    {
        Sides = sides;
    }

    public List<double> Sides { get; set; }

    public double GetArea()
    {
        if (Sides.Count != 3)
            throw new Exception("Incorrect shape data");

        var halfPerimetr = Sides.Sum() / 2;

        return Math.Sqrt(halfPerimetr * (halfPerimetr - Sides[0]) * (halfPerimetr - Sides[1]) * (halfPerimetr - Sides[2]));
    }

    public bool IsRectangular()
    {
        var hypotenuse = Sides.Max();

        return Math.Pow(hypotenuse, 2) == Sides.Where(x => x != hypotenuse).Sum(x => Math.Pow(x, 2));
    }
}
