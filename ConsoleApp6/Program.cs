using GeometryLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        double result = Аrithmetic.Divide(3, 5);
        Console.WriteLine(result);

        Figure circle = new Circle(5);
        Figure triangle = new Triangle(3, 4, 5);
        Figure rectangle = new Rectangle(3, 4);

        double circleArea = circle.GetArea();
        double triangleArea = triangle.GetArea();
        double rectangleArea = rectangle.GetArea();

        Console.WriteLine($"Площадь круга: {circleArea}");
        Console.WriteLine($"Площадь треугольника: {triangleArea}");
        Console.WriteLine($"Площадь прямоугольника: {rectangleArea}");

        Triangle triangle1 = new Triangle(3, 4, 5);
        Triangle triangle2 = new Triangle(5, 12, 13);

        bool isRightTriangle1 = triangle1.IsRightTriangle();
        bool isRightTriangle2 = triangle2.IsRightTriangle();

        Console.WriteLine($"Треугольник 1 является прямоугольным: {isRightTriangle1}");
        Console.WriteLine($"Треугольник 2 является прямоугольным: {isRightTriangle2}");

        //double radius = 5;
        //double resultCircle = Geometry.GetCircleArea(radius);
        //Console.WriteLine($"Площадь круга с радиусом {radius} равна {resultCircle}");

        //double resultTriangle = Geometry.GetTriangleArea(3, 4, 5);
        //Console.WriteLine(resultTriangle);

        Console.ReadLine();
    }
}