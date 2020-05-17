using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class ExcelSheetColumnNumber
    {
        public Dictionary<char, int> ABC = new Dictionary<char, int>()
        {
            {'A',1},
            {'B',2},
            {'C',3},
            {'D',4},
            {'E',5},
            {'F',6},
            {'G',7},
            {'H',8},
            {'I',9},
            {'J',10},
            {'K',11},
            {'L',12},
            {'M',13},
            {'N',14},
            {'O',15},
            {'P',16},
            {'Q',17},
            {'R',18},
            {'S',19},
            {'T',20},
            {'U',21},
            {'V',22},
            {'W',23},
            {'X',24},
            {'Y',25},
            {'Z',26},
        };
        public int TitleToNumber(string s)
        {
            if (s.Length == 0)
                return 0;
            int lenght = s.Length;
            int answer = 0;
            s = Reverse(s);
            for(int i = 0; i<lenght; i++)
            {
                answer += ABC[s[i]] * Pow(i);
            }
            return answer;
        }
        int Pow(int i)
        {
            if (i == 0)
                return 1;
            int answer = 26;
            for (int j = 1;j<i;j++)
            {
                answer *= 26;
            }
            return answer;
        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
