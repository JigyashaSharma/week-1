
using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public static class ShapeColourHelper
    {

        public static Shape AddColour(Shape s)
        {
            s.Colour = "Red";

            return s;
        }

        public static Shape ChangeColour(Shape s)
        {
            s.Colour = "Blue";

            return s;
        }

        //2. Extend the ShapeColourHelper static class so that it can make a shape a random colour from Yellow, Red, Blue, Green or Orange.
        // using random class
        public static void RandomColour(Shape s)
        {
            string[] colourList = { "Yellow", "Red", "Blue", "Green", "Orange" };

            Random rand = new Random();
            string? oldColour = s.Colour;

            //Making sure it selects some new colour to differentiate
            while (s.Colour == oldColour)
            {
                s.Colour = colourList[rand.Next(colourList.Length)];
            }
        }
    }
}
