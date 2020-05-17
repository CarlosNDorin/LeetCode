using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class ReverseInteger
    {
        public int Reverse(int x)
        {
            try
            {
                string input = x.ToString();
                int answer = 0;
                string output = string.Empty;
                List<char> list = input.ToList();
                if (list.First() == '-')
                {
                    list.Remove('-');
                    list.Reverse();
                    list.Insert(0, '-');
                    foreach (char c in list)
                    {
                        output += c;
                    }
                    answer = int.Parse(output);
                    return answer;
                }
                else
                {
                    list.Reverse();
                    foreach (char c in list)
                    {
                        output += c;
                    }
                    int.TryParse(output, out answer);
                    return answer;
                }
            }
            catch(Exception e)
            {
                return 0;
            }
        }
    }
}
