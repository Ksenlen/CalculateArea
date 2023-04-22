using CalculateArea;

namespace TestProject
{
    public class CircleTests
    {
        [Fact]
        public void CalculateArea_ReturnsCorrectValue()
        {
            // Arrange
            double radius = 5;
            Circle circle = new Circle(radius);

            // Act
            double area = circle.CalculateArea();

            // Assert
            Assert.Equal(Math.PI * Math.Pow(radius, 2), area);
        }
    }
}