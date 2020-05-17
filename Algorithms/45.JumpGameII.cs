using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class JumpGameII
    {
       /* public int Jump(int[] nums)
        {
            
            int?[] dp = new int?[nums.Length];
            dp[0] = 0;

            for(int i = 1; i<nums.Length;i++)
            {
                for(int j=0; j<i; j++)
                {
                   if(nums[j]+j>=i)
                    {
                        if (dp[i] == null)
                            dp[i] = 1;
                        else
                            if (dp[i] > dp[i] + 1)
                                dp[i] = dp[i] + 1;  
                    }
                }
            }
            return (int)dp[nums.Length - 1];
        }*/

        public int Jump(int[] nums)
        {
            int[] jump = new int[nums.Length];

            int farest = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i + nums[i] <= farest)
                    continue;

                for (int j = farest + 1; j <= Math.Min(nums.Length - 1, i + nums[i]); j++)
                {
                    jump[j] = jump[i] + 1;
                }

                farest = i + nums[i];
                if (farest >= nums.Length - 1)
                    break;
            }

            return jump[nums.Length - 1];
        }

    }
}
