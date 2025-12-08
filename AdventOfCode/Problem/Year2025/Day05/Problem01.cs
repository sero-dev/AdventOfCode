namespace AdventOfCode.Problem.Year2025.Day05;

public class Problem01 : ProblemSolver
{
    public Problem01() : base(2025, 5, 1) { }

    public override long Solve(string[] lines)
    {
        var testFreshness = false;
        var freshnessCount = 0;

        List<long[]> ranges = [];
        foreach (var line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                testFreshness = true;
                break;
            }

            if (!testFreshness)
            {
                ranges.Add([.. line.Split("-").Select(long.Parse)]);
                continue;
            }

            var value = long.Parse(line);
            foreach (var range in ranges)
            {
                if (value >= range[0] && value <= range[1])
                {
                    freshnessCount++;
                    break;
                }
            }
        }

        return freshnessCount;
    }
}
