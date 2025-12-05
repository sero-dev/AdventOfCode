namespace AdventOfCode.Problem.Year2025.Day04;

public class Problem01 : ProblemSolver
{
    public Problem01() : base(2025, 4, 1) {}

    public override long Solve(string[] lines)
    {
        bool[][] grid = new bool[lines.Length][];
        var count = 0;

        for (int i = 0; i < lines.Length; i++)
        {
            var row = new bool[lines[i].Length];
            for (int j = 0; j < lines[i].Length; j++)
            {
                row[j] = lines[i][j] == '@';
            }

            grid[i] = row;
        }

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j])
                {
                    var rollsInPerimeter = 0;
                    
                    if (i > 0 && j > 0 && grid[i - 1][j - 1]) rollsInPerimeter++;
                    if (i > 0 && grid[i - 1][j]) rollsInPerimeter++;
                    if (i > 0 && j < grid[i].Length - 1 && grid[i - 1][j + 1]) rollsInPerimeter++;

                    if (j > 0 && grid[i][j - 1]) rollsInPerimeter++;

                    if (j < grid[i].Length - 1 && grid[i][j + 1]) rollsInPerimeter++;

                    if (i < grid.Length - 1 && j > 0 && grid[i + 1][j - 1]) rollsInPerimeter++;
                    if (i < grid.Length - 1 && grid[i + 1][j]) rollsInPerimeter++;
                    if (i < grid.Length - 1 && j < grid[i].Length - 1 && grid[i + 1][j + 1]) rollsInPerimeter++;

                    if (rollsInPerimeter < 4)
                    {
                        count++;
                    }
                }
            }
        }

        return count;
    }
}
