using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            string text = x.ToString();
            string textinverted = new string(text.Reverse().ToArray());
            if (text.Length == 1)
            {
                return true;
            }
            if (text.CompareTo(textinverted) == 0)
                return true;
            return false;
        }
    }
}
