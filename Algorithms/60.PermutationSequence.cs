using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class PermutationSequence
    {
        public string GetPermutation(int n, int k)
        {
            var factorial = new int[n + 1];
            var nums = new List<int>();

            var sum = 1;
            factorial[0] = 1;
            for (var i = 1; i <= n; i++)
            {
                sum *= i;
                factorial[i] = sum;
                nums.Add(i);
            }
            k = k - 1;
            var sb = new StringBuilder();
            for (var i = 1; i <= n; i++)
            {
                var idx = k / factorial[n - i];
                sb.Append(nums[idx].ToString());
                nums.RemoveAt(idx);
                k -= idx * factorial[n - i];
            }
            return sb.ToString();
        }
    }
}
