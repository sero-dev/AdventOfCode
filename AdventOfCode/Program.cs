using AdventOfCode;
using Spectre.Console;
using System.Diagnostics;

var problems = new ProblemRegistry().GetProblems();

if (problems.Count == 0)
{
    AnsiConsole.MarkupLine("[red]No available problems[/]");
    return;
}

var year = AnsiConsole.Prompt(
    new SelectionPrompt<int>()
        .Title("Select a year")
        .AddChoices(problems.Select(p => p.Year).Distinct()));

AnsiConsole.MarkupLine($"You selected: [green]{year}[/]");


//=========================================================================================================
// Select problems based on day from selected year
var availableDays = problems.Where(p => p.Year == year);
                               
if (!availableDays.Any())
{
    AnsiConsole.MarkupLine($"[red]No available problems for [bold]{year}[/][/]");
    return;
}

var dayPrompt = new SelectionPrompt<int>()
        .Title("Select a day")
        .PageSize(10)
        .MoreChoicesText("[grey](Move up and down to reveal more days)[/]")
        .AddChoices(availableDays.Select(d => d.Day).Distinct().Order());

dayPrompt.Converter = p => "Day " + p.ToString().PadLeft(2, '0');

var day = AnsiConsole.Prompt(dayPrompt);

AnsiConsole.MarkupLine($"You selected: [green]Day {day.ToString()?.PadLeft(2, '0')}[/]");


//=========================================================================================================
// Select problem from selected day and year
var availableProblems = availableDays.Where(p => p.Day == day);

if (!availableProblems.Any())
{
    AnsiConsole.MarkupLine($"[red]No available problems for [bold]{day}[/] in [bold]{year}[/][/]");
    return;
}

var problemPrompt = new SelectionPrompt<int>()
        .Title("Select a problem")
        .AddChoices(availableProblems.Select(p => p.ProblemNumber).Distinct());

problemPrompt.Converter = p => "Problem " + p.ToString().PadLeft(2, '0');

var problemNumber = AnsiConsole.Prompt(problemPrompt);

AnsiConsole.MarkupLine($"You selected: [green]Problem {problemNumber.ToString()?.PadLeft(2, '0')}[/]");


//=========================================================================================================
// Invoke Problem Solution using File
var selectedProblems = availableProblems.Where(p => p.ProblemNumber == problemNumber).ToList();

var inputFilePath = Path.Combine("Input", year.ToString(), $"Day{day.ToString().PadLeft(2, '0')}.txt");
var lines = File.ReadAllLines(inputFilePath);

AnsiConsole.WriteLine();
selectedProblems.ForEach(p =>
{
    AnsiConsole.MarkupLine($"Solving: [yellow]{p.GetType().Name}[/]");
    var stopWatch = Stopwatch.StartNew();
    var solution = p.Solve(lines);
    stopWatch.Stop();

    AnsiConsole.MarkupLine($"Answer: [green] {solution}[/]");
    AnsiConsole.MarkupLine($"Time taken: [blue]{stopWatch.ElapsedMilliseconds} ms[/]");
    AnsiConsole.WriteLine();
});







