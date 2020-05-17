using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            s += "E";
            char[] inputString = s.ToArray();
            int inputLenght = s.Length;
            int i = 0;
            int val = 0;
            int val1 = 1;
            int result = 0;
            if (inputLenght == 1)
                return 0;
            if (inputLenght == 2)
            {
                return checkValue(inputString[0]);
            }
            while (inputString[i]!='E')
            {
                if ((val = checkValue(inputString[i])) >= (val1 = checkValue(inputString[i + 1])))
                {
                    result += val;
                    i++;
                }
                else
                {
                    result += val1 - val;
                    i++;
                    i++;
                }
            }
            return result;
        }
        public int checkValue(char value)
        {
            switch(value)
            {
                case 'M':
                    {
                        return 1000;
                    }
                case 'D':
                    {
                        return 500;
                    }
                case 'C':
                    {
                        return 100;
                    }
                case 'L':
                    {
                        return 50;
                    }
                case 'X':
                    {
                        return 10;
                    }
                case 'V':
                    {
                        return 5;
                    }
                case 'I':
                    {
                        return 1;
                    }
                default:
                    return 0;
            }
        }
    }
}
