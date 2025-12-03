using AdventOfCode.Problem.Year2025.Day02;

namespace AdventOfCode.Test.Problem.Year2025.Day02;

public class Year2025_Day02_Problem02Should
{
    [Fact]
    public void SolveReturnsCorrectResultForSampleInput()
    {
        var sut = new Problem02();
        var input = new[]
        {
            "11-22,95-115,998-1012,1188511880-1188511890,222220-222224,1698522-1698528,446443-446449,38593856-38593862,565653-565659,824824821-824824827,2121212118-2121212124"
        };

        var expectedOutput = 4174379265;
        var actualOutput = sut.Solve(input);

        Assert.Equal(expectedOutput, actualOutput);
    }
}
