using AdventOfCode.Problem.Year2025.Day04;

namespace AdventOfCode.Test.Problem.Year2025.Day04;

public class Year2025_Day04_Problem02Should
{
    [Fact]
    public void SolveReturnsCorrectResultForSampleInput()
    {
        var sut = new Problem02();
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

        var expectedOutput = 43;
        var actualOutput = sut.Solve(input);

        Assert.Equal(expectedOutput, actualOutput);
    }
}


