using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class FirstUniqueCharacterinaString
    {
        public int FirstUniqChar(string s)
        {
            Dictionary<char, int> letterPosition = new Dictionary<char, int>();
            bool[] available = new bool[s.Length];
            int pointer = 0;
            if (s.Length == 0)
                return -1;



            for (int i = 0; i<s.Length;i++)
            {
                if(!letterPosition.ContainsKey(s[i]))
                {
                    letterPosition.Add(s[i], i);
                    available[i] = false;
                }
                else
                {
                    available[i] = true;
                    available[letterPosition[s[i]]] = true;
                }

                while(available[pointer])
                {
                    pointer++;
                    if (pointer >= available.Length)
                        return -1;
                }
            }
            return pointer;
        }
    }
}
