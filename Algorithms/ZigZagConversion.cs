using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class ZigZagConversion
    {
        public string Convert(string s, int numRows)
        {
            int lenght = s.Length;
            int numColsTemp = s.Length / numRows;
            if (numColsTemp == 0)
                numColsTemp = 1;
            int numDiagChars = numRows - 2;
            int numCols = 0;
            if  (numRows*numColsTemp+ (numDiagChars* (numColsTemp - 1))< lenght)
                numCols = numColsTemp + (numDiagChars * (Math.Max((numColsTemp - 1), 1)))+1;
            else
                numCols = numColsTemp + (numDiagChars *(Math.Max((numColsTemp - 1),1)));
            char[,] table = new char[numCols, numRows];
            char[] inputArray = s.ToArray();
            string output = string.Empty;

            if (numRows == 1)
                return s;
            if (lenght ==1)
            {
                return s;
            } 
            int actualColumn = 0;
            int actualRow = 0;
            int indexArray = 0;

            while (indexArray <= lenght-1)
            {
                for (; actualRow < numRows; actualRow++)
                {
                    if (indexArray > lenght - 1)
                        break;
                    table[actualColumn, actualRow] = inputArray[indexArray];
                    indexArray++;
                }
                actualColumn++;
                actualRow--;
                actualRow--;
                for (; actualRow > 0; actualRow--)
                {
                    if(indexArray > lenght - 1)
                        break;
                    table[actualColumn, actualRow] = inputArray[indexArray];
                    indexArray++;
                    actualColumn++;
                }

            }

            actualColumn = 0;
            actualRow = 0;


           /*    for(; actualRow< numRows;actualRow++)
               {
                   for (; actualColumn < numCols; actualColumn++)
                   {
                       Console.Write(table[actualColumn, actualRow]);
                   }
                   actualColumn = 0;
                   Console.WriteLine();
               }
            actualColumn = 0;
            actualRow = 0;*/

            for (; actualRow < numRows; actualRow++)
            {
                for (; actualColumn < numCols; actualColumn++)
                {
                    if(table[actualColumn, actualRow] != '\0')
                    output +=table[actualColumn, actualRow];
                }
                actualColumn = 0;
            }
            return output;
        }
        public string Convert1(string s, int numRows)
        {
            if (String.IsNullOrEmpty(s) || numRows == 1)
                return s;

            var dict = new Dictionary<int, StringBuilder>();
            int start = 0;
            bool down = true;
            for (int i = 0; i < numRows; ++i)
            {
                dict[i] = new StringBuilder();
            }
            for (int i = 0; i < s.Length; ++i)
            {
                dict[start].Append(s[i]);
                if (start == numRows - 1)
                {
                    down = false;
                }
                else if (start == 0)
                {
                    down = true;
                }

                if (down)
                {
                    start++;
                }
                else
                {
                    start--;
                }
            }

            StringBuilder sb = dict[0];
            for (int i = 1; i < numRows; ++i)
            {
                sb.Append(dict[i]);
            }
            return sb.ToString();

        }
    }
}
