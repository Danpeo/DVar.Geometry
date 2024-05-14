namespace DVar.Geometry;

public class Triangle(double side1, double side2, double side3) : IShape
{
    public double CalculateArea()
    {
        double semiPerimeter = (side1 + side2 + side3) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));
    }

    public bool IsRightAngled() =>
        MathUtil.IsAlmostEqual(side1 * side1, side2 * side2 + side3 * side3) ||
        MathUtil.IsAlmostEqual(side2 * side2, side1 * side1 + side3 * side3) ||
        MathUtil.IsAlmostEqual(side3 * side3, side1 * side1 + side2 * side2);
}