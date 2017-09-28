namespace GUI
{
    using Classes;
    using System;
    using System.Windows.Forms;
    using Algorithms;
    using Grid;
    using System.Linq;

    public partial class Main : Form
    {
        public MazeDrawer MazeDrawer;
        public AlgorithmBase[] Algorithms;
        public int CurrentAlgorithm;
        public LabelCollection[] Labels = new LabelCollection[4];
        public Sounds SoundManager;
        public System.Timers.Timer PathTimer;
        public const int Delay = 5;

        public Main()
        {
            InitializeComponent();

            PathTimer = new System.Timers.Timer(Delay);
            PathTimer.Elapsed += PathTimer_Elapsed;
            SoundManager = new Sounds(Properties.Settings.Default.EnableSounds);
            SoundManager.LoadSounds();

            Labels[0] = new LabelCollection
            {
                AlgorithmId = 0,
                Labels = new Label[] { lblAlgorithm, lblDijkstraOperations, lblDijkstraUnexplored, lblDijkstraOpen, lblDijkstraClosed, lblDijkstraPathLength }
            };
            Labels[1] = new LabelCollection
            {
                AlgorithmId = 1,
                Labels = new Label[] { lblAlgorithm, lblAStarOperations, lblAStarUnexplored, lblAStarOpen, lblAStarClosed, lblAStarPathLength }
            };
            Labels[2] = new LabelCollection
            {
                AlgorithmId = 2,
                Labels = new Label[] { lblAlgorithm, lblBreadthFirstOperations, lblBreadthFirstUnexplored, lblBreadthFirstOpen, lblBreadthFirstClosed, lblBreadthFirstPathLength }
            };
            Labels[3] = new LabelCollection
            {
                AlgorithmId = 3,
                Labels = new Label[] { lblAlgorithm, lblDepthFirstOperations, lblDepthFirstUnexplored, lblDepthFirstOpen, lblDepthFirstClosed, lblDepthFirstPathLength }
            };

            InitialiseMaze();
        }

        private void InitialiseMaze()
        {
            PathTimer.Stop();

            var workingSeed = FindWorkingSeed();
            while (workingSeed == 0)
                workingSeed = FindWorkingSeed();

            CurrentAlgorithm = -1;
            MazeDrawer = new MazeDrawer(pbMaze, workingSeed);
            Algorithms = new AlgorithmBase[] { new Dijkstra(MazeDrawer.Grid), new AStar(MazeDrawer.Grid), new BreadthFirst(MazeDrawer.Grid), new DepthFirst(MazeDrawer.Grid) };
            Text = @"Path Finding " + MazeDrawer.Seed;
            MazeDrawer.Draw();
        }

        private int FindWorkingSeed()
        {
            var testMazeDrawer = new MazeDrawer(pbMaze);
            var testPathFinder = new DepthFirst(testMazeDrawer.Grid);
            var progress = testPathFinder.GetPathTick();
            while (progress.PathPossible && !progress.PathFound)
            {
                progress = testPathFinder.GetPathTick();
            }

            return progress.PathFound ? testMazeDrawer.Seed : 0;
        }

        private void PathTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            PathTimer.Stop();
            var resetTimer = false;

            var searchStatus = Algorithms[CurrentAlgorithm].GetPathTick();
            StatsUpdate(searchStatus);
            if (searchStatus.PathFound)
            {
                BuildPath(searchStatus);
            }
            else
            {
                MazeDrawer.Draw();
                
                SoundManager.PlaySound(searchStatus.DistanceOfCurrentNode);
                resetTimer = true;
            }

            if (resetTimer) PathTimer.Start();
        }

        private void BuildPath(SearchDetails details)
        {
            for (var i = 1; i < details.Path.Length - 1; i++)
            {
                var step = details.Path[i];
                MazeDrawer.Grid.SetCell(step.X, step.Y, Enums.CellType.Path);
                MazeDrawer.Draw();
                SoundManager.PlaySound(details.Path.Length - i);
                System.Threading.Thread.Sleep(25);
            }

            SoundManager.PlaySound(50);
        }

        private void StatsUpdate(SearchDetails details)
        {
            var labelCollection = Labels.First(x => x.AlgorithmId == CurrentAlgorithm);

            labelCollection.Labels[0].BeginInvoke((MethodInvoker)delegate { labelCollection.Labels[0].Text = @"Algorithm: " + Algorithms[CurrentAlgorithm].AlgorithmName; });
            labelCollection.Labels[1].BeginInvoke((MethodInvoker)delegate { labelCollection.Labels[1].Text = details.Operations.ToString(); });
            labelCollection.Labels[2].BeginInvoke((MethodInvoker)delegate { labelCollection.Labels[2].Text = details.UnexploredListSize.ToString(); });
            labelCollection.Labels[3].BeginInvoke((MethodInvoker)delegate { labelCollection.Labels[3].Text = details.OpenListSize.ToString(); });
            labelCollection.Labels[4].BeginInvoke((MethodInvoker)delegate { labelCollection.Labels[4].Text = details.ClosedListSize.ToString(); });
            labelCollection.Labels[5].BeginInvoke((MethodInvoker)delegate { labelCollection.Labels[5].Text = details.PathFound ? details.Path.Length.ToString() : "?"; });
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            CurrentAlgorithm++;
            if (CurrentAlgorithm == Algorithms.Length) return;
            MazeDrawer.Reset();

            PathTimer.Start();
        }

        private void btnMaze_Click(object sender, EventArgs e)
        {
            InitialiseMaze();
        }
    }
}
