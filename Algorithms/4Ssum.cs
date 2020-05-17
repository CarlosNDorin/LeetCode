using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class _4Sum
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            Array.Sort(nums);
            Dictionary<string, int[]> dic = new Dictionary<string, int[]> ();
            IList<IList<int>> res = new List<IList<int>>();
            for (int firstPivot = 0; firstPivot < nums.Length - 1; firstPivot++)
            {
                for (int pivot = firstPivot + 1; pivot < nums.Length - 1; pivot++)
                {
                    //No need to pivot on the same number as the one previously used.
                    /*   if (pivot > 1 && nums[pivot] == nums[pivot - 1])
                       {
                           continue;
                       }*/

                    //Since we have to find triplets whose sum is 0.
                    int targetSum = target;

                    int startIndex = pivot + 1;
                    int endIndex = nums.Length - 1;

                    while (startIndex < endIndex)
                    {
                        int sumOfValuesAtStartAndEndIndex = nums[firstPivot] + nums[pivot] + nums[startIndex] + nums[endIndex];
                        if (sumOfValuesAtStartAndEndIndex == targetSum)
                        {
                            var a = new int[] { nums[firstPivot], nums[pivot], nums[startIndex], nums[endIndex] };
                            string b = string.Empty;
                            foreach (int i in a)
                            {
                                b += i.ToString();
                            }

                            if (!dic.ContainsKey(b))
                            {
                                int[] intList = { nums[firstPivot], nums[pivot], nums[startIndex], nums[endIndex] };
                                res.Add(intList);
                                dic.Add(b, intList);
                            }
                            //No need to look at the same number if its already is in the result.
                            while (startIndex < endIndex && nums[startIndex] == nums[startIndex + 1])
                            {
                                startIndex++;
                            }

                            //No need to look at the same number if its already is in the result.
                            while (startIndex < endIndex && nums[endIndex] == nums[endIndex - 1])
                            {
                                endIndex--;
                            }

                            startIndex++;
                            endIndex--;
                        }
                        else
                        {
                            //If sumOfValuesAtStartAndEndIndex is less than the targetSum,
                            //we need to increase the sumOfValuesAtStartAndEndIndex
                            //by taking the next big number.
                            if (sumOfValuesAtStartAndEndIndex < targetSum)
                            {
                                startIndex++;
                            }
                            //Else we need to decrease the sumOfValuesAtStartAndEndIndex,
                            //by taking the next smaller number.
                            else
                            {
                                endIndex--;
                            }
                        }
                    }
                }
            }



            return res;
        }
    }
}
