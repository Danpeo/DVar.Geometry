namespace DVar.Geometry;

public class Circle(double radius) : IShape
{
    public double CalculateArea() => Math.PI * radius * radius;
}