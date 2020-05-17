using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Algorithms
{
    class LongestPalindromicSubstring
    {
        public String longestPalindromeSubstring(String s)
        {
            int lenght = s.Length;

            if (lenght == 0)
                return "";
            if (lenght == 1)
                return s;
            if (lenght == 2 && (s.ElementAt(0).ToString() != s.ElementAt(1).ToString()) )
               return s.ElementAt(0).ToString();
            int[,] table = new int[lenght, lenght] ;
            for(int i = 0; i < lenght; i++)
            {
                for(int j = 0; j < lenght;j++)
                {
                    table[i, j] = -1;
                }
            }

           for (int i = 0; i < lenght;i++)
               table[i, i] = 1;



            for (int j = 1; j <= lenght -1; j++)
            {
                for (int i = 0; i < j ; i++)
                {
                    if (s[j] == s[i])
                    {
                            if (table[j - 1, i + 1] == 1 || table[j - 1, i + 1] == -1)
                            {
                                table[j, i] = 1;
                            }
                            else
                            {
                                table[j, i] = 0;
                            }
                    }

                    else
                    {
                        table[j, i] = 0;
                    }
                }
            }       
       
        /*  for(int i = 0; i<lenght; i++)
            {
                for(int j=0;j<lenght;j++)
                {
                    Console.Write("{0,3}", table[j, i]);
                }
                Console.WriteLine();
            }*/
            int start = -1;
            int finish = -1;

            string maxResult = string.Empty;
            for (int i = 0; i <= lenght-1; i++)
            {
                for (int j = 0; j <= lenght-1 ; j++)
                {
                    if (table[j, i] == 1 && start != -1)
                    {
                        finish = j;
                    }
                    if (table[j, i] == 1 && start == -1)
                    {
                        start = j;
                    }

                }
                if (finish != -1 && start != -1)
                {
                    char[] maxResultTemptest = new char[finish - start + 1];
                    s.CopyTo(start, maxResultTemptest, 0, finish - start + 1);
                    if (maxResultTemptest.Length > maxResult.Length)
                    {
                        char[] maxResultTemp = new char[finish - start + 1];
                        s.CopyTo(start, maxResultTemp, 0, finish - start + 1);
                        maxResult = string.Join("", maxResultTemp);
                        finish = -1;
                        start = -1;
                    }
                    else
                    {
                        finish = -1;
                        start = -1;
                    }
                }
                else
                {
                    finish = -1;
                    start = -1;
                }
            }
            if (maxResult == "")
                return s.ElementAt(0).ToString();
            return maxResult;
        }
    }
}
        /*
            if (s.Count() == 0) return "";  

            int longest = 0;
            int start = 0;
            int end = 0;
            bool[,] table = new bool[s.Count(), s.Count()];
            table[0, 0] = true;

            for (int i = 1; i < s.Count(); i++)
            {
                //All single characters are palindrome in itself
                table[i, i] = true;

                //All two characters are palindrome if two characters are equal
                table[i - 1, i] = s.ElementAt(i - 1) == s.ElementAt(i);
                if (table[i - 1, i] && longest <= 2)
                {
                    longest = 2;
                    start = i - 1;
                    end = i;
                }

            }

            for (int L = 3; L <= s.Count(); L++)
            {
                for (int i = 0; i <= s.Count() - L; i++)
                {
                    int j = i + L - 1;
                    table[i, j] = table[i + 1, j - 1]
                                   && (s.ElementAt(i) == s.ElementAt(j));

                    if (table[i, j] && longest <= L)
                    {
                        longest = L;
                        start = i;
                        end = j;
                    }
                }
            }
            return s.Substring(start, end + 1);
        }
    }
    */

/* public string Pali(string s)
        {
            if (s.Length == 0)
                return "";
            if (s.Length == 1)
                return s;
            if (s.Length == 2)
            {
                if (s.First() != s.Last())
                {
                    return s.First().ToString();
                }
            }
            List<char> wordToCheck = s.ToList<char>();
            List<char> toSend = new List<char>();
            int largestPali = 0;
            string stringToAnswer = string.Empty;
            for (int start = 0; start<=wordToCheck.Count-1; start++)
            {
                toSend.Add(wordToCheck.ElementAt(start));
                for (int pivot = start+1; pivot <=wordToCheck.Count-1; pivot++)
                {
                    toSend.Add(wordToCheck.ElementAt(pivot));
                    string answer = CheckPali(toSend.ToArray());
                    if (answer != null)
                    {
                        if (answer.Length > largestPali)
                        {
                            largestPali = answer.Length;
                            stringToAnswer = answer;
                        }
                    }
                }
                toSend.Clear();
            }
            if (stringToAnswer == "")
            {
                stringToAnswer = s.First().ToString();
            }
            return stringToAnswer;
        }
        public string CheckPali(char[] wordToCheck)
        {
            if (wordToCheck.Length == 1)
            {
                return wordToCheck.ToString();
            }
            for (int i = 0; i<wordToCheck.Length; i++)
            {
                if (wordToCheck[i] != wordToCheck[wordToCheck.Length -1 - i])
                    return null;
            }
            string toSend = new string (wordToCheck);
            return toSend;
        }
    
*/