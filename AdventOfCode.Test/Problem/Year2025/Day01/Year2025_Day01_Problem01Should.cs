using AdventOfCode.Problem.Year2025.Day01;

namespace AdventOfCode.Test.Problem.Year2025.Day01;

public class Year2025_Day02_Problem01Should
{
    [Fact]
    public void SolveReturnsCorrectResultForSampleInput()
    {
        var sut = new Problem01();
        var input = new[]
        {
            "L68",
            "L30",
            "R48",
            "L5",            
            "R60",
            "L55",
            "L1",            
            "L99",
            "R14",
            "L82"
        };

        var expectedOutput = 3;
        var actualOutput = sut.Solve(input);

        Assert.Equal(expectedOutput, actualOutput);
    }
}
