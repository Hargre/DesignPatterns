using System;

namespace Adapter
{
    public class TextShape : TextView, Shape
    {
        public TextShape(int x, int y, int width, int height) : base(x, y, width, height) {}

        public void boundingBox(Point bottomLeft, Point topRight)
        {
            Coord xOrigin, yOrigin, width, height;
            xOrigin = new Coord();
            yOrigin = new Coord();
            width = new Coord();
            height = new Coord();

            getOrigin(xOrigin, yOrigin);
            getExtent(width, height);

            bottomLeft.x = xOrigin.coord;
            bottomLeft.y = yOrigin.coord;

            topRight.x = xOrigin.coord + width.coord;
            topRight.y = yOrigin.coord + height.coord;
        }
        
        public void createManipulator()
        {
            Console.WriteLine("Shape manipulator");
        }
    }
}