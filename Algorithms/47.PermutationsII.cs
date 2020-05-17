using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class PermutationsII
    {


        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            var n = nums.Length;

            var result = new List<IList<int>>();
            if (n == 0) return result;

            Array.Sort(nums);

            DFS(nums, new bool[n], 0, new List<int>(), result);

            return result;
        }

        private void DFS(int[] nums, bool[] isVisited, int start, IList<int> oneResult, IList<IList<int>> result)
        {
            var n = nums.Length;

            if (oneResult.Count == n)
            {
                result.Add(new List<int>(oneResult));
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (isVisited[i]) continue;
                    if (i > 0 && nums[i - 1] == nums[i] && isVisited[i - 1]) continue;

                    oneResult.Add(nums[i]);
                    isVisited[i] = true;
                    DFS(nums, isVisited, i, oneResult, result);
                    isVisited[i] = false;
                    oneResult.RemoveAt(oneResult.Count - 1);
                }
            }
        }
    }
}
