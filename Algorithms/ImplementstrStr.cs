using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class ImplementstrStr
    {
        public int StrStr(string haystack, string needle)
        {
            if (needle.Length == 0)
                return 0;
            if (haystack.Length == needle.Length)
            {
                if (haystack == needle)
                    return 0;
            }
            if (haystack.Length < needle.Length)
                return -1;

        for (int i = 0; i <= haystack.Length - needle.Length; i++)
            { 
                for(int j = 0; j<needle.Length;j++)
                {
                    if (haystack[i + j] != needle[j])
                        break;
                    if (j == needle.Length-1)
                        return i;
                }
            }
            return -1;
        }

        ///WITH KMP
        public int[] prefix(string P)
        {
           P= P.Insert(0, "$");
            int[] PI = new int[P.Length];
            PI[1] = 0;
            int k = 0;
            for(int q = 2; q < P.Length; q++)
            {
                while(k > 0 && P[k+1]!=P[q])
                {
                    k = PI[k];
                }

                if (P[k + 1] == P[q])
                    k += 1;
                PI[q] = k;
            }

            //FOR PRINT ONLY
            foreach (int i in PI)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            return PI;
        }

        public int[] prefix2(string P) ///empieza de 0
        {
            int[] PI = new int[P.Length];
            PI[0] = 0;
            int k = 0;
            for(int i = 1; i<P.Length;)
            {
                if(P[i]==P[k])
                {
                    PI[i] = k + 1;
                    i++;
                    k++;
                }
                else
                {
                    if (k != 0)
                        k = PI[k - 1];
                    else
                    {
                            PI[i] = 0;
                            i++;
                    }
                }
            }
            foreach (int i in PI)
            {
                Console.Write("{0} ", i);
            }
            return PI;
        }
        public int KMP(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle)) return 0;
            if (string.IsNullOrEmpty(haystack)) return -1;
            var lsp =prefix2(needle);
            int i = 0, j = 0;
            while (i < haystack.Length)
            {
                if (haystack[i] == needle[j])
                {
                    if (j == needle.Length - 1)
                        return i - j;
                    i++;
                    j++;
                }
                else
                {
                    if (j == 0)
                        i++;
                    else
                        j = lsp[j - 1];
                }
            }

            return -1;
        }
    }
}
