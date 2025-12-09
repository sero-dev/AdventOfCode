namespace AdventOfCode.Problem.Year2025.Day06;

public class Problem01 : ProblemSolver
{
    public Problem01() : base(2025, 6, 1) { }

    public override long Solve(string[] lines)
    {
        var ops = lines[^1].Split(" ").Where(t => !string.IsNullOrWhiteSpace(t));

        var totals = new List<long>(lines.Length);

        for (int i = 0; i < lines.Length - 1; i++)
        {
            var numbers = lines[i].Split(" ")
                                  .Where(t => !string.IsNullOrWhiteSpace(t))
                                  .Select(t => long.Parse(t.Trim()))
                                  .ToList();

            if (i == 0)
            {
                foreach (var number in numbers)
                {
                    totals.Add(number);
                }
                continue;
            }

            for (int j = 0; j < ops.Count(); j++)
            {
                var op = ops.ElementAt(j);
                if (op == "+")
                {
                    totals[j] += numbers[j];
                }
                else if (op == "*")
                {
                    totals[j] *= numbers[j];
                }
            }
        }

        return totals.Sum();
    }
}
