namespace GUI.Classes
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Grid;
    using static Grid.Enums;

    public class MazeDrawer
    {
        private readonly PictureBox _pb;
        public Grid Grid { get; }
        public int Seed { get; }

        private const int HorizontalCells = 30;
        private const int VerticalCells = 20;

        private int _cellWidth;
        private int _cellHeight;

        public MazeDrawer(PictureBox pb, int seed = 0)
        {
            _pb = pb;
            Grid = new Grid(HorizontalCells, VerticalCells);
            if (seed == 0) seed = (int)DateTime.Now.Ticks;
            Seed = seed;
            Grid.Randomize(seed);
        }

        public void Draw()
        {
            _cellWidth = _pb.Width / HorizontalCells;
            _cellHeight = _pb.Height / VerticalCells;

            var image = new Bitmap(_pb.Width, _pb.Height);

            using (var g = Graphics.FromImage(image))
            {
                var background = new Rectangle(0, 0, image.Width, image.Height);
                g.FillRectangle(new SolidBrush(Color.White), background);

                for (var x = 0; x < HorizontalCells; x++)
                {
                    for (var y = 0; y < VerticalCells; y++)
                    {
                        var cellType = Grid.GetCell(x, y).Type;
                        switch (cellType)
                        {
                            case CellType.Empty:
                                break;
                            case CellType.Solid:
                                g.FillRectangle(Brushes.Black, GetRectangle(x, y));
                                break;
                            case CellType.Path:
                                g.FillRectangle(Brushes.Green, GetRectangle(x, y));
                                break;
                            case CellType.Open:
                                g.FillRectangle(Brushes.LightSkyBlue, GetRectangle(x, y));
                                break;
                            case CellType.Closed:
                                g.FillRectangle(Brushes.LightGray, GetRectangle(x, y));
                                break;
                            case CellType.Current:
                                g.FillRectangle(Brushes.Crimson, GetRectangle(x, y));
                                break;
                            case CellType.A:
                                g.DrawString("A", GetFont(), Brushes.Red, GetPoint(x, y));
                                break;
                            case CellType.B:
                                g.DrawString("B", GetFont(), Brushes.Blue, GetPoint(x, y));
                                break;
                            default:
                                throw new ArgumentOutOfRangeException("Unknown cell type: " + cellType);
                        }

                        g.DrawRectangle(Pens.Black, GetRectangle(x, y));
                    }
                }

                _pb.Image = image;
            }
        }

        public void Reset()
        {
            Grid.Randomize(Seed);
        }

        private Rectangle GetRectangle(int x, int y)
        {
            return new Rectangle(x * _cellWidth, y * _cellHeight, _cellWidth, _cellHeight);
        }

        private PointF GetPoint(int x, int y)
        {
            return new PointF(x * _cellWidth, y * _cellHeight);
        }

        private Font GetFont()
        {
            return new Font(FontFamily.GenericMonospace, Math.Min(_cellWidth, _cellHeight) / 1.3f, FontStyle.Bold);
        }
    }
}
