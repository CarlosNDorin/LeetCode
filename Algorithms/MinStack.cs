using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class MinStack
    {
        private Stack<int> stack = new Stack<int>();
        private Stack<int> min = new Stack<int>();
        /** initialize your data structure here. */
        public MinStack()
        {

        }

        public void Push(int x)
        {
            if (min.Count == 0 || x <= min.Peek())
            {
                min.Push(x);
            }
            stack.Push(x);
        }

        public void Pop()
        {
            if (stack.Peek() == min.Peek())
                min.Pop();
            stack.Pop();
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int GetMin()
        {
            return min.Peek();
        }
    }
}
