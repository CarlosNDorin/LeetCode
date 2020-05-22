using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class GuessNumberHighOrLower
    {
        private static int numberToGuess;
        public GuessNumberHighOrLower(int num)
        {
            numberToGuess = num;
        }

        public int GuessNumber(int n)
        {
            int end = n;
            int start = 1;

            while(start < end)
            {
                int mid = ((end - start) / 2) + start;
                int answerGuess = guess(mid);
                if (answerGuess == 0)
                    return mid;

                if (answerGuess == 1)
                {
                    start = mid+1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return start;
        }

        public int guess(int num)
        {
            if (num == numberToGuess)
                return 0;
            if (num > numberToGuess)
                return -1;
            else
                return 1;
        }
    }
}
