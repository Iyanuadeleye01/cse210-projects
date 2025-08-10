using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Blue", 3.5);
        double area1 = square.GetArea();
        Console.WriteLine(area1);

        Rectangle rectangle = new Rectangle("Red", 45.0, 10);
        double area2 = rectangle.GetArea();
        Console.WriteLine(area2);

        Circle circle = new Circle("Green", 4.1);
        double area3 = circle.GetArea();
        Console.WriteLine(area3);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("Pale", 4));
        shapes.Add(new Rectangle("Purple", 2.3, 9.2));
        shapes.Add(new Circle("White", 4));
        Console.WriteLine(shapes);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetColor()} - Area: {shape.GetArea()}");
        }
    }
}