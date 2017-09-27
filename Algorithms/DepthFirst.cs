namespace Algorithms
{
    using Grid;
    using System.Collections.Generic;
    using System.Linq;

    public class DepthFirst : AlgorithmBase
    {
        readonly Stack<Node> _stack = new Stack<Node>();
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
            /*
             * https://channel9.msdn.com/coding4fun/blog/Getting-lost-and-found-with-the-C-Maze-Generator-and-Solver
            */
            var visited = new HashSet<Node>();

            while (_stack.Count > 0)
            {
                _currentNode = _stack.Pop();

                if (visited.Contains(_currentNode))
                    continue;

                visited.Add(_currentNode);

                foreach (var neighbour in GetNeighbours(_currentNode))
                {
                    if (!visited.Any(x => x.Coord.X == neighbour.X && x.Coord.Y == neighbour.Y))
                    {
                        _stack.Push(new Node(_id++, null, neighbour.X, neighbour.Y, 0, 0));
                    }
                }
            }

            return GetSearchDetails();
        }

        protected override SearchDetails GetSearchDetails()
        {
            throw new System.NotImplementedException();
        }

        /*
         *         private int time; 
        private int[] pi; 
 
        private void DFSVisit(Node u) 
        { 
            u.Color = Colors.GRAY; 
            u.Discovery = ++time; 
 
            if (u.Adjacency != null) 
            { 
                for (int i = 0; i < u.Adjacency.Count; i++) 
                { 
                    Node v = u.Adjacency[i]; 
 
                    if (v.Color == Colors.WHITE) 
                    { 
                        pi[v.Id] = u.Id; 
                        DFSVisit(v); 
                    } 
                } 
 
            } 
 
            u.Color = Colors.BLACK; 
            u.Finish = ++time; 
        } 
 
        public void DFS(List<Node> G) 
        { 
            pi = new int[G.Count]; 
 
            for (int i = 0; i < G.Count; i++) 
            { 
                Node u = G[i]; 
 
                u.Color = Colors.WHITE; 
                pi[u.Id] = -1; 
            } 
 
            time = 0; 
 
            for (int i = 0; i < G.Count; i++) 
            { 
                Node u = G[i]; 
 
                if (u.Color == Colors.WHITE) 
                    DFSVisit(u); 
            } 
        }
        */
    }
}
