using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            ActualPlayer user = new ActualPlayer();
            string opponentName;

            Console.WriteLine("Welcome to the Rock, Paper, Scissors arcade in Bikini Bottom!");
            user.Name = Validation.GetName("What is your name?");

            while (true)
            {
                opponentName = ChooseOpponent();
                Roshambo opponentRoshambo = RoshamboApp.GetOpponentRoshambo(user, opponentName);
                Roshambo userRoshambo = user.generateRoshambo();

                Console.WriteLine($"{user.Name}: {userRoshambo} \n{opponentName}: {opponentRoshambo}");
                GetOutcome(opponentRoshambo, user, opponentName);


                string keepGoing = Validation.GetResponse("Would you like to play again? Type Y to continue.\n");
                if (!(keepGoing.ToUpper() == "Y"))
                {
                    Console.WriteLine($"{user.Name} won {Counter.Wins} times, tied {Counter.Ties} times, and lost {Counter.Losses} times.");
                    Console.WriteLine("Thanks for playing!");
                    Console.ReadLine();
                    break;
                }
            } 
        }

        public static string ChooseOpponent()
        {
            string opponentChoice = Validation.GetResponse("\nWould you like to play against Patrick or Squidward? (P/S): ");
            while (true)
            {
                if (opponentChoice.ToUpper() == "P")
                {
                    StupidPlayer patrick = new StupidPlayer();
                    return "Patrick";
                }
                else if (opponentChoice.ToUpper() == "S")
                {
                    RandomPlayer squidward = new RandomPlayer();
                    return "Squidward";
                }
                else
                {
                    opponentChoice = Validation.GetResponse("That is not valid, please enter P or S.");
                    continue;
                }
            }

            
        }

        public static void GetOutcome(Roshambo gameRoshambo, ActualPlayer user, string name)
        {
            if (user.roshamboChoice == gameRoshambo)
            {
                Console.WriteLine("Draw!\n");
                Counter.IncreaseCount("ties");
            }
            else if ((user.roshamboChoice == Roshambo.paper && gameRoshambo == Roshambo.rock) ||
                (user.roshamboChoice == Roshambo.rock && gameRoshambo == Roshambo.scissors) ||
                (user.roshamboChoice == Roshambo.scissors && gameRoshambo == Roshambo.paper))
            {
                Console.WriteLine($"{user.Name} wins!\n");
                Counter.IncreaseCount("wins");
            }
            else
            {
                Console.WriteLine($"{name} wins!\n");
                Counter.IncreaseCount("losses");
            }
        }
    }
}
