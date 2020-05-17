using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class ValidPalindrome
    {

        public bool IsPalindrome(string s)
        {
            if (s.Length == 0)
                return true;
            s = s.ToLower();
            HashSet<char> table = new HashSet<char>();
            table.Add('a');
            table.Add('b');
            table.Add('c');
            table.Add('d');
            table.Add('e');
            table.Add('f');
            table.Add('g');
            table.Add('h');
            table.Add('i');
            table.Add('j');
            table.Add('k');
            table.Add('l');
            table.Add('m');
            table.Add('n');
            table.Add('o');
            table.Add('p');
            table.Add('q');
            table.Add('r');
            table.Add('s');
            table.Add('t');
            table.Add('u');
            table.Add('v');
            table.Add('w');
            table.Add('x');
            table.Add('y');
            table.Add('z');
            table.Add('0');
            table.Add('1');
            table.Add('2');
            table.Add('3');
            table.Add('4');
            table.Add('5');
            table.Add('6');
            table.Add('7');
            table.Add('8');
            table.Add('9');
            
            int end = s.Length - 1;
            int start = 0;

            while (start < end)
            {
                if (!table.Contains(s[start]))
                {
                    start++;
                    continue;
                }
                if (!table.Contains(s[end]))
                {
                    end--;
                    continue;
                }
                if (s[start] != s[end])
                    return false;
                start++;
                end--;
            }
            return true;
        }
    }
}
