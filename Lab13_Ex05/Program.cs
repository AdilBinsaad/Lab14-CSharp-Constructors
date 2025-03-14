var circle = new Circle();
var rectangle = new Rectangle();
var triangle = new Triangle();

class Shape
{
    private int? NumOfSide;

    protected Shape()
    {
    }

    public Shape(int numOfSide) : this()
    {
        this.NumOfSide = numOfSide;
        Console.WriteLine($"This is some shape with {numOfSide} sides");
    }
}

class Circle : Shape
{
    public Circle() : base(0) 
    {
        Console.WriteLine("This is a circle");
    }
}

class Rectangle : Shape
{
    public Rectangle() : base(4) 
    {
        Console.WriteLine("This is a rectangle");
    }
}

class Triangle : Shape
{
    public Triangle() : base(3) 
    {
        Console.WriteLine("This is a triangle");
    }
}