using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> amountOfLetters = new Dictionary<char, int>();
            foreach(char c in magazine)
            {
                if(!amountOfLetters.ContainsKey(c))
                {
                    amountOfLetters.Add(c, 1);
                }
                else
                {
                    amountOfLetters[c]++;
                }
            }
            
            foreach(char c in ransomNote)
            {
                if (!amountOfLetters.ContainsKey(c))
                    return false;
                else
                {
                    amountOfLetters[c]--;
                    if (amountOfLetters[c] < 0)
                        return false;
                }
            }
            return true;
        }
    }
}
