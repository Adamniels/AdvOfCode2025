namespace AdventOfCode2023.Days;

public class Day01 : IDay
{
    public void Run()
    {
        part1();
        part2();
    }

    private static void part2()
    {

        int result = 0;
        var lines = File.ReadAllLines("inputs/2023/day2part1.txt");

        foreach (string line in lines)
        {
            var parts = line.Split(":");
            var gamePart = parts[0];
            var gameID = parts[0].Replace("Game ", "").Trim();
            var bagPicks = parts[1].Split(';');
            var dict = maxDict(bagPicks);
            var multiplied = 1;
            foreach (var kvp in dict)
            {
                multiplied *= kvp.Value;
            }
            result += multiplied;
        }

        Console.WriteLine(result);
    }

    private static Dictionary<string, int> maxDict(string[] bagPicks)
    {
        var dict = new Dictionary<string, int>
        {
            { "red", 0 },
            { "green", 0 },
            { "blue", 0 }
        };
        foreach (string bagPickLine in bagPicks)
        {

            var eachColor = bagPickLine.Trim().Split(",");

            for (int i = 0; i < eachColor.Length; i++)
            {
                var parts = eachColor[i].Trim().Split(" ");
                if (dict.GetValueOrDefault(parts[1], 0) < int.Parse(parts[0].Trim()))
                {
                    dict[parts[1]] = int.Parse(parts[0].Trim());
                }
            }

        }
        return dict;

    }

    private static void part1()
    {

        int result = 0;
        var lines = File.ReadAllLines("inputs/2023/day2part1.txt");

        foreach (string line in lines)
        {
            var parts = line.Split(":");
            var gamePart = parts[0];
            var gameID = parts[0].Replace("Game ", "").Trim();
            var bagPicks = parts[1].Split(';');
            bool correctGame = true;
            for (int j = 0; j < bagPicks.Length; j++)
            {
                var dict = bagPickToDict(bagPicks[j]);
                if (isNonValid(dict))
                {
                    correctGame = false;
                }
            }
            if (correctGame)
            {
                result += int.Parse(gameID);
            }

        }
        Console.WriteLine(result);
    }
    public static Dictionary<string, int> bagPickToDict(string bagPickLine)
    {
        // ex input: 1 red, 2 green, 6 blue 

        Dictionary<string, int> sub = new Dictionary<string, int>();

        var eachColor = bagPickLine.Trim().Split(",");

        for (int i = 0; i < eachColor.Length; i++)
        {
            var parts = eachColor[i].Trim().Split(" ");
            sub.Add(parts[1].Trim(), int.Parse(parts[0].Trim()));
        }

        return sub;
    }

    private static bool isNonValid(Dictionary<string, int> dict)
    {
        int red = 12;
        int green = 13;
        int blue = 14;

        return dict.GetValueOrDefault("red", 0) > red || dict.GetValueOrDefault("green", 0) > green || dict.GetValueOrDefault("blue", 0) > blue;

    }

    // Helper for debug
    public static void PrintDictMultiline(Dictionary<string, int> dict)
    {
        Console.WriteLine("{");
        foreach (var kv in dict)
        {
            Console.WriteLine($"  {kv.Key}: {kv.Value}");
        }
        Console.WriteLine("}");
    }
}
