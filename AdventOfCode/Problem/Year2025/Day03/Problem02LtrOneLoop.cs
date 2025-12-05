namespace AdventOfCode.Problem.Year2025.Day03;

public class Problem02LtrOneLoop : ProblemSolver
{
    public Problem02LtrOneLoop() : base(2025, 3, 2) {}

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

    public long HighestPossibleNumber(string input)
    {
        var length = input.Length;
        var output = new char[12];
        var outputIterator = 0;

        //811111111111119

        for (int i = 0; i < length; i++)
        {
            var comparisonValue = input[i];

            if ((length - i) <= (12 - outputIterator))
            {
                output[outputIterator] = comparisonValue;
                outputIterator++;
                continue;
            }

            if (comparisonValue > output[outputIterator])
            {
                var temp = 12 - ((length - i));
                var tempp = temp > 0 ? temp : 0;

                for (int j = tempp; j < 12; j++)
                {
                    if (comparisonValue > output[j])
                    {
                        output[j] = comparisonValue;
                        outputIterator = j;
                        break;
                    }
                }
            }
            else if (outputIterator == 11 && comparisonValue == output[outputIterator])
            {
                continue;
            }
            else
            {
                output[outputIterator] = comparisonValue;
            }

            outputIterator++;

            if (outputIterator == 12 && output[11] == 9)
            {
                break;
            }
            else if (outputIterator == 12)
            {
                outputIterator--;
            }
        }

        var value = long.Parse(string.Join("", output));
        return value;
    }
}
