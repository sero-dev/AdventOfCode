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

                for (int j = 1; j < numberOfDigits; j++)
                {
                    if (numberOfDigits % j != 0) continue;

                    var parts = new List<long>();
                    var divisor = (long)Math.Pow(10, j);
                    var temp = i;
                    
                    while (temp > 0)
                    {
                        parts.Add(temp % divisor);
                        temp /= divisor;
                    }
                    
                    if (parts.Distinct().Count() == 1)
                    {
                        count += i;
                        break;
                    }
                }
            }
        });

        return count;
    }

    record Range(long Min, long Max);
}
