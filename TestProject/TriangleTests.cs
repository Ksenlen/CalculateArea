using CalculateAreaLibrary;

namespace TestProject
{
    public class TriangleTests
    {
        [Fact]
        public void CalculateArea_ReturnsCorrectValue()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            double area = triangle.CalculateArea();

            // Assert
            Assert.Equal(6, area);
        }

        [Fact]
        public void IsRightTriangle_ReturnsTrueForRightTriangle()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.True(isRightTriangle);
        }

        [Fact]
        public void IsRightTriangle_ReturnsFalseForNonRightTriangle()
        {
            // Arrange
            double sideA = 5;
            double sideB = 5;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.False(isRightTriangle);
        }
    }
}
