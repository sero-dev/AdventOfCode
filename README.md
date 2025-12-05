# Advent of Code – .NET Edition

This repository contains my solutions to **[Advent of Code](https://adventofcode.com/)** implemented in **C#** using a **.NET Console Application**.  
Each day’s puzzle includes a dedicated solution class, input file, and unit tests.

---

## What is Advent of Code?

Advent of Code is an annual programming challenge where a new puzzle is released each day during the holiday season. The puzzles can be solved in any programming language, and they’re a great way to practice problem-solving, algorithms, and language-specific constructs.

This repository aims to provide a C#/.NET reference implementation for various Advent Of Code puzzles — useful for learning, comparison, and practice.

## Repo Structure

```
/AdventOfCode.slnx             # .NET Solution file
/AdventOfCode/                 # Main project directory (console app)
/AdventOfCode.Test/            # Unit tests project
.gitignore
.gitattributes
README.md                     # (this file)
```

- **AdventOfCode/** — contains one solution class per puzzle/day + input files.  
- **AdventOfCode.Test/** — contains unit tests validating the correctness of each puzzle solution.  

## What You Get

- Working C# implementations of Advent of Code puzzles.  
- Unit-tests to ensure correctness — useful for verifying solutions against example and real inputs.  
- A clean, organized .NET console-app structure, making it easy to run or extend with new years/days.  

## Getting Started

1. Clone the repo:  
   ```bash
   git clone https://github.com/sero-dev/AdventOfCode.git
   cd AdventOfCode
   ```

2. Open the solution (`AdventOfCode.slnx`) in your favorite .NET IDE (e.g., Visual Studio / Rider / VS Code with C#).  

3. Build the solution.

4. Run the console project to execute specific puzzle solutions — or run the test project to verify all solutions.

## How to Contribute / Extend

- **Add new puzzle solutions:** For a new Advent of Code day/year, create a new class in `AdventOfCode/` and add corresponding input file.  
- **Add unit tests:** Include a test in `AdventOfCode.Test/` to validate correct behavior for sample + real input.  
- **Refactor / improve:** Feel free to improve code structure, add helper utilities (parsing, shared functions), or enhance performance.  

## Why This Project?

- Provides a working, real-world example of solving algorithmic puzzles in C#/.NET.  
- Serves as a learning resource if you’re exploring C#/.NET and want to see real use cases (input parsing, data processing, testing).  
- Helpful as a reference for comparing solutions across languages — many other Advent of Code repos use different languages; having a C# baseline can help you compare approaches.  

## Disclaimer

This is a **personal project/collection** of Advent of Code solutions. It’s not officially affiliated with the Advent of Code organizers. The goal is educational and experimental — to practice, learn, and share.
