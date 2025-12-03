namespace AdventOfCode.Problem.Year2025.Day03;

public class Problem01 : ProblemSolver
{
    public Problem01() : base(2025, 3, 1) {}

    public override long Solve(string[] input)
    {
        var count = 0;
        foreach (var line in input)
        {
            var maxIndex = 0;
            for (int i = 1; i < line.Length; i++) 
            {
                if (line[i] > line[maxIndex] && i != line.Length - 1)
                {
                    maxIndex = i;
                }
            }

            var secondMaxIndex = -1;
            for (int i = maxIndex + 1; i < line.Length; i++)
            {
                if (secondMaxIndex == -1 || line[i] > line[secondMaxIndex])
                {
                    secondMaxIndex = i;
                }
            }

            var value = int.Parse(string.Concat(line[maxIndex], line[secondMaxIndex]));
            count += value;
        }

        return count;
    }
}
