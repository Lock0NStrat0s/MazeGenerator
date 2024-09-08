namespace MazeGenerator;

public class Cell
{
    public int X { get; set; }  // X position in the grid
    public int Y { get; set; }  // Y position in the grid
    public bool IsWall { get; set; }    // Whether the cell is a wall
    public bool IsVisited { get; set; } // Whether the cell has been visited
    public bool IsPartOfSolution { get; set; }  // Part of the solution path

    public Cell(int x, int y, bool isWall = false)
    {
        X = x;
        Y = y;
        IsWall = isWall;
        IsVisited = false;
        IsPartOfSolution = false;
    }

    public override string ToString()
    {
        if (IsPartOfSolution)
            return ".";
        else if (IsWall)
            return "#";
        else
            return " ";
    }
}
