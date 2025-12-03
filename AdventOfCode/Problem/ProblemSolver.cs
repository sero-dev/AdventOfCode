namespace AdventOfCode.Problem;

public abstract class ProblemSolver(int year, int day, int problemNumber)
{
    public int Year { get; } = year;
    public int Day { get; } = day;
    public int ProblemNumber { get; } = problemNumber;

    public abstract long Solve(string[] input);
}
