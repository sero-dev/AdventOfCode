using AdventOfCode.Problem.Year2024.Day01;

namespace AdventOfCode.Test.Problem.Year2024.Day01;

public class Year2024_Day01_Problem01Should
{
    [Fact]
    public void SolveReturnsCorrectResultForSampleInput()
    {
        var sut = new Problem01();
        var input = new[]
        {
            "3   4",
            "4   3",
            "2   5",
            "1   3",
            "3   9",
            "3   3"
        };

        var expectedOutput = 11;
        var actualOutput = sut.Solve(input);

        Assert.Equal(expectedOutput, actualOutput);
    }
}
