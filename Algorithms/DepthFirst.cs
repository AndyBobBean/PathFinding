namespace Algorithms
{
    using Grid;
    using System.Collections.Generic;
    using System.Linq;

    public class DepthFirst : AlgorithmBase
    {
        readonly Stack<Node> _stack = new Stack<Node>();

        public DepthFirst(Grid grid) : base (grid)
        {
            AlgorithmName = "Depth-First Search";

            // Add the first node to the stack
            _stack.Push(new Node(Id++, null, Origin, 0, 0));
        }

        public override SearchDetails GetPathTick()
        {
            // Check the next node on the stack to see if it is the destination
            CurrentNode = _stack.Peek();
            if (CoordsMatch(CurrentNode.Coord, Destination))
            {
                // All the items on the stack will be the path so add them and reverse the order
                Path = new List<Coord>();
                foreach (var item in _stack)
                    Path.Add(item.Coord);

                Path.Reverse();

                return GetSearchDetails();
            }

            // Get all the neighbours that haven't been visited
            var neighbours = GetNeighbours(CurrentNode).Where(x => !AlreadyVisited(new Coord(x.X, x.Y))).ToArray();
            if (neighbours.Any())
            {
                foreach (var neighbour in neighbours)
                    Grid.SetCell(neighbour.X, neighbour.Y, Enums.CellType.Open);

                // Take this neighbour and add it the stack
                var next = neighbours.First();
                var newNode = new Node(Id++, null, next.X, next.Y, 0, 0);
                _stack.Push(newNode);
                Grid.SetCell(newNode.Coord.X, newNode.Coord.Y, Enums.CellType.Current);
            }
            else
            {
                // Remove this unused node from the stack and add it to the closed list
                var abandonedCell = _stack.Pop();
                Grid.SetCell(abandonedCell.Coord.X, abandonedCell.Coord.Y, Enums.CellType.Closed);
                Closed.Add(abandonedCell);
            }

            return GetSearchDetails();
        }

        private bool AlreadyVisited(Coord coord)
        {
            return _stack.Any(x => CoordsMatch(x.Coord, coord)) || Closed.Any(x => CoordsMatch(x.Coord, coord));
        }

        protected override SearchDetails GetSearchDetails()
        {
            return new SearchDetails
            {
                Path = Path?.ToArray(),
                PathCost = GetPathCost(),
                LastNode = CurrentNode,
                DistanceOfCurrentNode = CurrentNode == null ? 0 : GetManhattenDistance(CurrentNode.Coord, Destination),
                OpenListSize = _stack.Count,
                ClosedListSize = Closed.Count,
                UnexploredListSize = Grid.GetCountOfType(Enums.CellType.Empty),
                Operations = Operations++
            };
        }
    }
}
