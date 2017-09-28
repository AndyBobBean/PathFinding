namespace Algorithms
{
    using Grid;

    public class Node
    {
        public Node(int id, int? parentId, int x, int y, int g, int h)
        {
            Id = id;
            ParentId = parentId;
            Coord = new Coord(x, y);
            G = g;
            H = h;
            F = G + H;
        }

        public Node(int id, int? parentId, Coord coord, int g, int h)
        {
            Id = id;
            ParentId = parentId;
            Coord = coord;
            G = g;
            H = h;
            F = G + H;
        }

        public int Id { get; set; }
        public int? ParentId { get; set; }
        public Coord Coord { get; set; }
        public int F { get; set; }
        public int G { get; set; }
        public int H { get; set; }
    }
}
