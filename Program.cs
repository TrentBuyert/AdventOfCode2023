using AdventOfCode2023;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

public static class Program
{
    public static void Main()
    {
        const string? inputFile = "C:\\Users\\Trent\\source\\repos\\AdventOfCode2023\\input.txt";
        var input = ReadFile(inputFile);
    }

    public static List<string> ReadFile(string inputFile)
    {
        var input = File.ReadAllLines(inputFile).ToList();
        return input;
    }
}