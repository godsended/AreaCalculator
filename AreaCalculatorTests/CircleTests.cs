using SquareCalculator;

namespace AreaCalculatorTests;

public class CircleTests
{
    [Fact]
    public void GetAreaTest()
    {
        IShape circle1 = new Circle(10);
        IShape circle2 = new Circle(67);
        IShape circle3 = new Circle(178);

        Assert.True(Math.Abs(circle1.GetArea() - 314.15926535) <= 0.0001);
        Assert.True(Math.Abs(circle2.GetArea() - 14102.6094215615) <= 0.0001);
        Assert.True(Math.Abs(circle3.GetArea() - 99538.221633494) <= 0.0001);
    }
}