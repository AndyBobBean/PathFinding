namespace Algorithms
{
    using Grid;

    public class BreadthFirst : AlgorithmBase
    {
        public BreadthFirst(Grid grid) : base (grid)
        {
            AlgorithmName = "Breadth-First Search";
        }

        public override SearchDetails GetPathTick()
        {
            throw new System.NotImplementedException();
        }

        protected override SearchDetails GetSearchDetails()
        {
            throw new System.NotImplementedException();
        }
    }
}
