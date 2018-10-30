using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab13
{
    static class Validation
    {
        public static string GetResponse(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public static string GetName(string message)
        {
            Console.WriteLine(message);
            string answer = Console.ReadLine();

            while (true)
            {
                if (Regex.IsMatch(answer, @"[0-9]"))
                {
                    answer = GetName($"{answer} is not a valid input, please do not enter any numbers or symbols.");
                    continue;
                }
                else
                {
                    return answer;
                }
            }
        }
    }
}
