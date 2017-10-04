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

            // Add the first node to the queue
            _q.Enqueue(new Node(Id++, null, Origin, 0, 0));
        }

        public override SearchDetails GetPathTick()
        {
            // If there are still nodes on the queue and the destination hasn't been found, evaluate the next node.
            if (_q.Count > 0 && !_destinationFound)
            {
                // Get the next node in the queue and check it hasn't already been visited
                CurrentNode = _q.Dequeue();
                if (AlreadyVisited(CurrentNode.Coord)) return GetSearchDetails();

                // Add node to those already visited
                Closed.Add(CurrentNode);
                Grid.SetCell(CurrentNode.Coord.X, CurrentNode.Coord.Y, Enums.CellType.Closed);

                // Go through the neighbours of this node and add the new ones to the queue
                var neighbours = GetNeighbours(CurrentNode);
                foreach (var neighbour in neighbours)
                {
                    if (AlreadyVisited(neighbour)) continue;

                    var neighbourNode = new Node(Id++, CurrentNode.Id, neighbour.X, neighbour.Y, 0, 0);
                    _q.Enqueue(neighbourNode);
                    Grid.SetCell(neighbour, Enums.CellType.Open);

                    if (!CoordsMatch(neighbour, Destination)) continue;

                    // Check if we've found the destination
                    Closed.Add(neighbourNode);
                    _destinationFound = true;
                }
            }
            else
            {
                // The path has been found, reconstruct it be following back via the parentId's and reverse the order so it goes from A to B
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
                PathCost = GetPathCost(),
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
