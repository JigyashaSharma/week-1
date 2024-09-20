using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public class Circle : Shape, IShape
    {
        //1.Creating radius property
        public double Radius { get; set; }

        //1. Creating default constructor to use the object initializer
        public Circle() { }
        //Parameterized constructor
        public Circle(double r)
        {
            Radius = r;
        }

        //1. Extend the circle class so that it also implements the GetArea()
        //changing int to double return type for Math.PI
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        //3.Implementing IShape GetArea()
        double IShape.GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

}
