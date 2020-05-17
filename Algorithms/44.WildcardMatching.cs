using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class WildcardMatching
    {
        public bool IsMatch(string s, string p)
        {
            int sLength = s.Length;
            int pLength = p.Length;

            bool[,] dp = new bool[sLength + 1, pLength + 1];
            dp[0, 0] = true;
			for(int j = 1; j<=p.Length;j++)
            {
                if (p[j-1] == '*' && dp[0, j-1] == true)
                    dp[0, j] = true;
				else
                    dp[0, j] = false;
            }

            for (int i = 0; i<s.Length;i++)
            {
				for(int j=0;j<p.Length;j++)
                {
					if(s[i]==p[j] || p[j]=='?')
                    {
                        dp[i + 1, j + 1] = dp[i, j];
                    }
					if(p[j]=='*')
                    {
                        if (dp[i + 1, j] || dp[i, j + 1])
                            dp[i + 1, j + 1] = true;
                    }
                }
            }
			
            return dp[sLength,pLength];
        }
    }
}
