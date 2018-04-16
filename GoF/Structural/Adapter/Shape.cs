namespace Adapter
{
    public class Point
    {
        public int x;
        public int y;
    }
    public interface Shape
    {
        void boundingBox(Point bottomLeft, Point topRight);
        void createManipulator();
    }
}