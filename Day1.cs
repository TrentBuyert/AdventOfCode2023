using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AdventOfCode2023
{
    internal class Day1
    {
        class part1
        {
/*            var input = File.ReadAllLines("C:\\Users\\Trent\\source\\repos\\AdventOfCode2023\\input.txt").Replace();
            var inputLines = input
        var digits = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var digitsWithReplacements = digits
                .Select((x, i) => (Word: x, Int: i + 1))
                .ToDictionary(Tuple => Tuple.Word, Tuple => $"{Tuple.Word}{Tuple.Int}{Tuple.Word}");

            var resultsByLine = input.Select(line =>
            {
                var currentLine = line;
                foreach (var (word, symbol) in digitsWithReplacements)
                {
                    currentLine = currentLine.Replace(word, symbol);
                }
                var numbersOnlyLine = Regex.Replace(currentLine, @"[^\d]+", string.Empty);
                var combinedNumber = $"{numbersOnlyLine.First()}{numbersOnlyLine.Last()}";
                return int.Parse(combinedNumber);
            }).ToList();

            var sum = resultsByLine.Sum();
            Console.WriteLine(sum);*/
        }
    }
}
