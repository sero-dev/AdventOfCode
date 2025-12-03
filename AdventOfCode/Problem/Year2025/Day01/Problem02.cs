namespace AdventOfCode.Problem.Year2025.Day01;

public class Problem02 : ProblemSolver
{
    public Problem02() : base(2025, 1, 2) {}

    public override long Solve(string[] input)
    {
        var startingPoint = 50;
        var zeroCount = 0;

        foreach (var line in input)
        {
            var isStartingPointZero = startingPoint == 0;
            var direction = line[..1] == "L" ? -1 : 1;
            var magnitude = int.Parse(line[1..]);

            var revolutions = magnitude / 100;
            zeroCount += revolutions;

            startingPoint += direction * (magnitude % 100);

            if (direction == 1 && startingPoint >= 100) zeroCount++;
            if (direction == -1 && startingPoint <= 0 && !isStartingPointZero) zeroCount++;

            startingPoint = (startingPoint + 100) % 100;
        }

        return zeroCount;
    }
}
