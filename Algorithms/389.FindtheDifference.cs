using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class FindtheDifference
    {
        public char FindTheDifference(string s, string t)
        {
            Dictionary<char,int> keyValuePairs = new Dictionary<char, int>();

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
            foreach(char c in t)
            {
                if (!keyValuePairs.ContainsKey(c))
                    return c;
                else
                {
                    keyValuePairs[c]--;
                    if (keyValuePairs[c] < 0)
                        return c;
                }
            }
            return 'c';
        }
    }
}
