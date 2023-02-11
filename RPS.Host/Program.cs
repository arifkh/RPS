using RPS.Core.Interfaces;
using RPS.Core;

using System;
using System.Collections.Generic;

namespace RPS.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game of Rock Paper Scissors");
            Console.WriteLine("------------------------------------------");

            string keepPlaying = "y";

            while (keepPlaying == "y")
            {
                Console.WriteLine("Please indicate your choice (r, p, s)");
                string choice = Console.ReadLine();
                IGesture playerGesture = null;

                switch (choice)
                {
                    case "r":
                        playerGesture = new RockPaperScissorsFactory().GetRock();
                        break;
                    case "p":
                        playerGesture = new RockPaperScissorsFactory().GetPaper();
                        break;
                    case "s":
                        playerGesture = new RockPaperScissorsFactory().GetScissors();
                        break;
                    default:
                        break;

                }

                IGesture computerGesture = GetRandomGesture();

                var game = new Game();
                var result = game.Battle(playerGesture, computerGesture);

                Console.WriteLine($"You chose {playerGesture.FriendlyName} | Computer chose {computerGesture.FriendlyName}");
                Console.WriteLine($"{result.ToString()}");

                Console.WriteLine("Press y to continue or any other key to exit");
                keepPlaying = Console.ReadLine();
            }
                
        }

        private static IGesture GetRandomGesture()
        {
            var list = new List<IGesture>()
            {
                new RockPaperScissorsFactory().GetRock(),
                new RockPaperScissorsFactory().GetPaper(),
                new RockPaperScissorsFactory().GetScissors()
            };

            var rand = new Random();
            var idx = rand.Next(0, 2);
            return list[idx];
        }
    }
}
