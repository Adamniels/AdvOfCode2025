# Advent of Code 2025

C# solutions for Advent of Code 2025.

## Structure

```
AdventOfCode2025/
   inputs/          # Input files for each day (day01.txt, day02.txt, ...)
   src/
       AdventOfCode2025/
           Days/    # One file per day (Day01.cs, Day02.cs, ...)
           Program.cs
```

## How to Run

Run a specific day from the project root directory:
```bash
dotnet run --project src/AdventOfCode2025 -- 1    # Run day 1
dotnet run --project src/AdventOfCode2025 -- 2    # Run day 2
```

Alternatively, from the `src/AdventOfCode2025` directory:
```bash
cd src/AdventOfCode2025
dotnet run -- 1    # Run day 1
dotnet run -- 2    # Run day 2
```

## Adding a New Day

1. Create a new file in `src/AdventOfCode2025/Days/DayXX.cs`
2. Implement the `IDay` interface with a `Run()` method
3. Add the day to the switch statement in `Program.cs`
4. Add the input file in `inputs/dayXX.txt`
