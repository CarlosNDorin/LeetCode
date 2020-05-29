using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class IsSubsequence
    {
        public bool IsASubsequence(string s, string t)
        {
            if (s.Length == 0)
                return true;
            if (s.Length > t.Length)
                return false;
            int posInS = 0;
            int posInT = 0;
            while(posInT < t.Length)
            {
                if (s[posInS] == t[posInT])
                    posInS++;
                if (posInS == s.Length)
                    return true;
                posInT++;
            }
            return false;
        }
    }
}
