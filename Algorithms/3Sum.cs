using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class ThreeSumClass
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            //Sorting will bring same numbers in the array next to each other.
            Array.Sort(nums);

            IList<IList<int>> res = new List<IList<int>>();
            for (int pivot = 0; pivot < nums.Length; pivot++)
            {
                //No need to pivot on the same number as the one previously used.
                if (pivot > 0 && nums[pivot] == nums[pivot - 1])
                {
                    continue;
                }

                //Since we have to find triplets whose sum is 0.
                int targetSum = -(nums[pivot]);

                int startIndex = pivot + 1;
                int endIndex = nums.Length - 1;

                while (startIndex < endIndex)
                {
                    int sumOfValuesAtStartAndEndIndex = nums[startIndex] + nums[endIndex];
                    if (sumOfValuesAtStartAndEndIndex == targetSum)
                    {
                        res.Add(new int[] { nums[pivot], nums[startIndex], nums[endIndex] });

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

            return res;
        }
    }
}
