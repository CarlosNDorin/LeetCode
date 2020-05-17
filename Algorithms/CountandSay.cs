using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class CountandSay
    {
        public string CountAndSay(int n)
        {
            int count = 0;
            string result = "1";
            if (n == 1)
                return "1";
            while (count < n-1)
            {
                result = Say(result);
                count++;
            }
            return result;
        }
        public string Say(string s)
        {
            if (s == "1")
                return "11";

            int counter = 1;
            string result = string.Empty;
            int actualPos = 1;
            char actualVal = s[0];
            while(actualPos <= s.Length-1)
            {
                if (s[actualPos] == actualVal)
                {
                    counter++;   
                }
                else
                {
                    result += counter.ToString() + actualVal;
                    counter = 1;
                    actualVal = s[actualPos];
                }
                actualPos++;
            }
            result += counter.ToString() + actualVal;

            return result;
        }
    }
}
