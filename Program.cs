﻿// See https://aka.ms/new-console-template for more information
using Week1ObjectOriented.Classes;
using Week1ObjectOriented.Interfaces;

var square = new Square(10);
try
{


    square.SetArea(2);


    Console.WriteLine("The area is " + square.GetArea());
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}



//1. Create Circle Object and get the area
Console.WriteLine("\n\nTask 1: Demo\n");
var circle = new Circle(5);
Console.WriteLine("Circle1 Area: " + circle.GetArea());

//1. Creating object Using object Initializer. It needs a default constructor
var circle2 = new Circle{Radius = 6};
Console.WriteLine("Circle2 Area: " + circle2.GetArea());

ShapeColourHelper.AddColour(circle);

ShapeColourHelper.AddColour(square);

Console.WriteLine(square.Colour);

ShapeColourHelper.ChangeColour(square);

Console.WriteLine(square.Colour);

//2. Checking the RandomColour methods of ShapeColourHelper
Console.WriteLine("\n\nTask 2: Demo\n");
Console.WriteLine("Old Sqaure color is: " + square.Colour);
ShapeColourHelper.RandomColour(square);
Console.WriteLine("New Sqaure color after RandomColour is: " + square.Colour);
ShapeColourHelper.RandomColour(square);
Console.WriteLine("New Sqaure color after RandomColour is: " + square.Colour);

//3. Using the Interface GetArea()
Console.WriteLine("\n\nTask 3: Demo\n");
IShape squareInterface = square;
Console.WriteLine("Area using Interface IShape GetArea() : " + squareInterface.GetArea());

//4. Extend the console application to generate an array of shapes that all have colours
Console.WriteLine("\n\nTask 4: Demo\n");

Shape[] shapeArray = { new Square(8), new Circle(3), new Triangle() };
Console.WriteLine("Created a shape array with square, circle, triangle");

foreach (Shape shape in shapeArray)
{
    ShapeColourHelper.RandomColour(shape);
}
foreach (Shape shape in shapeArray)
{
    if (shape.GetType() == typeof(Circle))
    {
        Console.WriteLine("Color of circle is : " + shape.Colour);
    }
    else if (shape.GetType() == typeof(Triangle))
    {
        Console.WriteLine("Color of Triangle is : " + shape.Colour);
    }
    else if (shape.GetType() == typeof(Square))
    {
        Console.WriteLine("Color of Square is : " + shape.Colour);
    }
}
Console.ReadLine();



