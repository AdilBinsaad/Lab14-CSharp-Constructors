var circle = new Circle();
var rectangle = new Rectangle();
var triangle = new Triangle();

class Shape
{
    protected int? NumOfSide; // เปลี่ยนเป็น protected เพื่อให้คลาสลูกสามารถเข้าถึงได้

    public Shape()
    {
        NumOfSide = null;
        Console.WriteLine("This is some shape with unknown side");
    }

    public Shape(int numOfSide) // แก้ชื่อพารามิเตอร์ให้เป็นตัวพิมพ์เล็ก (convention)
    {
        NumOfSide = numOfSide;
        Console.WriteLine($"This is some shape with {NumOfSide} sides");
    }
}

class Circle : Shape
{
    public Circle() : base() // เรียก constructor ของ Shape ที่ไม่มีพารามิเตอร์
    {
        Console.WriteLine("This is a circle");
    }
}

class Rectangle : Shape
{
    public Rectangle() : base(4) // เรียก constructor ของ Shape ที่รับค่า 4
    {
        Console.WriteLine("This is a rectangle");
    }
}

class Triangle : Shape
{
    public Triangle() : base(3) // เรียก constructor ของ Shape ที่รับค่า 3
    {
        Console.WriteLine("This is a triangle");
    }
}