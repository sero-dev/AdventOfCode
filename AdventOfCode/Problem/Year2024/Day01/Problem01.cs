using System.Text.RegularExpressions;

namespace AdventOfCode.Problem.Year2024.Day01;

public class Problem01 : ProblemSolver
{
    public Problem01() : base(2024, 1, 1) {}

    public override long Solve(string[] input)
    {
        var leftList = new List<int>();
        var rightList = new List<int>();
        var totalDistance = 0;

        foreach (var line in input)
        {
            Regex regex = new(@"^(\d+)\s*(\d+)$");
            var matches = regex.Match(line);
            leftList.Add(int.Parse(matches.Groups[1].Value));
            rightList.Add(int.Parse(matches.Groups[2].Value));
        }

        leftList.Sort();
        rightList.Sort();

        for (int i = 0; i < leftList.Count; i++)
        {
            totalDistance += Math.Abs(leftList[i] - rightList[i]);
        }

        return totalDistance;
    }
}
