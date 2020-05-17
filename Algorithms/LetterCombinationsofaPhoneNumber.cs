using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class LetterCombinationsofaPhoneNumber
    {
        public IList<string> LetterCombinations(string digits)
        {
            var dict = new Dictionary<char, string>
            {
                {'2', "abc"},
                {'3', "def"},
                {'4', "ghi"},
                {'5', "jkl"},
                {'6', "mno"},
                {'7', "pqrs"},
                {'8', "tuv"},
                {'9', "wxyz"}
            };

            var list = new List<string>();

            if (!string.IsNullOrEmpty(digits))
                Backtrack(list, digits, dict, new List<char>(), 0);

            return list;
        }

        void Backtrack(List<string> list, string digits, Dictionary<char, string> dict, List<char> temp, int start)
        {
            if (temp.Count == digits.Length) list.Add(string.Join("", temp));

            for (var i = start; i < digits.Length; i++)
            {
                for (var j = 0; j < dict[digits[i]].Length; j++)
                {
                    temp.Add(dict[digits[i]][j]);

                    Backtrack(list, digits, dict, temp, i + 1);

                    temp.RemoveAt(temp.Count - 1);
                }

            }
        }
    } 
}
/*
            IList<string> res = new List<string>();
            IList<string> temp = new List<string>();
            if (digits == "")
                return null;
            char first = digits.First<char>();
            digits = digits.Remove(0, 1);
            switch(first)
            {
                case '2':
                    res.Add("a");
                       var testing = LetterCombinations(digits);
                    res.Add(testing);
                    res.Add("b" + LetterCombinations(digits));
                    res.Add("c" + LetterCombinations(digits));
                    return res;
                    break;
                case '3':
                    res.Add("d" + LetterCombinations(digits));
                    res.Add("e" + LetterCombinations(digits));
                    res.Add("f" + LetterCombinations(digits));
                    return res;
                    break;
                case '4':
                    res.Add("g" + LetterCombinations(digits));
                    res.Add("h" + LetterCombinations(digits));
                    res.Add("i" + LetterCombinations(digits));
                    break;
                case '5':
                    res.Add("j" + LetterCombinations(digits));
                    res.Add("k" + LetterCombinations(digits));
                    res.Add("l" + LetterCombinations(digits));
                    break;
                case '6':
                    res.Add("m" + LetterCombinations(digits));
                    res.Add("n" + LetterCombinations(digits));
                    res.Add("o" + LetterCombinations(digits));
                    break;
                case '7':
                    res.Add("p" + LetterCombinations(digits));
                    res.Add("q" + LetterCombinations(digits));
                    res.Add("r" + LetterCombinations(digits));
                    res.Add("s" + LetterCombinations(digits));
                    break;
                case '8':
                    res.Add("t" + LetterCombinations(digits));
                    res.Add("u" + LetterCombinations(digits));
                    res.Add("v" + LetterCombinations(digits));
                    break;
                case '9':
                    res.Add("w" + LetterCombinations(digits));
                    res.Add("x" + LetterCombinations(digits));
                    res.Add("y" + LetterCombinations(digits));
                    res.Add("z" + LetterCombinations(digits));
                    break;
                default:
                    break;
            }
            return res;

        }
    }
}
*/