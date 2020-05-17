using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class threeSumClose
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            //Sorting will bring same numbers in the array next to each other.
            Array.Sort(nums);
            int max = 0;
            int maxVal = 0;
            int actualDistance = 0;
            for (int pivot = 0; pivot < nums.Length; pivot++)
            {
                //No need to pivot on the same number as the one previously used.
                if (pivot > 0 && nums[pivot] == nums[pivot - 1])
                {
                    continue;
                }

                //Since we have to find triplets whose sum is 0.
                int targetSum = target;

                int startIndex = pivot + 1;
                int endIndex = nums.Length - 1;

                while (startIndex < endIndex)
                {
                    int sumOfValuesAtStartAndEndIndex = nums[startIndex] + nums[endIndex]+nums[pivot];
                    if (sumOfValuesAtStartAndEndIndex == targetSum)
                    {
                        max = 0;
                        maxVal = targetSum;
                        return maxVal;
                    }
                    else
                    {
                        //If sumOfValuesAtStartAndEndIndex is less than the targetSum,
                        //we need to increase the sumOfValuesAtStartAndEndIndex
                        //by taking the next big number.
                        if (sumOfValuesAtStartAndEndIndex < targetSum)
                        {
                            if((sumOfValuesAtStartAndEndIndex >= 0 && targetSum >= 0) || (sumOfValuesAtStartAndEndIndex <= 0 && targetSum <= 0))
                            {
                              actualDistance =  Math.Abs(Math.Abs(sumOfValuesAtStartAndEndIndex) - Math.Abs(targetSum));
                            }
                            else
                            {
                                actualDistance = Math.Abs(Math.Abs(sumOfValuesAtStartAndEndIndex) + Math.Abs(targetSum));
                            }
                            if (max == 0)
                            {
                                max = actualDistance;
                                maxVal = sumOfValuesAtStartAndEndIndex;
                            }
                            if (max > actualDistance)
                            {
                                max = actualDistance;
                                maxVal = sumOfValuesAtStartAndEndIndex;
                            }
                                startIndex++;
                        }
                        //Else we need to decrease the sumOfValuesAtStartAndEndIndex,
                        //by taking the next smaller number.
                        else
                        {
                            if ((sumOfValuesAtStartAndEndIndex >= 0 && targetSum >= 0) || (sumOfValuesAtStartAndEndIndex <= 0 && targetSum <= 0))
                            {
                                actualDistance = Math.Abs(Math.Abs(sumOfValuesAtStartAndEndIndex) - Math.Abs(targetSum));
                            }
                            else
                            {
                                actualDistance = Math.Abs(Math.Abs(sumOfValuesAtStartAndEndIndex) + Math.Abs(targetSum));
                            }
                            if (max == 0)
                            {
                                max = actualDistance;
                                maxVal = sumOfValuesAtStartAndEndIndex;
                            }
                            if (max > actualDistance)
                            {
                                max = actualDistance;
                                maxVal = sumOfValuesAtStartAndEndIndex;
                            }
                            endIndex--;
                        }
                    }
                }
            }

            return maxVal;
        }
    }
}

