
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    /*Given an array of integers, return indices of the two numbers such that they add up to a specific target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

Example:

Given nums = [2, 7, 11, 15], target = 9,

Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1].*/

    class TwoSum
    {
        public int[] Twosum(int[] nums, int target)
        {

            var items = new Dictionary<int, int>(); //crea un diccionario
            for (var i = 0; i < nums.Length; i++) //loop
            {
                var rest = target - nums[i]; //resto = target - numero en el array
                if (items.ContainsValue(rest)) //resto esta en el diccionario?
                {
                    int key = 0;
                    foreach (KeyValuePair<int, int> pair in items)
                    {
                        if (pair.Value == rest)
                        {
                            key =pair.Key;
                        }
                    }
                    return new int[] { key, i }; // devuelvo el numero del y el                                                          index del array
                }
                else
                {
                    items.Add(i, nums[i]);// si no esta, lo agrego al diccionario.
                }
            }
            throw new Exception("You may assume that each input would have exactly one solution");
        }

    }
}
