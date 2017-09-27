namespace GUI
{
    using Classes;
    using System;
    using System.Windows.Forms;
    using Algorithms;
    using Grid;

    public partial class Main : Form
    {
        public MazeDrawer MazeDrawer;
        public AlgorithmBase[] Algorithms;
        public int CurrentAlgorithm;
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
            Algorithms = new AlgorithmBase[] { new AStar(MazeDrawer.Grid), new Dijkstra(MazeDrawer.Grid) };
            Text = @"Path Finding " + MazeDrawer.Seed;
            MazeDrawer.Draw();
        }

        private int FindWorkingSeed()
        {
            var testMazeDrawer = new MazeDrawer(pbMaze);
            var testAStar = new AStar(testMazeDrawer.Grid);
            var progress = testAStar.GetPathTick();
            while (progress.PathPossible && !progress.PathFound)
            {
                progress = testAStar.GetPathTick();
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
            lblAlgorithm.BeginInvoke((MethodInvoker)delegate { lblAlgorithm.Text = @"Algorithm: " + Algorithms[CurrentAlgorithm].AlgorithmName; });
            lblOperations.BeginInvoke((MethodInvoker)delegate { lblOperations.Text = Helpers.FormatStats("Operations", details.Operations); });
            lblUnexplored.BeginInvoke((MethodInvoker)delegate { lblUnexplored.Text = Helpers.FormatStats("Unexplored", details.UnexploredListSize); });
            lblOpen.BeginInvoke((MethodInvoker)delegate { lblOpen.Text = Helpers.FormatStats("Open List Size", details.OpenListSize); });
            lblClosed.BeginInvoke((MethodInvoker)delegate { lblClosed.Text = Helpers.FormatStats("Closed List Size", details.ClosedListSize); });
            lblPath.BeginInvoke((MethodInvoker)delegate { lblPath.Text = Helpers.FormatStats("Path Length", details.PathFound ? details.Path.Length : (int?)null); });
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
