using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>
        {
            new Square("red", 5),
            new Rectangle("blue", 4, 6),
            new Circle("green", 3)
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetType().Name}: Color={shape.GetColor()}, Area={shape.GetArea():F2}");
        }
    }
}