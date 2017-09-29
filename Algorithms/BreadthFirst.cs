namespace Algorithms
{
    using Grid;
    using System.Collections.Generic;
    using System.Linq;

    public class BreadthFirst : AlgorithmBase
    {
        private readonly Queue<Node> _q = new Queue<Node>();
        private bool _destinationFound;

        public BreadthFirst(Grid grid) : base (grid)
        {
            AlgorithmName = "Breadth-First Search";
            _q.Enqueue(new Node(Id++, null, Origin, 0, 0));
        }

        public override SearchDetails GetPathTick()
        {
            if (_q.Count > 0 && !_destinationFound)
            {
                CurrentNode = _q.Dequeue();
                if (AlreadyVisited(CurrentNode.Coord)) return GetSearchDetails();

                Closed.Add(CurrentNode);
                Grid.SetCell(CurrentNode.Coord.X, CurrentNode.Coord.Y, Enums.CellType.Closed);

                var neighbours = GetNeighbours(CurrentNode);
                foreach (var neighbour in neighbours)
                {
                    if (AlreadyVisited(neighbour)) continue;

                    var neighbourNode = new Node(Id++, CurrentNode.Id, neighbour.X, neighbour.Y, 0, 0);
                    _q.Enqueue(neighbourNode);
                    Grid.SetCell(neighbour, Enums.CellType.Open);

                    if (!CoordsMatch(neighbour, Destination)) continue;

                    Closed.Add(neighbourNode);
                    _destinationFound = true;
                }
            }
            else
            {
                Path = new List<Coord>();

                var step = Closed.First(x => CoordsMatch(x.Coord, Destination));
                while (!CoordsMatch(step.Coord, Origin))
                {
                    Path.Add(step.Coord);
                    step = Closed.First(x => x.Id == step.ParentId);
                }

                Path.Add(Origin);
                Path.Reverse();
            }

            return GetSearchDetails();
        }

        private bool AlreadyVisited(Coord coord)
        {
            return Closed.Any(x => CoordsMatch(x.Coord, coord));
        }

        protected override SearchDetails GetSearchDetails()
        {
            return new SearchDetails
            {
                Path = Path?.ToArray(),
                LastNode = CurrentNode,
                DistanceOfCurrentNode = CurrentNode == null ? 0 : GetManhattenDistance(CurrentNode.Coord, Destination),
                OpenListSize = _q.Count,
                ClosedListSize = Closed.Count,
                UnexploredListSize = Grid.GetCountOfType(Enums.CellType.Empty),
                Operations = Operations++
            };
        }
    }
}
