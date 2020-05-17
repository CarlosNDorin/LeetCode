using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class CombinationSum
    {

        public IList<IList<int>> combinationSum(int[] candidates, int target)
        {
            Array.Sort(candidates);
            IList<IList<int>> lists = new List<IList<int>>();
            Find(lists, candidates, target, 0, new List<int>());
            return lists;
        }

        public void Find(IList<IList<int>> lists, int[] arr, int target, int start, IList<int> curr)
        {
            if (target == 0)
            {
                lists.Add(new List<int>(curr));
                return;
            }

            for (int i = start; i < arr.Length && arr[i] <= target; i++)
            {
                curr.Add(arr[i]);
                Find(lists, arr, target - arr[i], i, curr);
                curr.RemoveAt(curr.Count - 1);
            }
        }
    }
}

