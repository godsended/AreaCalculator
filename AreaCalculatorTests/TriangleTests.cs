using SquareCalculator;

namespace AreaCalculatorTests;

public class TriangleTests
{
    [Fact]
    public void RightTriangleTest()
    {
        var triangle1 = new Triangle(6, 8, 10);
        var triangle2 = new Triangle(600, 800, 1001);
        var triangle3 = new Triangle(10, 11, 12);
        
        Assert.True(triangle1.IsRightTriangle);
        Assert.False(triangle2.IsRightTriangle);
        Assert.False(triangle3.IsRightTriangle);
    }

    [Fact]
    public void GetAreaTest()
    {
        IShape triangle1 = new Triangle(6, 8, 10);
        IShape triangle2 = new Triangle(3, 3, 3);
        IShape triangle3 = new Triangle(11, 12, 13);
        
        Assert.True(Math.Abs(triangle1.GetArea() - 24) <= 0.0001);
        Assert.True(Math.Abs(triangle2.GetArea() - 3.897114317029974) <= 0.0001);
        Assert.True(Math.Abs(triangle3.GetArea() - 61.48170459575759) <= 0.0001);
    }
}