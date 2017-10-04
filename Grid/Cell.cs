namespace Grid
{
    using static Enums;

    public class Cell
    {
        public Coord Coord { get; set; }
        public CellType Type { get; set; }
        public int Weight { get; set; }
    }
}
