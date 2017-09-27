namespace Algorithms
{
    using Grid;
    using System.Collections.Generic;
    using System.Linq;

    public class DepthFirst : AlgorithmBase
    {
        readonly Stack<Node> _stack = new Stack<Node>();
        private List<Node> _closed = new List<Node>();
        private readonly Coord _destination;
        private int _id;
        private Node _currentNode;

        public DepthFirst(Grid grid) : base (grid)
        {
            AlgorithmName = "Depth-First Search";
            var origin = Grid.GetStart().Coord;
            _destination = Grid.GetEnd().Coord;
            _id = 1;

            _stack.Push(new Node(_id++, null, origin.X, origin.Y, 0, 0));
        }

        public override SearchDetails GetPathTick()
        {
            _currentNode = _stack.Peek();
            if (CoordsMatch(_currentNode.Coord, _destination))
            {
                Path = new List<Coord>();
                foreach (var item in _stack)
                    Path.Add(item.Coord);

                Path.Reverse();

                return GetSearchDetails();
            }

            var neighbours = GetNeighbours(_currentNode).Where(x => !AlreadyVisited(new Coord(x.X, x.Y))).ToArray();
            if (neighbours.Any())
            {
                foreach (var neighbour in neighbours)
                    Grid.SetCell(neighbour.X, neighbour.Y, Enums.CellType.Open);

                var next = neighbours.First();
                var newNode = new Node(_id++, null, next.X, next.Y, 0, 0);
                _stack.Push(newNode);
                Grid.SetCell(newNode.Coord.X, newNode.Coord.Y, Enums.CellType.Current);
            }
            else
            {
                var abandonedCell = _stack.Pop();
                Grid.SetCell(abandonedCell.Coord.X, abandonedCell.Coord.Y, Enums.CellType.Closed);
                _closed.Add(abandonedCell);
            }

            return GetSearchDetails();
        }

        private bool AlreadyVisited(Coord coord)
        {
            return _stack.Any(x => CoordsMatch(x.Coord, coord)) || _closed.Any(x => CoordsMatch(x.Coord, coord));
        }

        protected override SearchDetails GetSearchDetails()
        {
            return new SearchDetails
            {
                Path = Path?.ToArray(),
                LastNode = _currentNode,
                DistanceOfCurrentNode = _currentNode == null ? 0 : GetManhattenDistance(_currentNode.Coord, _destination),
                OpenListSize = _stack.Count,
                ClosedListSize = _closed.Count,
                UnexploredListSize = Grid.GetCountOfType(Enums.CellType.Empty),
                Operations = Operations++
            };
        }
    }
}
