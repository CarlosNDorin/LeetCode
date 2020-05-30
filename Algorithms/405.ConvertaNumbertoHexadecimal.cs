using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class ConvertaNumbertoHexadecimal
    {
        public string ToHex(int num)
        {
            if (num == 0)
                return "0";
            Dictionary<int, char> hexaDic = new Dictionary<int, char>()
            {
                { 10, 'a' },
                { 11, 'b' },
                { 12, 'c' },
                { 13, 'd' },
                { 14, 'e' },
                { 15, 'f'}
            };
            bool negative = false;
            if (num < 0)
                negative = true;

            StringBuilder result = new StringBuilder();
            for(int i = 0; i<8; i++)
            {
              int localVal = 0;
                for(int exponent = 0; exponent <4; exponent++)
                {
                    if((num & 1) == 1)
                    {
                        localVal += (int)Math.Pow(2, exponent);
                    }
                    num = num >> 1;
                }
                if(localVal>=10)
                {
                    result.Insert(0,hexaDic[localVal]);
                }
                else
                {
                    result.Insert(0, localVal);
                }
            }
            if (negative)
            {
                return result.ToString().PadLeft(8, 'f');
            }
            else
            {
                return result.ToString().TrimStart('0');
            }
        }
    }
}
