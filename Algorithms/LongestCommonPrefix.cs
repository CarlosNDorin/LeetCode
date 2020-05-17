using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class LongestcommonPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            int amountOfStrings = strs.Length;
            if (amountOfStrings == 0)
                return "";
            if (amountOfStrings == 1)
                return strs[0];
            string result = string.Empty;
            string toCompare = string.Empty;
            List<string> listOfStrings = strs.ToList();
            int smallestString = listOfStrings[0].Length;
            toCompare = listOfStrings[0];
            foreach (string s in listOfStrings)
            {
                if (s.Length < smallestString)
                {
                    smallestString = s.Length;
                    toCompare = s;
                }
            }
            listOfStrings.Remove(toCompare);
            for( int j = 0; j< smallestString; j++)
            {    
                foreach(string s in listOfStrings)
                {
                    if (toCompare.ElementAt(j) != s.ElementAt(j))

                        return toCompare.Substring(0,j);
                }
            }
            return toCompare;
        }
    }
}
