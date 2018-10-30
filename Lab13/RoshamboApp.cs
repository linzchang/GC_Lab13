using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class RoshamboApp
    {
        public static Roshambo GetOpponentRoshambo(ActualPlayer user, string name)
        {
            Roshambo gameRoshambo;
            if (name == "Patrick")
            {
                StupidPlayer patrick = new StupidPlayer();
                return gameRoshambo = patrick.rock;
            }
            else
            {
                RandomPlayer squidward = new RandomPlayer();
                return gameRoshambo = squidward.GetRoshambo();
            }
        }
    }
}
