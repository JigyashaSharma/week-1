// See https://aka.ms/new-console-template for more information
using Week1ObjectOriented.Classes;

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

Console.ReadLine();




