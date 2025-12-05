namespace AdventOfCode.Problem.Year2025.Day04;

public class Problem01Count : ProblemSolver
{
    public Problem01Count() : base(2025, 4, 1) {}

    public override long Solve(string[] lines)
    {
        var count = lines.Length * lines[0].Length;

        int[][] grid = new int[lines.Length][];

        for (int i = 0; i < lines.Length; i++)
        {
            grid[i] = new int[lines[i].Length];
        }

        for (int row = 0; row < lines.Length; row++)
        {
            for (int col = 0; col < lines[row].Length; col++)
            {
                if (lines[row][col] != '@')
                {
                    count--;
                    continue;
                }

                var firstRow = row == 0;
                var firstCol = col == 0;
                var lastRow = row == grid.Length - 1;
                var lastCol = col == grid[row].Length - 1;

                if (!firstRow && !firstCol && lines[row - 1][col - 1] == '@' ) 
                {
                    grid[row - 1][col - 1]++;
                    if (grid[row - 1][col - 1] == 4)
                        count--;
                }

                if (!firstRow && lines[row - 1][col] == '@')
                {
                    grid[row - 1][col]++;
                    if (grid[row - 1][col] == 4) 
                        count--;
                }

                if (!firstRow && !lastCol && lines[row - 1][col + 1] == '@')
                {
                    
                    grid[row - 1][col + 1]++;
                    if (grid[row - 1][col + 1] == 4)
                        count--;
                }

                if (!firstCol && lines[row][col - 1] == '@')
                {
                    grid[row][col - 1]++;
                    if (grid[row][col - 1] == 4)
                        count--;    
                }

                if (!lastCol && lines[row][col + 1] == '@')
                {
                    grid[row][col + 1]++;
                    if (grid[row][col + 1] == 4)
                    {
                        count--;
                    }
                }

                if (!lastRow && !firstCol && lines[row + 1][col - 1] == '@') 
                {
                    grid[row + 1][col - 1]++;
                    if (grid[row + 1][col - 1] == 4)
                        count--;
                }

                if (!lastRow && lines[row + 1][col] == '@') 
                {
                    grid[row + 1][col]++;
                    if (grid[row + 1][col] == 4)
                        count--;
                }

                if (!lastRow && !lastCol && lines[row + 1][col + 1] == '@') 
                {
                    grid[row + 1][col + 1]++;
                    if (grid[row + 1][col + 1] == 4)
                        count--;
                }
            }
        }
        return count;
    }
}
