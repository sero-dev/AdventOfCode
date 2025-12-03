using System.Diagnostics;

namespace AdventOfCode.Problem.Year2025.Day02;

public class Problem01StringImpl : ProblemSolver
{
    public Problem01StringImpl() : base(2025, 2, 1) { }

    public override long Solve(string[] input)
    {
        var stringRanges = input[0].Split(',');
        var count = 0L;

        var ranges = stringRanges.Select(r =>
        {
            var minMax = r.Split('-');
            return new Range(long.Parse(minMax[0]), long.Parse(minMax[1]));
        }).ToList();

        ranges.ForEach(r =>
        {
            for (long i = r.Min; i <= r.Max; i++)
            {
                var text = i.ToString();
                if (text.Length % 2 == 1) continue;

                var mid = text.Length / 2;
                var firstHalf = text[..mid];
                var secondHalf = text[mid..];

                if (firstHalf == secondHalf)
                {
                    count += i;
                }
            }
        });

        return count;
    }

    record Range(long Min, long Max);
}
