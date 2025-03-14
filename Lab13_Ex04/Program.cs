﻿var circle = new Circle();
var rectangle = new Rectangle();
var triangle = new Triangle();

class Shape
{
    private int? NumOfSide;

    // เปลี่ยนจาก private เป็น protected เพื่อให้สามารถเรียกใช้ในคลาสลูกได้
    protected Shape()
    {
        Console.WriteLine("This is some shape with unknown side");
    }

    public Shape(int numOfSide)
    {
        NumOfSide = numOfSide;
        Console.WriteLine($"This is some shape with {NumOfSide} sides");
    }
}

class Circle : Shape
{
    public Circle() : base() // เรียกใช้ constructor ของ Shape ที่ไม่มีพารามิเตอร์
    {
        Console.WriteLine("This is a circle");
    }
}

class Rectangle : Shape
{
    public Rectangle() : base(4) // เรียก constructor ที่กำหนดจำนวนด้านเป็น 4
    {
        Console.WriteLine("This is a rectangle");
    }
}

class Triangle : Shape
{
    public Triangle() : base(3) // เรียก constructor ที่กำหนดจำนวนด้านเป็น 3
    {
        Console.WriteLine("This is a triangle");
    }
}