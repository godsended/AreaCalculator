namespace SquareCalculator;

/// <summary>
/// Represents circle with defined radius
/// </summary>
public struct Circle : IShape
{
    private double? _area = null;

    public double Radius { get; private set; }
    
    public Circle(double radius)
    {
        Radius = radius;
    }

    public double GetArea()
    {
        if (_area != null)
            return _area.Value;

        var area = Radius * Radius * Math.PI;

        _area = area;
        return area;
    }
}