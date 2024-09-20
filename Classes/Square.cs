
using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public class Square : Shape, IFaces, IShape
    {
        private int side;

        public Square(int s) 
        {
            
            if (s > 10)
            {
                throw new Exception("Cannot be greater then 10");
            }

            side = s;
        }

        public Square() { }

        public void SetSide(int s)
        {
            side = s;
        }

        public override double GetArea()
        {
            return side * side; 
        }

        public int GetFaces()
        {
            throw new NotImplementedException();
        }

        //3. Implement IShape GetArea() if not implemented Shape class GetArea is considered
        double IShape.GetArea()
        {
            Console.WriteLine("Interface GetArea() called");
            return side * side;
        }
        public readonly int Sides;

    }
}
