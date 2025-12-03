using AdventOfCode.Problem.Year2025.Day03;

namespace AdventOfCode.Test.Problem.Year2025.Day03;

public class Year2025_Day03_Problem01Should
{
    [Fact]
    public void SolveReturnsCorrectResultForSampleInput()
    {
        var sut = new Problem01();
        var input = new[]
        {
            "987654321111111",
            "811111111111119",
            "234234234234278",
            "818181911112111",
        };

        var expectedOutput = 357;
        var actualOutput = sut.Solve(input);

        Assert.Equal(expectedOutput, actualOutput);
    }
}


