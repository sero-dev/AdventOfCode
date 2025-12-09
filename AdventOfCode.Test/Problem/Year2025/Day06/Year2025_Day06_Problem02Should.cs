using AdventOfCode.Problem.Year2025.Day06;

namespace AdventOfCode.Test.Problem.Year2025.Day06;

public class Year2025_Day06_Problem02Should
{
    [Fact]
    public void SolveReturnsCorrectResultForSampleInput()
    {
        var sut = new Problem02();
        var input = new[]
        {
            "123 328  51 64 ",
            " 45 64  387 23 ",
            "  6 98  215 314",
            "*   +   *   +  "
        };

        var expectedOutput = 14;
        var actualOutput = sut.Solve(input);

        Assert.Equal(expectedOutput, actualOutput);
    }
}


