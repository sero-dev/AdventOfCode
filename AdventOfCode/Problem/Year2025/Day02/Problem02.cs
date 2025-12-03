namespace AdventOfCode.Problem.Year2025.Day02;

public class Problem02 : ProblemSolver
{
    public Problem02() : base(2025, 2, 2) { }

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
                var numberOfDigits = (int)Math.Floor(Math.Log10(i)) + 1;
                if (numberOfDigits % 2 == 1) continue;

                var mid = numberOfDigits / 2;
                var divisor = (long)Math.Pow(10, mid);

                var firstHalf = i / divisor;
                var secondHalf = i % divisor;
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
