using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static AdventOfCode2023.Day2;

namespace AdventOfCode2023
{
    internal class Day2
    {
        public class Part1
        {   
            public static void GameIDSum (List<string> stringList)
            { 
                List<Game> gameList = new List<Game>();
                foreach(string str in stringList)
                {
                    Game game = new Game(str);
                    if (game.isValid)
                    {
                        gameList.Add(game);
                    }
                }
                var gameIDSum = gameList.Sum(x => x.gameID);
                Console.WriteLine(gameIDSum);
            }
        }

        public class Part2
        {
            public static void SumOfPowers(List<string> stringList)
            {
                List<Game> gameList = new List<Game>();
                foreach (string str in stringList)
                {
                    Game game = new Game(str);
                    gameList.Add(game);
                }
                var powerSum = gameList.Sum(x => x.Powers);
                Console.WriteLine(powerSum);
            }
        }

        public class Game
        {
            public int gameID = 0;
            int red = 0;
            int blue = 0;
            int green = 0;
            public int Powers => red * blue * green;
            public bool isValid = true;

            public Game(string str)
            {
                var gameLabelSplitter = str.Split("Game ");
                var gameIDSets = gameLabelSplitter[1].Split(": ");
                this.gameID = int.Parse(gameIDSets[0]);
                var setSorterString = gameIDSets[1].Split("; ");
                foreach (var set in setSorterString)
                {
                    this.setSorter(set);
                }
                //this.validate();
            }
            public void validate()
            {
                if(red > 12 || blue > 14 || green > 13) 
                { 
                    isValid = false;
                }
            }
            public void setSorter(string set)
            {
                var setColorSplit = set.Split(", ");
                foreach (string str in setColorSplit)
                {
                    if (str.Contains("red"))
                    {
                        var setNumberColorSplit = str.Split(" ");
                        this.red = Math.Max(this.red, int.Parse(setNumberColorSplit[0]));
                    }
                    else if (str.Contains("blue"))
                    {
                        var setNumberColorSplit = str.Split(" ");
                        this.blue = Math.Max(this.blue, int.Parse(setNumberColorSplit[0]));
                    }
                    else if (str.Contains("green"))
                    {
                        var setNumberColorSplit = str.Split(" ");
                        this.green = Math.Max(this.green, int.Parse(setNumberColorSplit[0]));
                    }
                }
            }
        }
    }
}
