using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class PartitionEqualSubsetSum
    {
        public bool CanPartition(int[] nums)
        {
            var n = nums.Length;
            var sum = nums.Sum();

            if (sum % 2 != 0) return false;

            var target = sum / 2;

            if (nums.Contains(target)) return true;

            var dp = new bool[n + 1, target + 1];

            for (int i = 0; i <= n; i++)
            {
                dp[i, 0] = true;
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j <= target; j++)
                {
                    dp[i, j] = dp[i - 1, j];
                    if (j >= nums[i - 1])
                    {
                        dp[i, j] |= dp[i - 1, j - nums[i - 1]];
                    }
                }
            }
            return dp[n, target];
        }
    }
}
