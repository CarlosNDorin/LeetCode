using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class JumpGame
    {
        public bool CanJump(int[] nums)
        {
            if (nums.Contains(0) && nums[nums.Length] == 0)
                return true;
            if (nums.Contains(0))
                return false;

            Stack<Tuple<int, int>> stack = new Stack<Tuple<int, int>>();
            int lenght = nums.Length;

            if (lenght == 0)
                return true;
            if (lenght == 1 && nums[0] == 0)
                return true;
            stack.Push(new Tuple<int, int>(nums[0], 0));

            while (stack.Count != 0)
            {
                Tuple<int, int> tuple = stack.Pop();
                int val = tuple.Item1;
                int pos = tuple.Item2;

                for (int i = pos+1; i <= pos + val; i++)
                {
                    if (i >= lenght - 1)
                        return true;
                    stack.Push(new Tuple<int, int>(nums[i], i));
                }
            }
            return false;
        }
    }
}
