using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class ReverseString
    {
        public void reverseString(char[] s)
        {
            int start = 0;
            int end = s.Count() - 1;
            char temp;
            while(start <= end)
            {
                temp = s[end];
                s[end] = s[start];
                s[start] = temp;
                start++;
                end--;
            }
        }
    }
}
