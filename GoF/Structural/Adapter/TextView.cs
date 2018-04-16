namespace Adapter
{
    public class Coord
    {
        public int coord { get; set; }
    }
    public class TextView
    {
        private int xOrigin;
        private int yOrigin;

        private int width;
        private int height;

        public TextView(int x, int y, int width, int height)
        {
            this.xOrigin = x;
            this.yOrigin = y;
            this.width = width;
            this.height = height;
        }

        public void getOrigin(Coord x, Coord y)
        {
            x.coord = xOrigin;
            y.coord = yOrigin;
        }

        public void getExtent(Coord width, Coord height)
        {
            width.coord = this.width;
            height.coord = this.height;
        }
    }
}