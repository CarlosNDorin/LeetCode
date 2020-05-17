using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();

            if (s.Length != t.Length)
                return false;

            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i]))
                    dic.Add(s[i], 1);
                else
                    dic[s[i]]++;
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (!dic.ContainsKey(t[i]))
                    return false;
                else
                    dic[s[i]]--;
            }

            foreach (KeyValuePair<char, int> keyValuePair in dic)
            {
                if (keyValuePair.Value != 0)
                    return false;
            }
            return true;
        }
    }
}
