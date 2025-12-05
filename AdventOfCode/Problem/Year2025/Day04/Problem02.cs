namespace AdventOfCode.Problem.Year2025.Day04;

public class Problem02 : ProblemSolver
{
    public Problem02() : base(2025, 4, 2) {}

    public override long Solve(string[] lines)
    {
        var count = 0;

        int[][] grid = new int[lines.Length][];

        for (int row = 0; row < lines.Length; row++)
        {
            grid[row] = new int[lines[row].Length];
            for (int col = 0; col < lines[row].Length; col++)
            {
                if (lines[row][col] != '@')
                {
                    grid[row][col] = -1;
                    continue;
                }

                var firstRow = row == 0;
                var firstCol = col == 0;
                var lastRow = row == grid.Length - 1;
                var lastCol = col == grid[row].Length - 1;

                if (!firstRow && !firstCol && lines[row - 1][col - 1] == '@') grid[row][col]++; 
                if (!firstRow && lines[row - 1][col] == '@') grid[row][col]++;
                if (!firstRow && !lastCol && lines[row - 1][col + 1] == '@') grid[row][col]++;

                if (!firstCol && lines[row][col - 1] == '@') grid[row][col]++;
                if (!lastCol && lines[row][col + 1] == '@') grid[row][col]++;

                if (!lastRow && !firstCol && lines[row + 1][col - 1] == '@') grid[row][col]++;
                if (!lastRow && lines[row + 1][col] == '@') grid[row][col]++;
                if (!lastRow && !lastCol && lines[row + 1][col + 1] == '@') grid[row][col]++;
            }
        }

        for (int row = 0; row < grid.Length; row++)
        {
            for (int col = 0; col < grid[row].Length; col++)
            {
                count += RemoveRoll(grid, row, col);
            }
        }

        return count;
    }

    public int RemoveRoll(int[][] grid, int row, int col)
    {
        var removedRolls = 0;

        if (grid[row][col] == -1) return 0;

        RecalculateRoll(grid, row, col);

        if (grid[row][col] < 4)
        {
            grid[row][col] = -1;
            removedRolls++;

            var firstRow = row == 0;
            var firstCol = col == 0;
            var lastRow = row == grid.Length - 1;
            var lastCol = col == grid[row].Length - 1;

            if (!firstRow && !firstCol) removedRolls += RemoveRoll(grid, row - 1, col - 1);
            if (!firstRow) removedRolls += RemoveRoll(grid, row - 1, col);
            if (!firstRow && !lastCol) removedRolls += RemoveRoll(grid, row - 1, col + 1);

            if (!firstCol) removedRolls += RemoveRoll(grid, row,  col - 1);
            if (!lastCol) removedRolls += RemoveRoll(grid, row, col + 1);

            if (!lastRow && !firstCol) removedRolls += RemoveRoll(grid, row + 1, col - 1);
            if (!lastRow) removedRolls += RemoveRoll(grid, row + 1, col);
            if (!lastRow && !lastCol) removedRolls += RemoveRoll(grid, row + 1, col + 1);
        }

        return removedRolls;
    }

    public void RecalculateRoll(int[][] grid, int row, int col)
    {
        grid[row][col] = 0;

        var firstRow = row == 0;
        var firstCol = col == 0;
        var lastRow = row == grid.Length - 1;
        var lastCol = col == grid[row].Length - 1;

        if (!firstRow && !firstCol && grid[row - 1][col - 1] != -1) grid[row][col]++;
        if (!firstRow && grid[row - 1][col] != -1) grid[row][col]++;
        if (!firstRow && !lastCol && grid[row - 1][col + 1] != -1) grid[row][col]++;

        if (!firstCol && grid[row][col - 1] != -1) grid[row][col]++;
        if (!lastCol && grid[row][col + 1] != -1) grid[row][col]++;

        if (!lastRow && !firstCol && grid[row + 1][col - 1] != -1) grid[row][col]++;
        if (!lastRow && grid[row + 1][col] != -1) grid[row][col]++;
        if (!lastRow && !lastCol && grid[row + 1][col + 1] != -1) grid[row][col]++;
    }
}
