using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class IsomorphicStrings
    {
        public bool IsIsomorphic(string s, string t)
        {
            HashSet<char> lettersReaded = new HashSet<char>();
            Dictionary<char, char> proceded = new Dictionary<char, char>();

            if (s.Length != t.Length)
                return false;

            if (s.Length == 0)
                return true;
            int index = 0;
            for(int i = 0; i<s.Length; i++)
            {
                if (!proceded.ContainsKey(s[index])) //Not char in s in the dictionary
                {
                    if (!lettersReaded.Contains(t[index]))//Not char in t in the hash
                    {
                        proceded.Add(s[index], t[index]); // create the mapping for the keyPair
                        lettersReaded.Add(t[index]); // add the letter to the hash.
                        index++; // next letters
                    }
                    else
                    {
                        return false; // If there is no char in the dictionary but yes in the hash, so means that this char is already maped. 
                    }
                }
                else
                {
                    if (proceded[s[index]] != t[index])
                    {
                        return false;
                    }
                    else
                    {
                        index++;
                    }
                }
            }
            return true;
        }
    }
}
