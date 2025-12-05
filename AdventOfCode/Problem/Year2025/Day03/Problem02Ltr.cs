namespace AdventOfCode.Problem.Year2025.Day03;

public class Problem02Ltr : ProblemSolver
{
    public Problem02Ltr() : base(2025, 3, 2) {}

    public override long Solve(string[] input)
    {
        var count = 0L;
        foreach (var line in input)
        {

            var value = HighestPossibleNumber(line);
            count += value;
        }

        return count;
    }

    public long HighestPossibleNumber(string line)
    {
        var highestNumber = 0L;
        var startIndex = 0;

        for (int i = 0; i < 12; i++)
        {
            var maxDigit = line[startIndex];
            var remainingDigits = 12 - i;

            for (int j = startIndex + 1; j <= line.Length - remainingDigits; j++)
            {
                if (maxDigit == '9') break;

                if (line[j] > maxDigit)
                {
                    maxDigit = line[j];
                    startIndex = j;
                }
            }

            highestNumber += (maxDigit - 48) * (long)Math.Pow(10, 12 - i - 1);
            startIndex++;
        }

        return highestNumber;
    }
}
