using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Counter
    {
        public static int Wins;
        public static int Losses;
        public static int Ties;

        public static int IncreaseCount(string choice)
        {
            switch(choice)
            {
                case "wins":
                    return ++Wins;
                case "losses":
                    return ++Losses;
                case "ties":
                    return ++Ties;
                default:
                    return 0;
            }
            
        }
    }
}
