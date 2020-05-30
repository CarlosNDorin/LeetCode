using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class LongestPalindrome
    {
        public int Longestpalindrome(string s)
        {
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            if (s.Length == 0)
                return 0;
            int even = 0;
            int odd = 0;
            bool haveOdd = false;
            foreach(char c in s)
            {
                if(!keyValuePairs.ContainsKey(c))
                {
                    keyValuePairs.Add(c, 1);
                }
                else
                {
                    keyValuePairs[c]++;
                }
            }

            foreach(KeyValuePair<char,int> dic in keyValuePairs)
            {
                if (((dic.Value % 2) != 0))
                {
                    odd += dic.Value-1;
                    haveOdd = true;
                }
                else
                {
                    even += dic.Value;
                }
            }
            if (haveOdd)
                odd++;
            return even + odd;
        }
    }
}
