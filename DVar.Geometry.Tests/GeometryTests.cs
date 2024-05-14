namespace DVar.Geometry.Tests;

public class GeometryTests
{
    [Fact]
    public void AreaOfShape_Circle_Test()
    {
        // Arrange
        double[] sides = [5];

        // Act
        double area = Geometry.AreaOfShape(sides);

        // Assert
        Assert.Equal(78.5398, area, 4);
    }

    [Fact]
    public void AreaOfShape_Triangle_Test()
    {
        // Arrange
        double[] sides = [3, 4, 5];

        // Act
        double area = Geometry.AreaOfShape(sides);

        // Assert
        Assert.Equal(6, area, 4);
    }

    [Fact]
    public void AreaOfShape_UnsupportedShape_Test()
    {
        // Arrange
        double[] sides = [1, 2, 3, 4];

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Geometry.AreaOfShape(sides));
    }
}