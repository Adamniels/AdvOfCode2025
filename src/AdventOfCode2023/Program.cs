using AdventOfCode2023.Days;

namespace AdventOfCode2023;

class Program
{
    static void Main(string[] args)
    {
        // Ex: "dotnet run -- 1" kör dag 1
        int day = args.Length > 0
            ? int.Parse(args[0])
            : 1; // default t.ex. dag 1

        IDay puzzle = day switch
        {
            1 => new Day01(),
            2 => new Day02(),
            _ => throw new ArgumentException($"Dag {day} är inte implementerad än")
        };

        puzzle.Run();
    }
}

public interface IDay
{
    void Run();
}
