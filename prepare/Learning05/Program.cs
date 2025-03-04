using System;

class Program
{
    static void Main(string[] args)
    {
        var shapes = new List<Shape>();
        shapes.Add(new Circle("Blue", 4.5));
        shapes.Add(new Rectangle("Green", 10, 6.8));
        shapes.Add(new Square("Red", 5));

        foreach(var shape in shapes){
            System.Console.WriteLine($"{shape.GetColor()}  {shape.GetArea()}");
        }
    }

}