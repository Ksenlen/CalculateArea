namespace CalculateArea
{
    public interface IShape
    {
        double CalculateArea();
    }

    public class Circle : IShape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            if (!IsValidRadius(radius))
            {
                throw new ArgumentException("Invalid circle radius");
            }

            _radius = radius;
        }

        private static bool IsValidRadius(double radius)
        {
            return radius > 0;
        }

        public double CalculateArea() => Math.PI * Math.Pow(_radius, 2);
    }

    public class Triangle : IShape
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (!IsValidTriangle(sideA, sideB, sideC))
            {
                throw new ArgumentException("Invalid triangle sides");
            }

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public double CalculateArea()
        {
            double p = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
        }
        private static bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && b + c > a && a + c > b;
        }

        public bool IsRightTriangle()
        {
            double[] sides = { _sideA, _sideB, _sideC };
            Array.Sort(sides);
            return Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2)))<0.000001;
        }
    }

    public enum ShapeType
    {
        Circle,
        Triangle,
        // добавить другие фигуры при необходимости
    }

    public static class ShapeFactory
    {
        public static IShape CreateShape(ShapeType shapeType, params double[] parameters)
        {
            return shapeType switch
            {
                ShapeType.Circle => parameters.Length == 1 ? new Circle(parameters[0]) : throw new ArgumentException("Circle requires 1 parameter (radius)"),
                ShapeType.Triangle => parameters.Length == 3 ? new Triangle(parameters[0], parameters[1], parameters[2]) : throw new ArgumentException("Triangle requires 3 parameters (3 sides)"),
                //добавить другие фигуры при необходимости
                _ => throw new ArgumentException("Invalid shape type"),
            };
        }
    }
}