namespace AdventOfCode.Problem.Year2025.Day01;

public class Problem01 : ProblemSolver
{
    public Problem01() : base(2025, 1, 1) {}

    public override long Solve(string[] input)
    {
        var startingPoint = 50;
        var zeroCount = 0;

        foreach (var line in input)
        {
            var direction = line[..1] == "L" ? -1 : 1;
            var magnitude = int.Parse(line[1..]);

            startingPoint += direction * magnitude;
            if (startingPoint % 100 == 0) zeroCount++;
        }

        return zeroCount;
    }
}
