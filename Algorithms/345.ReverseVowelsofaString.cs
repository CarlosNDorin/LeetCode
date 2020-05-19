using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class ReverseVowelsofaString
    {
        static char[] array1 = { 'a', 'e', 'i', 'o', 'u','A', 'E', 'I', 'O', 'U' };
        HashSet<char> vowels = new HashSet<char>(array1);

        public string ReverseVowels(string s)
        {
            int P1 = 0;
            int P2 = s.Length - 1;
            List<char> listChar = new List<char>(s.ToList());

            while(P1 < P2)
            {
                if(!vowels.Contains(listChar[P1]) && !vowels.Contains(listChar[P2]))
                {
                    P1++;
                    P2--;
                }
                else
                {
                    if (!vowels.Contains(listChar[P1]) && vowels.Contains(listChar[P2]))
                    {
                        P1++;
                    }
                    else
                    {
                        if (vowels.Contains(listChar[P1]) && !vowels.Contains(listChar[P2]))
                        {
                            P2--;
                        }
                        else
                        {
                            char temp = listChar[P1];
                            listChar[P1] = listChar[P2];
                            listChar[P2] = temp;
                            P1++;
                            P2--;
                        }
                    }
                }

            }
            return string.Join("", listChar);
        }
    }
}
