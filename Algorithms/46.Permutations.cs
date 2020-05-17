using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Permutations
    {
        public IList<IList<int>> Permute(int[] nums)
        {

            IList<IList<int>> returnable = new List<IList<int>>();
            List<int> numsList = nums.ToList();
            numsList.Sort();
            PermuteHelper(numsList, new List<int>(), returnable);
            return returnable;
        }

        public void PermuteHelper(List<int> nums, List<int> choose, IList<IList<int>> result)
        {
            if (nums.Count == 0) //Get to the end.
            {
                List<int> newList = choose.ToList(); //using to list, create a new object!
                result.Add(newList);                 //If We dont create a new object, it change during the runtime!
            }
            else
            {
                for (int index = 0; index < nums.Count; index++) //For the pivoting!
                {
                    //Choose
                    int num = nums[index]; // Get the actual Pivot
                    nums.RemoveAt(index);  // Remove from the numbers to choose
                    choose.Add(num);       // Add this pivot number to list 

                    //Explore
                    PermuteHelper(nums, choose, result); // The recursion

                    //Unchoose
                    choose.Remove(num); //Delete the pivot from the choose list
                    nums.Insert(index, num); // Y lo devuevlo al buffer para elegir
                }
               
            }
            
        }
    }
}
