using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class StringtoIntegerAtoi
    {
        public int MyAtoi(string str)
        {
            string outputString = string.Empty;
            bool isParsable = false;
            int output = 0;
            if (str.Length == 0)
                return 0;
            int index = 0;
            isParsable = Int32.TryParse(str,out output);
            if (isParsable)
                return output;
            char[] arrayToTest;
            char[] answer= new char [str.Length];
            arrayToTest = str.ToArray();
            try
            {
                while (arrayToTest[index] == ' ')
                {
                    index++;
                }
            }
            catch(Exception e)
            {
                return 0;
            }
            try
            {
                if (arrayToTest[index] == '-'|| arrayToTest[index] == '+')
                {
                    if(arrayToTest[index] == '-')
                     answer[0] = '-';
                    if (arrayToTest[index + 1] < 48 || arrayToTest[index + 1] > 57)
                        return 0;
                    index++;
                }
            }
            catch (Exception e)
            {
                return 0;
            }
            try
            {
                while (arrayToTest[index] >= 48 && arrayToTest[index] <= 57)
                {
                    answer[index] = arrayToTest[index];
                    index++;
                }
            }
            catch(Exception e)
            {
                if(answer[0]=='-')
                    return -2147483648;
                return 2147483647;
            }
            foreach (char c in answer)
            {
                if(c != 0)
                outputString += c;
            }
            isParsable = Int64.TryParse(outputString, out long output1);
            if (output1 > 2147483647)
                return 2147483647;
            if (output1 < -2147483648)
                return -2147483648;
            isParsable = Int32.TryParse(outputString, out output);
            return output;
        }
    }
}
