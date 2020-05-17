using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class IntegertoRoman
    {
        public string IntToRoman(int num)
        {

            string result = string.Empty;
            while (num != 0)
            {
                if(num >=1000)
                {
                    result += "M";
                    num -= 1000;
                }
                if(num < 1000 && num >= 900)
                {
                    result += "CM";
                    num -= 900;
                }
                if(num >= 500 && num < 900 )
                {
                    result += "D";
                    num -= 500;
                }
                if(num >= 400 && num < 500)
                {
                    result += "CD";
                    num -= 400;
                }
                if(num >= 100 && num < 400 )
                {
                    result += "C";
                    num -= 100;
                }
                if(num >= 90 && num < 100 )
                {
                    result += "XC";
                    num -= 90;
                }
                if(num >= 50 && num< 90)
                {
                    result += "L";
                    num -= 50;
                }
                if(num >= 40 && num < 50)
                {
                    result += "XL";
                    num -= 40;
                }
                if(num >= 10 && num <40)
                {
                    result += "X";
                    num -= 10;
                }
                if(num == 9)
                {
                    result += "IX";
                    num -= 9;
                }
                if(num >= 5 && num <9)
                {
                    result += "V";
                    num -= 5;
                }
                if(num == 4)
                {
                    result += "IV";
                    num -= 4;
                }
                if(num < 4 && num > 0)
                {
                    result += "I";
                    num--;
                }
            }


            return result;
        }
    }
}
/*       En vez de if.., recursivas!
 *     public string IntToRoman(int num) {
        if (num >= 1000) return "M" + IntToRoman(num - 1000);

        if (num >= 500) return num >= 900 ? ("CM" + IntToRoman(num - 900)) : ("D" + IntToRoman(num - 500));

        if (num >= 100) return num >= 400 ? ("CD" + IntToRoman(num - 400)) : ("C" + IntToRoman(num - 100));

        if (num >= 50) return num >= 90 ? ("XC" + IntToRoman(num - 90)) : ("L" + IntToRoman(num - 50));

        if (num >= 10) return num >= 40 ? ("XL" + IntToRoman(num - 40)): ("X" + IntToRoman(num - 10));

        if (num >= 5) return num == 9 ? "IX" : "V" + IntToRoman(num - 5);

        if (num > 0) return num == 4 ? "IV" : "I" + IntToRoman(num - 1);

        return "";
    }
*/
