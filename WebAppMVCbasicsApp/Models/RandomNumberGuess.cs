using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMVCbasicsApp.Models
{
    public class RandomNumberGuess
    {
        public static string MatchGuess(int guess, int rnd)
        {
            if (guess < rnd)
            {
                return "No higher!";
            } else if (guess > rnd) 
            {
                return "No lower!";
            } else
            {
                return "Yes!! You won!";
            }
        }
        public static int GetRandom(int max)
        {
            Random rnd = new Random();
            return rnd.Next(1, max);
        }
    }
}
