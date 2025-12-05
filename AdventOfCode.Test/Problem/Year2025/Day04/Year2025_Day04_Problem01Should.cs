using AdventOfCode.Problem.Year2025.Day04;

namespace AdventOfCode.Test.Problem.Year2025.Day04;

public class Year2025_Day04_Problem01Should
{
    [Fact]
    public void SolveReturnsCorrectResultForSampleInput()
    {
        var sut = new Problem01();
        var input = new[]
        {
            "..@@.@@@@.",
            "@@@.@.@.@@",
            "@@@@@.@.@@",
            "@.@@@@..@.",
            "@@.@@@@.@@",
            ".@@@@@@@.@",
            ".@.@.@.@@@",
            "@.@@@.@@@@",
            ".@@@@@@@@.",
            "@.@.@@@.@.",
        };

        var expectedOutput = 13;
        var actualOutput = sut.Solve(input);

        Assert.Equal(expectedOutput, actualOutput);
    }

    [Fact]
    public void CountSolveReturnsCorrectResultForSampleInput()
    {
        var sut = new Problem01Count();
        var input = new[]
        {
            "..@@.@@@@.",
            "@@@.@.@.@@",
            "@@@@@.@.@@",
            "@.@@@@..@.",
            "@@.@@@@.@@",
            ".@@@@@@@.@",
            ".@.@.@.@@@",
            "@.@@@.@@@@",
            ".@@@@@@@@.",
            "@.@.@@@.@.",
        };

        var expectedOutput = 13;
        var actualOutput = sut.Solve(input);

        Assert.Equal(expectedOutput, actualOutput);
    }
}


