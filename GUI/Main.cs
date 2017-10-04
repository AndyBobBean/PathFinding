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
        private MazeDrawer _mazeDrawer;
        private AlgorithmBase[] _algorithms;
        private int _currentAlgorithm;
        private readonly LabelCollection[] _labels = new LabelCollection[4];
        private readonly Sounds _soundManager;
        private readonly System.Timers.Timer _pathTimer;
        private const int Delay = 5;

        public Main()
        {
            InitializeComponent();

            _pathTimer = new System.Timers.Timer(Delay);
            _pathTimer.Elapsed += PathTimer_Elapsed;
            _soundManager = new Sounds(Properties.Settings.Default.EnableSounds);
            _soundManager.LoadSounds();

            _labels[0] = new LabelCollection
            {
                AlgorithmId = 0,
                Labels = new[] { lblAlgorithm, lblDijkstraOperations, lblDijkstraUnexplored, lblDijkstraOpen, lblDijkstraClosed, lblDijkstraPathLength }
            };
            _labels[1] = new LabelCollection
            {
                AlgorithmId = 1,
                Labels = new[] { lblAlgorithm, lblAStarOperations, lblAStarUnexplored, lblAStarOpen, lblAStarClosed, lblAStarPathLength }
            };
            _labels[2] = new LabelCollection
            {
                AlgorithmId = 2,
                Labels = new[] { lblAlgorithm, lblBreadthFirstOperations, lblBreadthFirstUnexplored, lblBreadthFirstOpen, lblBreadthFirstClosed, lblBreadthFirstPathLength }
            };
            _labels[3] = new LabelCollection
            {
                AlgorithmId = 3,
                Labels = new[] { lblAlgorithm, lblDepthFirstOperations, lblDepthFirstUnexplored, lblDepthFirstOpen, lblDepthFirstClosed, lblDepthFirstPathLength }
            };

            InitialiseMaze();
        }

        private void InitialiseMaze()
        {
            _pathTimer.Stop();

            var workingSeed = FindWorkingSeed();
            while (workingSeed == 0)
                workingSeed = FindWorkingSeed();

            _currentAlgorithm = -1;
            _mazeDrawer = new MazeDrawer(pbMaze, workingSeed);
            _algorithms = new AlgorithmBase[] { new Dijkstra(_mazeDrawer.Grid), new AStar(_mazeDrawer.Grid), new BreadthFirst(_mazeDrawer.Grid), new DepthFirst(_mazeDrawer.Grid) };
            Text = @"Path Finding " + _mazeDrawer.Seed;
            _mazeDrawer.Draw();
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
            _pathTimer.Stop();
            var resetTimer = false;

            var searchStatus = _algorithms[_currentAlgorithm].GetPathTick();
            StatsUpdate(searchStatus);
            if (searchStatus.PathFound)
            {
                BuildPath(searchStatus);
            }
            else
            {
                _mazeDrawer.Draw();
                
                _soundManager.PlaySound(searchStatus.DistanceOfCurrentNode);
                resetTimer = true;
            }

            if (resetTimer) _pathTimer.Start();
        }

        private void BuildPath(SearchDetails details)
        {
            for (var i = 1; i < details.Path.Length - 1; i++)
            {
                var step = details.Path[i];
                _mazeDrawer.Grid.SetCell(step.X, step.Y, Enums.CellType.Path);
                _mazeDrawer.Draw();
                _soundManager.PlaySound(details.Path.Length - i);
                System.Threading.Thread.Sleep(25);
            }

            _soundManager.PlaySound(50);
        }

        private void StatsUpdate(SearchDetails details)
        {
            var labelCollection = _labels.First(x => x.AlgorithmId == _currentAlgorithm);

            labelCollection.Labels[0].BeginInvoke((MethodInvoker)delegate { labelCollection.Labels[0].Text = @"Algorithm: " + _algorithms[_currentAlgorithm].AlgorithmName; });
            labelCollection.Labels[1].BeginInvoke((MethodInvoker)delegate { labelCollection.Labels[1].Text = details.Operations.ToString(); });
            labelCollection.Labels[2].BeginInvoke((MethodInvoker)delegate { labelCollection.Labels[2].Text = details.UnexploredListSize.ToString(); });
            labelCollection.Labels[3].BeginInvoke((MethodInvoker)delegate { labelCollection.Labels[3].Text = details.OpenListSize.ToString(); });
            labelCollection.Labels[4].BeginInvoke((MethodInvoker)delegate { labelCollection.Labels[4].Text = details.ClosedListSize.ToString(); });
            labelCollection.Labels[5].BeginInvoke((MethodInvoker)delegate { labelCollection.Labels[5].Text = details.PathFound ? $"{details.Path.Length}/{details.PathCost}" : "?/?"; });
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            _currentAlgorithm++;
            if (_currentAlgorithm == _algorithms.Length) return;
            _mazeDrawer.Reset();

            _pathTimer.Start();
        }

        private void BtnMaze_Click(object sender, EventArgs e)
        {
            InitialiseMaze();
        }
    }
}
