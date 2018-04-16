using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape textShape = new TextShape(0, 0, 10, 15);
            Point bottomLeft = new Point();
            Point topRight = new Point();
            
            textShape.boundingBox(bottomLeft, topRight);
            Console.WriteLine("Bottom left (x, y): " + bottomLeft.x + " " + bottomLeft.y);
            Console.WriteLine("Top right (x, y): " + topRight.x + " " + topRight.y);
            textShape.createManipulator();
        }
    }
}
