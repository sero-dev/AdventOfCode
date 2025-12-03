using System.Text.RegularExpressions;

namespace AdventOfCode.Problem.Year2024.Day01;

public class Problem02 : ProblemSolver
{
    public Problem02() : base(2024, 1, 2) {}

    public override long Solve(string[] input)
    {
        var leftList = new List<int>();
        var rightList = new List<int>();
        var similarityScore = 0;

        foreach (var line in input)
        {
            Regex regex = new(@"^(\d+)\s*(\d+)$");
            var matches = regex.Match(line);
            leftList.Add(int.Parse(matches.Groups[1].Value));
            rightList.Add(int.Parse(matches.Groups[2].Value));
        }

        leftList.ForEach(x =>
        {
            similarityScore += x * rightList.FindAll(y => y == x).Count;
        });

        return similarityScore;
    }
}
