namespace Algorithms
{
    using Grid;

    public class SearchDetails
    {
        public bool PathPossible => PathFound || OpenListSize > 0;
        public bool PathFound => Path != null;
        public Coord[] Path { get; set; }
        public int PathCost { get; set; }
        public Node LastNode { get; set; }
        public int DistanceOfCurrentNode { get; set; }
        public int OpenListSize { get; set; }
        public int ClosedListSize { get; set; }
        public int UnexploredListSize { get; set; }
        public int Operations { get; set; }
    }
}
