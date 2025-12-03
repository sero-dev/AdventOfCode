namespace AdventOfCode.Problem.Year2025.Day03;

public class Problem02 : ProblemSolver
{
    public Problem02() : base(2025, 3, 2) {}

    public override long Solve(string[] input)
    {
        var count = 0L;
        foreach (var line in input)
        {

            var value = HighestPossibleNumber(line);
            count += value;
        }

        return count;
    }

    public long HighestPossibleNumber(string line)
    {
        var highestDigits = Enumerable.Range(line.Length - 12, 12)
                         .ToArray();

        for (int i = 0; i < highestDigits.Length; i++)
        {
            int end = i == 0 ? 0 : highestDigits[i - 1] + 1;
            for (int j = highestDigits[i]; j >= end; j--)
            {
                if (line[j] >= line[highestDigits[i]])
                {
                    highestDigits[i] = j;
                }
            }
        }

        var value = long.Parse(string.Join("", highestDigits.Select(i => line[i])));
        return value;
    }
}
