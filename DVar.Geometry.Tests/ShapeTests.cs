namespace DVar.Geometry.Tests;

public class ShapeTests
{
    [Fact]
    public void Circle_GetArea_Test()
    {
        // Arrange
        var circle = new Circle(5);

        // Act
        double area = circle.CalculateArea();

        // Assert
        Assert.Equal(78.5398, area, 4);
    }

    [Fact]
    public void Triangle_GetArea_Test()
    {
        // Arrange
        var triangle = new Triangle(3, 4, 5);

        // Act
        double area = triangle.CalculateArea();

        // Assert
        Assert.Equal(6, area, 4);
    }

    [Fact]
    public void Triangle_IsRightAngleTriangle_Test()
    {
        // Arrange
        var triangle = new Triangle(3, 4, 5);

        // Act
        bool isRightAngle = triangle.IsRightAngled();

        // Assert
        Assert.True(isRightAngle); 
    }
}