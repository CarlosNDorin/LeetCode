using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Valid_Parentheses
    {
        public bool IsValid(string s)
        {
            if (s.Length == 0)
               return true;
            if (s.Length == 1)
               return false;
            Dictionary<char, char> dict = new Dictionary<char, char>();
            dict.Add(']', '[');
            dict.Add(')','(');
            dict.Add('}', '{');
            int count = s.Length;
            int space = 0;
            for(int i = 1; i < count;i++)
            {
               if (dict.ContainsKey(s.ElementAt(i)) && s.ElementAt(i-1) == dict[s.ElementAt(i)])
                {
                    s = s.Remove(i - 1, 2);
                    i = i - 1 - space;
                    space = 0;
                    count -= 2;
                }
                else
                {
                    space++;
                }
            }
            if (space == 0 && count == 0)
                return true;
            else
                return false;
        }
    }
}
