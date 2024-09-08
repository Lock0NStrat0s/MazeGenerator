namespace MazeGenerator;

public class GameManager
{
    int cols, rows;

    public void Setup()
    {
        GenerateMaze newMaze = new GenerateMaze(10, 10);

        newMaze.DisplayMaze();
    }
}