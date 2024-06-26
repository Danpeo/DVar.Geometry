namespace DVar.Geometry;

public abstract class MathUtil
{
    public static bool IsAlmostEqual(double lhs, double rhs, double tolerance = 0.0001) => 
        Math.Abs(lhs - rhs) < tolerance;
}