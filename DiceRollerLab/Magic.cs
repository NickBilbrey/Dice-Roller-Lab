using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollerLab
{
    public static class Magic
    {
        private static readonly Random getrandom = new Random();

        public static int GetRandomNumber(int min, int max) // gives random number once parameters are set
        {
            lock (getrandom)
            {
                return getrandom.Next(min, max);
            }
        }
        public static string Result(int x , int y)  // if else statements to catch if a valid combination is hit
        {
            if (x == 1 && y == 1)
            {
                return "Snake eyes!";
            }
            else if (x == 1 && y == 2 || x == 2 && y == 1)
            {
                return "Ace Deuce!";
            }
            else if (x == 6 && y == 6)
            {
                return "Box cars!";
            }
            else
            {
                return "";
            }
        }
        public static string Craps(int x ,  int y) // checks for win or craps if neither than returns empty line
        { 
        if (x + y == 7 || x + y== 11)
            {
                return "winner winner chicken dinner!!";
            }
        else if (x + y == 2 || x + y == 3 || x + y == 12)
            {
                return "Craps!!";
            }
        else
            {
                return "\n";
            }
              
        
        }
        



    }
}
