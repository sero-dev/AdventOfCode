using AdventOfCode.Problem.Year2025.Day03;

namespace AdventOfCode.Test.Problem.Year2025.Day03;

public class Year2025_Day03_Problem02Should
{
    [Fact]
    public void SolveReturnsCorrectResultForSampleInput()
    {
        var sut = new Problem02();
        var input = new[]
        {
            "987654321111111",
            "811111111111119",
            "234234234234278",
            "818181911112111",
        };

        var expectedOutput = 3121910778619;
        var actualOutput = sut.Solve(input);

        Assert.Equal(expectedOutput, actualOutput);
    }

    [Theory]
    [InlineData("987654321111111", 987654321111)]
    [InlineData("811111111111119", 811111111119)]
    [InlineData("234234234234278", 434234234278)]
    [InlineData("818181911112111", 888911112111)]
    public void HighestPossibleNumberReturnsCorrectResult(string input, long output)
    {
        var sut = new Problem02();

        var actualOutput = sut.HighestPossibleNumber(input);

        Assert.Equal(output, actualOutput);
    }
}


