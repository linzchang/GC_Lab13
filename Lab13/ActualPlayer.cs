using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class ActualPlayer : Player
    {
        public new string Name { get; set; }
        public Roshambo roshamboChoice;

        public override Roshambo generateRoshambo()
        {
            string answer = Validation.GetResponse("\nRock, paper or scissors? (R/P/S): ");
            while (true)
            {
                switch (answer.ToUpper())
                {
                    case "R":
                        return roshamboChoice = Roshambo.rock;
                    case "P":
                        return roshamboChoice = Roshambo.paper;
                    case "S":
                        return roshamboChoice = Roshambo.scissors;
                    default:
                        answer = Validation.GetResponse("That is not a valid selection.  Please enter R, P, or S: ");
                        continue;
                }
            }
            
        }
    }
}
