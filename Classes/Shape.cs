
namespace Week1ObjectOriented.Classes
{
    public abstract class Shape
    {
        private double area;

        public abstract double GetArea();
       

        public void SetArea(double Area)
        {
            area = Area;
        }

        public string? Colour { get; set; }
    }
}
