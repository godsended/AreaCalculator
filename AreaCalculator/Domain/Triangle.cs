namespace SquareCalculator;

/// <summary>
/// Triangle with sides named as A, B and C and angles AB, BC an AC
/// </summary>
//     AC
//     /\
//  A /  \ C
//   /    \
//  /______\
// AB   B  BC
public struct Triangle : IShape
{
    private double? _area = null;

    public double ASide { get; private set; }

    public double BSide { get; private set; }

    public double CSide { get; private set; }

    public double ABAngle { get; private set; }

    public double ACAngle { get; private set; }

    public double BCAngle { get; private set; }

    public bool IsRightTriangle { get; private set; }

    public Triangle(double aSide, double bSide, double cSide)
    {
        if (aSide + bSide <= cSide || aSide + cSide <= bSide || bSide + cSide <= aSide)
        {
            throw new ArgumentException("Impossible to define triangle with such sides!");
        }

        ASide = aSide;
        BSide = bSide;
        CSide = cSide;
        CalculateAngles();

        //Possible loss of precision
        if (Math.Abs(BCAngle - 90) < 0.001 ||
            Math.Abs(ACAngle - 90) < 0.001 ||
            Math.Abs(ABAngle - 90) < 0.001)
        {
            IsRightTriangle = true;
        }
    }

    public double GetArea()
    {
        if (_area != null)
            return _area.Value;

        var p = (ASide + BSide + CSide) / 2;
        var area = Math.Sqrt(p * (p - ASide) * (p - BSide) * (p - CSide));

        _area = area;
        return area;
    }
    
    private void CalculateAngles()
    {
        BCAngle = Math.Acos((BSide * BSide + CSide * CSide - ASide * ASide) / (2 * BSide * CSide)) * 180 / Math.PI;
        ACAngle = Math.Acos((ASide * ASide + CSide * CSide - BSide * BSide) / (2 * ASide * CSide)) * 180 / Math.PI;
        ABAngle = Math.Acos((ASide * ASide + BSide * BSide - CSide * CSide) / (2 * ASide * BSide)) * 180 / Math.PI;
    }
}