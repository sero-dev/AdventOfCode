using AdventOfCode.Problem;
using System.Reflection;

namespace AdventOfCode;

internal class ProblemRegistry
{
    private readonly List<ProblemSolver> problems = [];

    public ProblemRegistry()
    {
        var types = GetAllProblemTypes();
        problems.AddRange(types.Select(t =>
        {
            var instance = (ProblemSolver) Activator.CreateInstance(t)!;
            return instance;
        }));
    }

    public List<ProblemSolver> GetProblems()
    {
        return problems;
    }

    private bool HasDuplicates()
    {
        var duplicates = problems
            .GroupBy(p => (p.Year, p.Day, p.ProblemNumber))
            .Where(g => g.Count() > 1)
            .Select(g => g.Key)
            .ToList();
        return duplicates.Count > 0;
    }

    private IEnumerable<Type> GetAllProblemTypes()
    {
        var problemType = typeof(ProblemSolver);

        return Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => problemType.IsAssignableFrom(t) && !t.IsAbstract);
    }
}
