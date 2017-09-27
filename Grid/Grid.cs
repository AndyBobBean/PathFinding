namespace Grid
{
    using System;
    using System.Linq;
    using static Enums;

    public class Grid
    {
        private readonly Cell[,] _grid;
        public Grid(int horizontalCells, int verticalCells)
        {
            _grid = new Cell[horizontalCells, verticalCells];
            for (var x = 0; x < _grid.GetLength(0); x++)
            {
                for (var y = 0; y < _grid.GetLength(1); y++)
                {
                    SetCell(x, y, CellType.Empty);
                }
            }

            SetStartAndEnd();
        }

        public void Randomize()
        {
            Randomize((int)DateTime.Now.Ticks);
        }

        public void Randomize(int seed)
        {
            var rand = new Random(seed);
            for (var x = 0; x < _grid.GetLength(0); x++)
            {
                for (var y = 0; y < _grid.GetLength(1); y++)
                {
                    _grid[x, y].Type = rand.Next(0, 10) > 5 ? CellType.Solid : CellType.Empty;
                }
            }
            SetStartAndEnd();
        }

        public Cell GetCell(int x, int y)
        {
            if (x > _grid.GetLength(0) - 1 || x < 0 || y > _grid.GetLength(1) - 1 || y < 0) return new Cell { Coord = new Coord(-1, -1), Type = CellType.Invalid };

            return _grid[x, y];
        }

        public Cell GetStart()
        {
            return _grid.Cast<Cell>().FirstOrDefault(cell => cell.Type == CellType.A);
        }

        public Cell GetEnd()
        {
            return _grid.Cast<Cell>().FirstOrDefault(cell => cell.Type == CellType.B);
        }

        public void SetCell(int x, int y, CellType type)
        {
            _grid[x, y] = new Cell
            {
                Coord = new Coord(x, y),
                Type = type
            };

            SetStartAndEnd();
        }

        public int GetCountOfType(CellType type)
        {
            var total = 0;
            foreach (var cell in _grid)
            {
                total += cell.Type == type ? 1 : 0;
            }

            return total;
        }

        public int GetTraversableCells()
        {
            return GetCountOfType(CellType.Open) + GetCountOfType(CellType.A) + GetCountOfType(CellType.B);
        }

        private void SetStartAndEnd()
        {
            _grid[0, 0] = new Cell
            {
                Coord = new Coord(0, 0),
                Type = CellType.A
            };
            _grid[_grid.GetLength(0) - 1, _grid.GetLength(1) - 1] = new Cell
            {
                Coord = new Coord(_grid.GetLength(0) - 1, _grid.GetLength(1) - 1),
                Type = CellType.B
            };
        }
    }
}
