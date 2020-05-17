using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Generate_Parentheses
    {
        public void Dfs(List<string> result, string s, int left,int right)
        {
            if (left >right)
                return ;
            if (left== 0 && right == 0)
            {
                result.Add(s);
                return;
            }
            if(left>0)
            {
                Dfs(result, s + "(", left - 1, right);
            }
            if (right > 0)
            {
                Dfs(result, s + ")", left, right - 1);
            }

        }
    }
}
