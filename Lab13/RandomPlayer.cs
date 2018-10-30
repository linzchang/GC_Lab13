using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class RandomPlayer
    {
        public string Name = "Squidward";

        public Roshambo GetRoshambo()
        {
            Random random = new Random();
            int selection = random.Next(0,2);

            if (selection == 0)
            {
                return Roshambo.rock;
            }
            else if (selection == 1)
            {
                return Roshambo.paper;
            }
            else
            {
                return Roshambo.scissors;
            }
        }

    }
}
