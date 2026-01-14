using System;

interface Shape
{
    double Area();
    void Size();
}

class Square : Shape
{
    private double side;

    public Square(double side)
    {
        this.side = side;
    }

    public double Area()
    {
        return side * side;
    }

    public void Size()
    {
        Console.WriteLine("Square Side = " + side);
    }
}

class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double Area()
    {
        return 3.14 * radius * radius;
    }

    public void Size()
    {
        Console.WriteLine("Circle Radius = " + radius);
    }
}

class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public double Area()
    {
        return length * width;
    }

    public void Size()
    {
        Console.WriteLine("Rectangle Length = " + length + ", Width = " + width);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape square = new Square(4);
        Shape circle = new Circle(7);
        Shape rectangle = new Rectangle(4, 6);

        square.Size();
        Console.WriteLine("Area = " + square.Area());

        Console.WriteLine();

        circle.Size();
        Console.WriteLine("Area = " + circle.Area());

        Console.WriteLine();

        rectangle.Size();
        Console.WriteLine("Area = " + rectangle.Area());
    }
}

