namespace DVar.Geometry;

public class Geometry
{
    public static double AreaOfShape(double[] sides) =>
        sides.Length switch
        {
            1 => new Circle(sides[0]).CalculateArea(),
            3 => new Triangle(sides[0], sides[1], sides[2]).CalculateArea(),
            _ => throw new ArgumentException("Unsupported number of sides for shape.")
        };
}