using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class RegularExpressionMatching
    {

        public bool IsMatch(string s, string p)
        {
            s = s.Insert(0, "0");
            p = p.Insert(0, "0");
            char[] inputString = s.ToArray();        
            char[] patterString = p.ToArray();
            int inputLenght = s.Length;
            int patterLenght = p.Length;
            int i, j = 0;
            if (inputLenght == 1 && patterLenght == 1)
                return true;
            if (inputLenght == 1 && patterLenght == 2 && p == "0*")
                return true;
            if (inputLenght == 1 && patterLenght == 2 && p == "0.")
                return false;
            if (inputLenght == 1 && p == "0.") 
                return false;
            if (inputLenght == 1 && p == "0*")
                return true;
            if (p == "0.*")
                return true;

            if (patterLenght == 3)
            {
                if (inputLenght == 1 && patterLenght == 3 && patterString[2] == '*')
                    return true;
            }

            bool[,] table = new bool[inputLenght,patterLenght]; // add one row/column cause it can be *
            table[0, 0] = true;
           
            for(i=1;i<patterLenght;i++)
            {
                if(patterString[i]=='*')
                {
                    table[0, i] = table[0, i - 2];
                }
            }
            if (inputLenght==1)
            {
                i = 2;
                while (i < patterLenght)
                {
                    if (table[0, i] == false)
                        return false;
                    i += 2;
                }
                
                if (patterLenght == 2)
                  return false;
                if (p.Contains("0.*") && patterLenght > 3)
                    return false;
            }
            //---------------
            for (i = 0; i < inputLenght; i++)
            {
                for (j = 0; j < patterLenght; j++)
                {
                    Console.Write("{0}\t", table[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //------------

            for (j = 1; j< patterLenght; j++ )
            {
                for(i = 1; i < inputLenght ; i++)
                {
                    if (inputString[i] == patterString[j] || patterString[j]=='.')//they are equals or '.'
                    {
                        table[i, j] = table[i - 1, j - 1];
                    }
                    if(patterString[j]=='*')
                    {
                        table[i, j] = table[i - 1, j - 1];
                        if(inputString[i]==patterString[j-1] || patterString[j-1]=='.')
                        {
                            //test
                            if (table[i, j - 2])
                                table[i, j] = true;
                            else
                                table[i, j] = table[i - 1, j]; 
                        }
                        else
                        {
                            table[i, j] = table[i, j - 2];
                        }
                    }
                }
            }

            for(i=0; i< inputLenght;i++)
            {
                for(j=0; j<patterLenght;j++)
                {
                    Console.Write("{0}\t", table[i, j]);
                }
                Console.WriteLine();
            }
            
            i = inputLenght-1;
            j = patterLenght-1;
            if (i == 0 && patterString[patterLenght - 1] != '*')
                return false;
            while (i != 0)
            {
                if (!table[i, j])
                    return false;
                if(table[i-1,j-1])
                {
                    i--;
                    j--;
                }
                else
                {
                    if (table[i - 1, j])
                    {
                        i--;
                    }
                    else
                    {
                        if (table[i, j - 2])
                        {
                            j--;
                            j--;
                        }
                        else
                            return false;   
                    }
                }
               
            }
            return true;
        }

       
    }
}
