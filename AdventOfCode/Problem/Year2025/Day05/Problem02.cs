namespace AdventOfCode.Problem.Year2025.Day05;

public class Problem02 : ProblemSolver
{
    public Problem02() : base(2025, 5, 2) { }

    public override long Solve(string[] lines)
    {
        List<long[]> ranges = [];
        foreach (var line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                break;
            }

            var rangeParts = line.Split("-").Select(long.Parse).ToArray();
            if (ranges.Count == 0)
            {
                ranges.Add(rangeParts);
                continue;
            }

            for (int i = 0; i < ranges.Count; i++)
            {
                var existingRange = ranges[i];

                if (rangeParts[0] <= existingRange[1] && rangeParts[1] >= existingRange[0])
                {
                    rangeParts[0] = Math.Min(rangeParts[0], existingRange[0]);
                    rangeParts[1] = Math.Max(rangeParts[1], existingRange[1]);
                    ranges.RemoveAt(i);
                    i--;
                }

                if (i == ranges.Count - 1)
                {
                    ranges.Add(rangeParts);
                    break;
                }
            }
        }

        var count = 0L;
        ranges.ForEach(r => count += r[1] - r[0] + 1);

        return count;
    }
}
