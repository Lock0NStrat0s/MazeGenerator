using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGenerator;

public class GenerateMaze
{
    public List<Cell> Cells { get; set; }
    public int Width { get; private set; }
    public int Height { get; private set; }

    public GenerateMaze(int width, int height)
    {
        Width = width;
        Height = height;
        Cells = new List<Cell>();

        for (int i = 0; i < Width; i++)
        {
            for (int j = 0; j < Height; j++)
            {
                Cells.Add(new Cell(i, j));  // Initialize all cells
            }
        }
    }

    public void DisplayMaze()
    {
        int i = 1;
        foreach (Cell cell in Cells)
        {
            Console.Write(cell.ToString());
            if (i++ % Width == 0)
            {
                Console.WriteLine();
            }
        }
    }
}
