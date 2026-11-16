using System;

abstract class Shape
{
    public abstract int GetArea();
}

class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }
    public override int GetArea()
    {
        return Width * Height;
    }
}

class Square : Shape
{
    public int Side { get; set; }
    public override int GetArea()
    {
        return Side * Side;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle();
        rect.Width = 5;
        rect.Height = 10;
        Console.WriteLine(rect.GetArea());

        Square square = new Square();
        square.Side = 5;
        Console.WriteLine(square.GetArea());

        Console.ReadKey();
    }
}