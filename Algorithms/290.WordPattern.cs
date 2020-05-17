using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class WordPattern
    {
        public bool Wordpattern(string pattern, string str)
        {
            string[] strArray = str.Split(' ').ToArray();

            if (strArray.Length != pattern.Length)
                return false;
            int patCount = 0;
            int strCount = 0;
            int patKey;
            int strKey;
            Dictionary<char, int> patDic = new Dictionary<char, int>();
            Dictionary<string, int> strDic = new Dictionary<string, int>();

            for(int i = 0; i<pattern.Length;i++)
            {
                if(!patDic.ContainsKey(pattern[i]))
                {
                    patDic.Add(pattern[i],patCount);
                    patKey = patCount;
                    patCount++;
                }
                else
                {
                    patKey = patDic[pattern[i]];
                }

                if(!strDic.ContainsKey(strArray[i]))
                {
                    strDic.Add(strArray[i], strCount);
                    strKey = strCount;
                    strCount++;
                }
                else
                {
                    strKey = strDic[strArray[i]];
                }

                if (strKey != patKey)
                    return false;
            }
            return true;
        }
    }
}
