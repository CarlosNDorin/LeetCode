using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class BullsandCows
    {
        public string GetHint(string secret, string guess)
        {
            int bull = 0;
            int cows = 0;
            int[] secretArray = new int[10];
            int[] guessArray = new int[10];

            for(int i = 0;i<secret.Length;i++)
            {
                if (secret[i]==guess[i])
                {
                    bull++;
                }
                else
                {
                    secretArray[secret[i]-48]++;
                    guessArray[guess[i]-48]++;
                }
            }
            for(int i =0;i<10;i++)
            {
                cows += Math.Min(secretArray[i], guessArray[i]);
            }
            return $"{bull}A{cows}B";
        }
    }
}
