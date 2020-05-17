using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class LongesSubStringWithoutRepeatingCharacters
    {

        /*Given a string, find the length of the longest substring without repeating characters.

Example 1:

Input: "abcabcbb"
Output: 3 
Explanation: The answer is "abc", with the length of 3. 
Example 2:

Input: "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:

Input: "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3. 
             Note that the answer must be a substring, "pwke" is a subsequence and not a substring.*/

            public int LongestSubString(string s)
            {
                List<char> listOfLetter = s.ToList();
                int index = 0;
                int global = 0;
                foreach (char c in listOfLetter)
                {
                    int counter = 0;
                    List<char> listCharUsed = new List<char>();
                    for (int position = index; position < listOfLetter.Count(); position++)
                    {
                        if (listCharUsed.Contains(listOfLetter[position]))
                        {
                            break;
                        }
                        else
                        {
                            counter++;
                            listCharUsed.Add(listOfLetter[position]);
                        }
                    }
                    index++;
                    if (counter > global)
                    {
                        global = counter;
                    }
                }
                return global;
            }

        }
    }

