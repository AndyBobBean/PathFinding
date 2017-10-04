﻿namespace Algorithms
{
    using Grid;
    using System.Collections.Generic;
    using System.Linq;

    public class AStar : AlgorithmBase
    {
        private readonly List<Node> _openList = new List<Node>();
        private readonly List<Coord> _neighbours;

        public AStar(Grid grid) : base(grid)
        {
            AlgorithmName = "A*";
            _neighbours = new List<Coord>();

            // Put the origin on the open list
            _openList.Add(new Node(Id++, null, Origin, 0, GetH(Origin, Destination)));
        }

        public override SearchDetails GetPathTick()
        {
            if (CurrentNode == null)
            {
                if (!_openList.Any()) return GetSearchDetails();

                // Take the current node off the open list to be examined
                CurrentNode = _openList.OrderBy(x => x.F).ThenBy(x => x.H).First();

                // Move it to the closed list so it doesn't get examined again
                _openList.Remove(CurrentNode);
                Closed.Add(CurrentNode);
                Grid.SetCell(CurrentNode.Coord, Enums.CellType.Closed);

                _neighbours.AddRange(GetNeighbours(CurrentNode));
            }

            if (_neighbours.Any())
            {
                Grid.SetCell(CurrentNode.Coord, Enums.CellType.Current);

                var thisNeighbour = _neighbours.First();
                _neighbours.Remove(thisNeighbour);

                // If the neighbour is the destination
                if (CoordsMatch(thisNeighbour, Destination))
                {
                    // Construct the path by tracing back through the closed list until there are no more parent id references
                    Path = new List<Coord> { thisNeighbour };
                    int? parentId = CurrentNode.Id;
                    while (parentId.HasValue)
                    {
                        var nextNode = Closed.First(x => x.Id == parentId);
                        Path.Add(nextNode.Coord);
                        parentId = nextNode.ParentId;
                    }

                    // Reorder the path to be from origin to destination and return
                    Path.Reverse();

                    return GetSearchDetails();
                }

                // Get the cost of the current node plus the extra step weight and heuristic
                var hFromHere = GetH(thisNeighbour, Destination);
                var cellWeight = Grid.GetCell(thisNeighbour.X, thisNeighbour.Y).Weight;
                var neighbourCost = CurrentNode.G + cellWeight + hFromHere;

                // Check if the node is on the open list already and if it has a higher cost path
                var openListItem = _openList.FirstOrDefault(x => x.Id == GetExistingNode(true, thisNeighbour));
                if (openListItem != null && openListItem.F > neighbourCost)
                {
                    // Repoint the openlist node to use this lower cost path
                    openListItem.F = neighbourCost;
                    openListItem.ParentId = CurrentNode.Id;
                }

                // Check if the node is on the closed list already and if it has a higher cost path
                var closedListItem = Closed.FirstOrDefault(x => x.Id == GetExistingNode(false, thisNeighbour));
                if (closedListItem != null && closedListItem.F > neighbourCost)
                {
                    // Repoint the closedlist node to use this lower cost path
                    closedListItem.F = neighbourCost;
                    closedListItem.ParentId = CurrentNode.Id;
                }

                // If the neighbour node isn't on the open or closed list, add it
                if (openListItem != null || closedListItem != null) return GetSearchDetails();
                _openList.Add(new Node(Id++, CurrentNode.Id, thisNeighbour, CurrentNode.G + cellWeight, hFromHere));
                Grid.SetCell(thisNeighbour.X, thisNeighbour.Y, Enums.CellType.Open);
            }
            else
            {
                Grid.SetCell(CurrentNode.Coord, Enums.CellType.Closed);
                CurrentNode = null;
                return GetPathTick();
            }

            return GetSearchDetails();
        }

        private static int GetH(Coord origin, Coord destination)
        {
            return GetManhattenDistance(origin, destination);
        }

        private int? GetExistingNode(bool checkOpenList, Coord coordToCheck)
        {
            return checkOpenList ? _openList.FirstOrDefault(x => CoordsMatch(x.Coord, coordToCheck))?.Id : Closed.FirstOrDefault(x => CoordsMatch(x.Coord, coordToCheck))?.Id;
        }

        protected override SearchDetails GetSearchDetails()
        {
            return new SearchDetails
            {
                Path = Path?.ToArray(),
                PathCost = GetPathCost(),
                LastNode = CurrentNode,
                DistanceOfCurrentNode = CurrentNode == null ? 0 : GetH(CurrentNode.Coord, Destination),
                OpenListSize = _openList.Count,
                ClosedListSize = Closed.Count,
                UnexploredListSize = Grid.GetCountOfType(Enums.CellType.Empty),
                Operations = Operations++
            };
        }
    }
}
