using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class CombinationSum2
    {
       
        public IList<IList<int>> combinationSum2(int[] candidates, int target)
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
                if (i > start && arr[i - 1] == arr[i])
                    continue; // si es igual al anterior!
                curr.Add(arr[i]);
                Find(lists, arr, target - arr[i], i + 1, curr);
                curr.RemoveAt(curr.Count - 1);
            }
        }
    }
}

//Working one
/* public IList<IList<int>> combinationSum2(int[] candidates, int target)
        {
            Array.Sort(candidates);
            IList<IList<int>> lists = new List<IList<int>>();
            IList<IList<int>> listsReturn = new List<IList<int>>();
            Find(lists, candidates, target, 0, new List<int>());
            HashSet<string> hash = new HashSet<string>(); 
            for(int i = 0; i<lists.Count;i++)
            {
                string key = string.Join(",", lists[i]);
                if(!hash.Contains(key))
                {
                    hash.Add(key);
                    listsReturn.Add(lists[i]);
                }
            }
            return listsReturn;
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
                Find(lists, arr, target - arr[i], i+1, curr);
                curr.RemoveAt(curr.Count - 1);
            }
        }
*/