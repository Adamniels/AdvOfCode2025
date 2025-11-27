# Advent of Code Solutions

C# solutions for Advent of Code challenges, organized by year.

## Structure

```
AdventOfCode2025/
   src/
       AdventOfCode2025/     # 2025 solutions
           Days/             # One file per day (Day01.cs, Day02.cs, ...)
           Program.cs
       AdventOfCode2023/     # 2023 solutions (example of previous year)
           Days/
           Program.cs
   AdventOfCode2025.sln      # Solution file containing all year projects
```

## How to Run

Run a specific day from the project root directory:

### For 2025:
```bash
dotnet run --project src/AdventOfCode2025 -- 1    # Run day 1
dotnet run --project src/AdventOfCode2025 -- 2    # Run day 2
```

### For previous years (e.g., 2023):
```bash
dotnet run --project src/AdventOfCode2023 -- 1    # Run day 1
dotnet run --project src/AdventOfCode2023 -- 2    # Run day 2
```

Alternatively, navigate to the specific year directory:
```bash
cd src/AdventOfCode2025
dotnet run -- 1    # Run day 1
```

## Adding a Previous Year

To add solutions for a previous year (e.g., 2023), follow these steps:

### 1. Create new project with dotnet CLI
```bash
dotnet new console -n AdventOfCode2023 -o src/AdventOfCode2023
```

### 2. Add project to solution
```bash
dotnet sln AdventOfCode2025.sln add src/AdventOfCode2023/AdventOfCode2023.csproj
```

### 3. Create Days folder
```bash
mkdir src/AdventOfCode2023/Days
```

### 4. Update target framework (optional)
Edit `src/AdventOfCode2023/AdventOfCode2023.csproj` and ensure `<TargetFramework>` matches your desired version (e.g., `net9.0`).

### 5. Set up Program.cs
Copy the structure from an existing year and update the namespace:
```bash
cp src/AdventOfCode2025/Program.cs src/AdventOfCode2023/Program.cs
```

Then update the namespace from `AdventOfCode2025` to `AdventOfCode2023` and the using statement to match.

### 6. Create your first day
Create `src/AdventOfCode2023/Days/Day01.cs` with the same structure as other years, updating the namespace to `AdventOfCode2023.Days`.

## Adding a New Day

For any year project:

1. Create a new file in `src/AdventOfCodeYYYY/Days/DayXX.cs`
2. Implement the `IDay` interface with a `Run()` method
3. Add the day to the switch statement in that year's `Program.cs`
4. Add the input file (location depends on your setup, typically `inputs/dayXX.txt`)

### Example Day Template:
```csharp
namespace AdventOfCodeYYYY.Days;

public class DayXX : IDay
{
    public void Run()
    {
        var lines = File.ReadAllLines("inputs/dayXX.txt");

        // Your solution here
        Console.WriteLine("Day XX:");
    }
}
```
