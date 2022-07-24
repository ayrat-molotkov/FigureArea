namespace FigureArea.Infrastructure;

public static class AreaExtensions
{
    public static double ToAreaFormat(this double area)
        => Math.Round(area, 2);
}
